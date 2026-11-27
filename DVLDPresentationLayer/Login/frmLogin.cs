using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                Color.FromArgb(63, 81, 181),
                Color.FromArgb(48, 63, 159),
                Color.FromArgb(197, 202, 233),
                Color.FromArgb(63, 81, 181),
                Color.White
            );
        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {
            ////errorProvider1.SetError(materialTextBoxEdit1, "Name is required!");
            //materialTextBoxEdit1.ErrorMessage = "This the Error!!";
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

            //materialMaskedTextBox1.SetErrorState(true);
            //materialMaskedTextBox1.ErrorMessage = "This the Error!!";
            ////materialMaskedTextBox1.GetErrorState();



        }

        private void materialMaskedTextBox1_Leave(object sender, EventArgs e)
        {

            //if (materialMaskedTextBox1.Text != "Admin")
            //{
            //    materialMaskedTextBox1.ShowAssistiveText = true;
            //    materialMaskedTextBox1.SetErrorState(true);
            //    materialMaskedTextBox1.ErrorMessage = "This the Error!!";
            //}
            //else
            //{
            //    materialMaskedTextBox1.ShowAssistiveText = false;
            //    materialMaskedTextBox1.SetErrorState(false);
            //    materialMaskedTextBox1.ErrorMessage = "";


            //}

        }

        private void materialMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (materialMaskedTextBox1.Text != "Admin")
            //{
            //    materialMaskedTextBox1.ShowAssistiveText = true;
            //    materialMaskedTextBox1.SetErrorState(true);
            //    materialMaskedTextBox1.ErrorMessage = "This the Error!!";
            //}
            //else
            //{
            //    materialMaskedTextBox1.ShowAssistiveText = false;
            //    materialMaskedTextBox1.SetErrorState(false);
            //    materialMaskedTextBox1.ErrorMessage = "";


            //}
        }

        private void materialMaskedTextBox1_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '\0')
            {
                txtPassword.TrailingIcon = DVLD.Properties.Resources.view;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.TrailingIcon = DVLD.Properties.Resources.hide;
                txtPassword.PasswordChar = '●';
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
