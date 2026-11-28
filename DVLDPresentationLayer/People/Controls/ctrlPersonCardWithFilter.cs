using DVLD.Global_Classes;
using DVLDBusinessLayer;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                cbFilterBy.Enabled = _FilterEnabled;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            mtxtSearch.Focus();

        }

        private int _PersonID = -1;

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {

            cbFilterBy.SelectedIndex = 1;
            mtxtSearch.Text = PersonID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(mtxtSearch.Text));
                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(mtxtSearch.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnPersonSelected(ctrlPersonCard1.PersonID);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtSearch.Text = "";
            mtxtSearch.Focus();
        }

        private bool IsEmptyTextBox()
        {
            if (string.IsNullOrEmpty(mtxtSearch.Text.Trim()))
            {
                clsUtil.ShowError(mtxtSearch, true, "This field is required!");
                return true;
            }
            else
            {
                clsUtil.ShowError(mtxtSearch, false, "");
                return false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (IsEmptyTextBox())
                return;

            FindNow();
        }


        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received
            cbFilterBy.SelectedIndex = 1;
            mtxtSearch.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm1 = new frmAddUpdatePerson();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }

        //public void FilterFocus()
        //{
        //    mtxtSearch.Focus();
        //}

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
