using DVLD.People;
using DVLD.Properties;
using DVLDBusinessLayer;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension;
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
using System.Xml.Linq;

namespace DVLD.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID = -1;
        
        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MaterialMessageBox.Show($"No Person with PersonID = {PersonID.ToString()}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MaterialMessageBox.Show($"No Person with PersonID = {PersonID.ToString()}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
                return;
            }

            _FillPersonInfo();
        }

        private void _LoadPersonImage()
        {

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonPicture.ImageLocation = ImagePath;
                else
                    MaterialMessageBox.Show($"Could not find this image: = {ImagePath}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
            else
                pbPersonPicture.Image = Resources.testPerson1;
        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FullName();
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblAddress.Text = _Person.Address;

            _LoadPersonImage();
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "N/A";
            lblNationalNo.Text = "N/A";
            lblFullName.Text = "N/A";
            lblGender.Text = "N/A";
            lblEmail.Text = "N/A";
            lblPhone.Text = "N/A";
            lblDateOfBirth.Text = "N/A";
            lblCountry.Text = "N/A";
            lblAddress.Text = "N/A";
            pbPersonPicture.Image = Resources.testPerson1;
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
