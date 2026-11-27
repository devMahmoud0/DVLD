using DVLD.Controls;
using DVLD.People;
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

namespace DVLD
{
    public partial class frmMain : MaterialForm
    {

        public bool IsLogout { get; private set; }

        private BindingSource bs = new BindingSource();
        private DataTable CurrentPeopleTable => (DataTable)bs.DataSource;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            materialDrawer1.ShowIconsWhenHidden = true;
            materialDrawer1.Invalidate();
            _RefreshPeopleList();

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.BaseTabControl = tcMain;

            materialDrawer1.UsePreProcessIcons = false;
            materialDrawer1.UsePreProcessIcons = true;

            //materialDrawer1.ShowIconsWhenHidden = true;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Invalidate();

        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var MaterialManager = MaterialSkinManager.Instance;

            MaterialManager.Theme = MaterialSkinManager.Themes.LIGHT;

            MaterialManager.ColorScheme = new MaterialColorScheme(
                Color.FromArgb(21, 101, 192),
                Color.FromArgb(13, 71, 161),
                Color.FromArgb(100, 181, 246),
                Color.FromArgb(255, 255, 255),
                Color.White
            );
        }

        private void pbCurrentUser_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }

        // ------------------------ [ People Tab ] ------------------------ //

        private void _RefreshPeopleList()
        {
            DataTable dt = clsPerson.GetAllPeople();
            bs.DataSource = dt;
            dgvAllPeople.DataSource = bs;

            foreach (DataColumn col in dt.Columns)
                cbColumns.Items.Add(col.ColumnName);

            bs.ListChanged += (s, e) => lblNumberOfRecords.Text = bs.Count.ToString();
            lblNumberOfRecords.Text = bs.Count.ToString();

            cbColumns.SelectedIndex = 0;
        }

        private bool _isClearing = false;

        private void mtxtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();

        private void cbColumns_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private bool IsNone => cbColumns.SelectedIndex <= 0;

        private bool IsIntegerColumn(string col)
        {
            var t = CurrentPeopleTable.Columns[col].DataType;
            return t == typeof(int) || t == typeof(long) || t == typeof(short) || t == typeof(byte);
        }

        private bool IsDecimalColumn(string col)
        {
            var t = CurrentPeopleTable.Columns[col].DataType;
            return t == typeof(decimal) || t == typeof(double) || t == typeof(float);
        }

        private bool IsNumericColumn(string col) => IsIntegerColumn(col) || IsDecimalColumn(col);

        private static bool IsAsciiDigit(char c) => c >= '0' && c <= '9';

        private void ClearSearchWithError(string message)
        {
            _isClearing = true;
            mtxtSearch.Clear();             // TextChanged fires here but is ignored
            _isClearing = false;

            mtxtSearch.SetErrorState(true); // set the error AFTER clearing so it stays visible
            mtxtSearch.ErrorMessage = message;
        }

        private void ApplyFilter()
        {
            if (_isClearing) return;

            mtxtSearch.SetErrorState(false);
            mtxtSearch.ErrorMessage = string.Empty;

            if (IsNone)
            {
                if (mtxtSearch.Text.Length > 0)
                    ClearSearchWithError("Choose column first");
                bs.RemoveFilter();
                return;
            }

            string col = cbColumns.SelectedItem.ToString();
            string text = mtxtSearch.Text.Trim();

            if (IsNumericColumn(col) && text.Length > 0)
            {
                bool valid = IsDecimalColumn(col)
                    ? System.Text.RegularExpressions.Regex.IsMatch(text, @"^[0-9]*\.?[0-9]*$")
                    : text.All(IsAsciiDigit);

                if (!valid)
                {
                    ClearSearchWithError("Column only accepts numbers");
                    bs.RemoveFilter();
                    return;
                }
            }

            if (text.Length == 0)
                bs.RemoveFilter();
            else
                bs.Filter = $"CONVERT([{col}], 'System.String') LIKE '%{text.Replace("'", "''")}%'";
        }

        private void _AddNewPerson()
        {
            Form frm = new frmAddUpdatePerson();
            frm.FormClosed += frmAddEditPersonInfo_FormClosed;
            frm.ShowDialog();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void frmAddEditPersonInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _RefreshPeopleList();
        }

        private void _DeletePerson()
        {
            int PersonID = Convert.ToInt32(dgvAllPeople.CurrentRow.Cells["PersonID"].Value);

            if (MessageBox.Show($"Are you sure you want delete this person with ID {PersonID} ?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsPerson person = clsPerson.Find(PersonID);

                if (clsPerson.DeletePerson(PersonID))
                {
                    string folder = @"C:\PeopleImages";

                    if (!string.IsNullOrEmpty(person.ImagePath))
                    {
                        File.Delete(Path.Combine(folder, person.ImagePath));
                    }
                }
                
                _RefreshPeopleList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }

        private void _ShowPersonDetailsForm()
        {
            int PersonID = Convert.ToInt32(dgvAllPeople.CurrentRow.Cells["PersonID"].Value);
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            _ShowPersonDetailsForm();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            _ShowPersonDetailsForm();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _ShowEditForm()
        {
            int PersonID = Convert.ToInt32(dgvAllPeople.CurrentRow.Cells["PersonID"].Value);
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.FormClosed += frmAddEditPersonInfo_FormClosed;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _ShowEditForm();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            _ShowEditForm();
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == DriversTab && DriversTab.Controls.Count == 0)
            {
                MaterialForm frm = new frmListPeople();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                DriversTab.Controls.Add(frm);
                frm.Show();
            }
        }

        // ------------------------ [ People Tab ] ------------------------ //

    }
}