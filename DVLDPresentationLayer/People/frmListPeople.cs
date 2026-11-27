using DVLDBusinessLayer;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmListPeople : MaterialForm
    {

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GenderCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GenderCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvAllPeople.DataSource = _dtPeople;
            lblNumberOfRecords.Text = dgvAllPeople.Rows.Count.ToString();
        }

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvAllPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblNumberOfRecords.Text = dgvAllPeople.Rows.Count.ToString();

            if (dgvAllPeople.Rows.Count > 0)
            {
                dgvAllPeople.Columns[0].HeaderText = "Person ID";
                dgvAllPeople.Columns[0].Width = 110;

                dgvAllPeople.Columns[1].HeaderText = "National No.";
                dgvAllPeople.Columns[1].Width = 120;


                dgvAllPeople.Columns[2].HeaderText = "First Name";
                dgvAllPeople.Columns[2].Width = 120;

                dgvAllPeople.Columns[3].HeaderText = "Second Name";
                dgvAllPeople.Columns[3].Width = 140;


                dgvAllPeople.Columns[4].HeaderText = "Third Name";
                dgvAllPeople.Columns[4].Width = 120;

                dgvAllPeople.Columns[5].HeaderText = "Last Name";
                dgvAllPeople.Columns[5].Width = 120;

                dgvAllPeople.Columns[6].HeaderText = "Gender";
                dgvAllPeople.Columns[6].Width = 120;

                dgvAllPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvAllPeople.Columns[7].Width = 140;

                dgvAllPeople.Columns[8].HeaderText = "Nationality";
                dgvAllPeople.Columns[8].Width = 120;


                dgvAllPeople.Columns[9].HeaderText = "Phone";
                dgvAllPeople.Columns[9].Width = 120;


                dgvAllPeople.Columns[10].HeaderText = "Email";
                dgvAllPeople.Columns[10].Width = 170;
            }
        }

        private void mtxtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gender":
                    FilterColumn = "GenderCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (mtxtSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvAllPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                // in this case we deal with integer not string.
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, mtxtSearch.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, mtxtSearch.Text.Trim());

            lblNumberOfRecords.Text = dgvAllPeople.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtSearch.Visible = (cbFilterBy.Text != "None");

            if (mtxtSearch.Visible)
            {
                mtxtSearch.Text = "";
                mtxtSearch.Focus();
            }
        }

        private void mtxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _ShowPersonInfoForm()
        {
            int PersonID = Convert.ToInt32(dgvAllPeople.CurrentRow.Cells["PersonID"].Value);
            MaterialForm frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void _ShowAddPersonForm()
        {
            MaterialForm frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void _ShowUpdatePersonForm()
        {
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells["PersonID"].Value;
            MaterialForm frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void _DeletePerson()
        {
            int PersonID = Convert.ToInt32(dgvAllPeople.CurrentRow.Cells["PersonID"].Value);

            if (MessageBox.Show($"Are you sure you want delete this person with ID {PersonID} ?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            _ShowPersonInfoForm();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _ShowAddPersonForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _ShowUpdatePersonForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            _ShowPersonInfoForm();
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            _ShowAddPersonForm();
        }

        private void tttadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowUpdatePersonForm();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }

        private void dgvAllPeople_DoubleClick(object sender, EventArgs e)
        {
            _ShowPersonInfoForm();
        }
    }
}
