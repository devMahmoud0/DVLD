using DVLD.Global_Classes;
using DVLDBusinessLayer;
using ReaLTaiizor.Child.Material;
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
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : MaterialForm
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode {AddNew, Update};
        public enum enGender { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        private clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            dtDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtDateOfBirth.Value = dtDateOfBirth.MaxDate;
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Egypt");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MaterialMessageBox.Show($"No Person with ID = {_PersonID}", "Person Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,
                UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
                this.Close();
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "")
            {
                pbPersonPicture.ImageLocation = _Person.ImagePath;
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _HandlePersonImage()
        {

            if (_Person.ImagePath != pbPersonPicture.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later
                    }
                }

                if (pbPersonPicture.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonPicture.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonPicture.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MaterialMessageBox.Show("Error Copying Image File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
                        return false;
                    }
                }

            }
            return true;
        }

        private void ShowError(MaterialTextBoxEdit box, bool hasError, string message = "")
        {
            box.SetErrorState(hasError);
            box.ShowAssistiveText = hasError;
            box.ErrorMessage = hasError ? message : "";
        }

        private void ShowError(MaterialMaskedTextBox box, bool hasError, string message = "")
        {
            box.SetErrorState(hasError);
            box.ShowAssistiveText = hasError;
            box.ErrorMessage = hasError ? message : "";
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Choose your photo";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.webp|All Files|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonPicture.Load(selectedFilePath);
            }
        }

        private void ValidateEmptyTextBox()
        {

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                ShowError(txtFirstName, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
                ShowError(txtSecondName, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
                ShowError(txtThirdName, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                ShowError(txtLastName, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
                ShowError(txtNationalNo, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                ShowError(txtEmail, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                ShowError(txtAddress, true, "This field is required!");

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                ShowError(txtPhone, true, "This field is required!");

            /*
             
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBoxEdit Temp = ((TextBoxEdit)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                //errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                //errorProvider1.SetError(Temp, null);
            }
            */

        }

        private bool ValidateFields()
        {
            return (!txtFirstName.GetErrorState() && !txtSecondName.GetErrorState() && !txtThirdName.GetErrorState() && !txtLastName.GetErrorState()
                    && !txtNationalNo.GetErrorState() && !txtPhone.GetErrorState() && !txtEmail.GetErrorState() && !txtAddress.GetErrorState());
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "") { ShowError(txtEmail, false, ""); return; }

            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                ShowError(txtEmail, true, "Invalid Email Address Format!");
            }
            else
            {
                ShowError(txtEmail, false, "");
            }

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (txtNationalNo.Text.Trim() == "") { ShowError(txtNationalNo, false, ""); return; }

            /*if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                ShowError(txtNationalNo, true, "This field is required!");
                return;
            }
            else
            {
                ShowError(txtNationalNo, false, "");
            }*/

            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExists(txtNationalNo.Text.Trim()))
            {
                ShowError(txtNationalNo, true, "National Number is used!");
            }
            else
            {
                ShowError(txtNationalNo, false, "");
            }
        }

        private void ClearErrorMessage_Validating(object sender, CancelEventArgs e)
        {

            Control control = (Control)sender;

            if (control is ReaLTaiizor.Child.Material.MaterialBaseMaskedTextBox)
                control = control.Parent;

            if (control is MaterialMaskedTextBox masked)
            {
                if (masked.Text.Trim() == "" || masked.GetErrorState())
                    ShowError(masked, false, "");
            }
            else if (control is MaterialTextBoxEdit edit)
            {
                if (edit.Text.Trim() == "" || edit.GetErrorState())
                    ShowError(edit, false, "");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            bool validInput = string.IsNullOrWhiteSpace(txtPhone.Text) || clsValidation.ValidatePhone(txtPhone.Text);

            if (!validInput)
            {
                ShowError(txtPhone, true, "Invalid phone number!");
            }
            else
            {
                ShowError(txtPhone, false, "");
            }
        }

        private void UpdateData()
        {
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtDateOfBirth.Value;
            _Person.NationalityCountryID = NationalityCountryID;

            if (rbMale.Checked)
                _Person.Gender = (sbyte)enGender.Male;
            else
                _Person.Gender = (sbyte)enGender.Female;

            if (pbPersonPicture.ImageLocation != null)
                _Person.ImagePath = pbPersonPicture.ImageLocation;
            else
                _Person.ImagePath = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateEmptyTextBox();

            if (!ValidateFields())
            {
                //Here we dont continue becuase the form is not valid
                MaterialMessageBox.Show("Some fields are not valid!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
                return;

            }

            if (!_HandlePersonImage())
                return;

            UpdateData();

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";

                MaterialMessageBox.Show("Data Saved Successfully.", "Data Saved",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);

                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MaterialMessageBox.Show("Error: Data Is Not Saved Successfully.", "Save Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
