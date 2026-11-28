namespace DVLD.People
{
    partial class frmAddUpdatePerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new ReaLTaiizor.Controls.BigLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label963 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label666 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtSecondName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtThirdName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtLastName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtNationalNo = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.rbMale = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.rbFemale = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.dtDateOfBirth = new ReaLTaiizor.Controls.PoisonDateTime();
            this.cbCountry = new ReaLTaiizor.Controls.MaterialComboBox();
            this.llblSetImage = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.pbPersonPicture = new System.Windows.Forms.PictureBox();
            this.btnSave = new ReaLTaiizor.Controls.MaterialButton();
            this.btnClose = new ReaLTaiizor.Controls.MaterialButton();
            this.txtPhone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(238, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(614, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(480, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Country:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(480, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Phone:";
            // 
            // label963
            // 
            this.label963.AutoSize = true;
            this.label963.BackColor = System.Drawing.SystemColors.Control;
            this.label963.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label963.ForeColor = System.Drawing.Color.Black;
            this.label963.Location = new System.Drawing.Point(480, 200);
            this.label963.Name = "label963";
            this.label963.Size = new System.Drawing.Size(131, 25);
            this.label963.TabIndex = 30;
            this.label963.Text = "Date Of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Address:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.SystemColors.Control;
            this.label55.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(24, 312);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(64, 25);
            this.label55.TabIndex = 26;
            this.label55.Text = "Email:";
            // 
            // label666
            // 
            this.label666.AutoSize = true;
            this.label666.BackColor = System.Drawing.SystemColors.Control;
            this.label666.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label666.ForeColor = System.Drawing.Color.Black;
            this.label666.Location = new System.Drawing.Point(24, 256);
            this.label666.Name = "label666";
            this.label666.Size = new System.Drawing.Size(80, 25);
            this.label666.TabIndex = 24;
            this.label666.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "National No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.BackColor = System.Drawing.SystemColors.Control;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.lblPersonID.Location = new System.Drawing.Point(136, 96);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(45, 25);
            this.lblPersonID.TabIndex = 19;
            this.lblPersonID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Person ID:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AllowPromptAsInput = true;
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.AsciiOnly = false;
            this.txtFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFirstName.BeepOnError = false;
            this.txtFirstName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.HidePromptOnLeave = false;
            this.txtFirstName.HideSelection = true;
            this.txtFirstName.Hint = "First";
            this.txtFirstName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(192, 136);
            this.txtFirstName.Mask = "";
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PrefixSuffixText = null;
            this.txtFirstName.PromptChar = '_';
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.RejectInputOnFirstFailure = false;
            this.txtFirstName.ResetOnPrompt = true;
            this.txtFirstName.ResetOnSpace = true;
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(208, 36);
            this.txtFirstName.SkipLiterals = true;
            this.txtFirstName.TabIndex = 36;
            this.txtFirstName.TabStop = false;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFirstName.TrailingIcon = null;
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.UseTallSize = false;
            this.txtFirstName.ValidatingType = null;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ClearErrorMessage_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.AllowPromptAsInput = true;
            this.txtSecondName.AnimateReadOnly = false;
            this.txtSecondName.AsciiOnly = false;
            this.txtSecondName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSecondName.BeepOnError = false;
            this.txtSecondName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSecondName.Depth = 0;
            this.txtSecondName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecondName.HidePromptOnLeave = false;
            this.txtSecondName.HideSelection = true;
            this.txtSecondName.Hint = "Second";
            this.txtSecondName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSecondName.LeadingIcon = null;
            this.txtSecondName.Location = new System.Drawing.Point(416, 136);
            this.txtSecondName.Mask = "";
            this.txtSecondName.MaxLength = 32767;
            this.txtSecondName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.PasswordChar = '\0';
            this.txtSecondName.PrefixSuffixText = null;
            this.txtSecondName.PromptChar = '_';
            this.txtSecondName.ReadOnly = false;
            this.txtSecondName.RejectInputOnFirstFailure = false;
            this.txtSecondName.ResetOnPrompt = true;
            this.txtSecondName.ResetOnSpace = true;
            this.txtSecondName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSecondName.SelectedText = "";
            this.txtSecondName.SelectionLength = 0;
            this.txtSecondName.SelectionStart = 0;
            this.txtSecondName.ShortcutsEnabled = true;
            this.txtSecondName.Size = new System.Drawing.Size(208, 36);
            this.txtSecondName.SkipLiterals = true;
            this.txtSecondName.TabIndex = 37;
            this.txtSecondName.TabStop = false;
            this.txtSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSecondName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSecondName.TrailingIcon = null;
            this.txtSecondName.UseSystemPasswordChar = false;
            this.txtSecondName.UseTallSize = false;
            this.txtSecondName.ValidatingType = null;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ClearErrorMessage_Validating);
            // 
            // txtThirdName
            // 
            this.txtThirdName.AllowPromptAsInput = true;
            this.txtThirdName.AnimateReadOnly = false;
            this.txtThirdName.AsciiOnly = false;
            this.txtThirdName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtThirdName.BeepOnError = false;
            this.txtThirdName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtThirdName.Depth = 0;
            this.txtThirdName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtThirdName.HidePromptOnLeave = false;
            this.txtThirdName.HideSelection = true;
            this.txtThirdName.Hint = "Third";
            this.txtThirdName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtThirdName.LeadingIcon = null;
            this.txtThirdName.Location = new System.Drawing.Point(640, 136);
            this.txtThirdName.Mask = "";
            this.txtThirdName.MaxLength = 32767;
            this.txtThirdName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.PasswordChar = '\0';
            this.txtThirdName.PrefixSuffixText = null;
            this.txtThirdName.PromptChar = '_';
            this.txtThirdName.ReadOnly = false;
            this.txtThirdName.RejectInputOnFirstFailure = false;
            this.txtThirdName.ResetOnPrompt = true;
            this.txtThirdName.ResetOnSpace = true;
            this.txtThirdName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThirdName.SelectedText = "";
            this.txtThirdName.SelectionLength = 0;
            this.txtThirdName.SelectionStart = 0;
            this.txtThirdName.ShortcutsEnabled = true;
            this.txtThirdName.Size = new System.Drawing.Size(208, 36);
            this.txtThirdName.SkipLiterals = true;
            this.txtThirdName.TabIndex = 38;
            this.txtThirdName.TabStop = false;
            this.txtThirdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtThirdName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtThirdName.TrailingIcon = null;
            this.txtThirdName.UseSystemPasswordChar = false;
            this.txtThirdName.UseTallSize = false;
            this.txtThirdName.ValidatingType = null;
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.ClearErrorMessage_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.AllowPromptAsInput = true;
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.AsciiOnly = false;
            this.txtLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLastName.BeepOnError = false;
            this.txtLastName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.HidePromptOnLeave = false;
            this.txtLastName.HideSelection = true;
            this.txtLastName.Hint = "Last";
            this.txtLastName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(864, 136);
            this.txtLastName.Mask = "";
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PrefixSuffixText = null;
            this.txtLastName.PromptChar = '_';
            this.txtLastName.ReadOnly = false;
            this.txtLastName.RejectInputOnFirstFailure = false;
            this.txtLastName.ResetOnPrompt = true;
            this.txtLastName.ResetOnSpace = true;
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(208, 36);
            this.txtLastName.SkipLiterals = true;
            this.txtLastName.TabIndex = 39;
            this.txtLastName.TabStop = false;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLastName.TrailingIcon = null;
            this.txtLastName.UseSystemPasswordChar = false;
            this.txtLastName.UseTallSize = false;
            this.txtLastName.ValidatingType = null;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ClearErrorMessage_Validating);
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.AllowPromptAsInput = true;
            this.txtNationalNo.AnimateReadOnly = false;
            this.txtNationalNo.AsciiOnly = false;
            this.txtNationalNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNationalNo.BeepOnError = false;
            this.txtNationalNo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNationalNo.Depth = 0;
            this.txtNationalNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNationalNo.HidePromptOnLeave = false;
            this.txtNationalNo.HideSelection = true;
            this.txtNationalNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNationalNo.LeadingIcon = null;
            this.txtNationalNo.Location = new System.Drawing.Point(192, 192);
            this.txtNationalNo.Mask = "";
            this.txtNationalNo.MaxLength = 32767;
            this.txtNationalNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PasswordChar = '\0';
            this.txtNationalNo.PrefixSuffixText = null;
            this.txtNationalNo.PromptChar = '_';
            this.txtNationalNo.ReadOnly = false;
            this.txtNationalNo.RejectInputOnFirstFailure = false;
            this.txtNationalNo.ResetOnPrompt = true;
            this.txtNationalNo.ResetOnSpace = true;
            this.txtNationalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.SelectionLength = 0;
            this.txtNationalNo.SelectionStart = 0;
            this.txtNationalNo.ShortcutsEnabled = true;
            this.txtNationalNo.Size = new System.Drawing.Size(208, 36);
            this.txtNationalNo.SkipLiterals = true;
            this.txtNationalNo.TabIndex = 40;
            this.txtNationalNo.TabStop = false;
            this.txtNationalNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNationalNo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNationalNo.TrailingIcon = null;
            this.txtNationalNo.UseSystemPasswordChar = false;
            this.txtNationalNo.UseTallSize = false;
            this.txtNationalNo.ValidatingType = null;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Depth = 0;
            this.rbMale.Location = new System.Drawing.Point(184, 248);
            this.rbMale.Margin = new System.Windows.Forms.Padding(0);
            this.rbMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rbMale.Name = "rbMale";
            this.rbMale.Ripple = true;
            this.rbMale.Size = new System.Drawing.Size(70, 37);
            this.rbMale.TabIndex = 41;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseAccentColor = false;
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Depth = 0;
            this.rbFemale.Location = new System.Drawing.Point(272, 248);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Ripple = true;
            this.rbFemale.Size = new System.Drawing.Size(87, 37);
            this.rbFemale.TabIndex = 42;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseAccentColor = false;
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowPromptAsInput = true;
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AsciiOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.BeepOnError = false;
            this.txtEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HidePromptOnLeave = false;
            this.txtEmail.HideSelection = true;
            this.txtEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(192, 304);
            this.txtEmail.Mask = "";
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.PromptChar = '_';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RejectInputOnFirstFailure = false;
            this.txtEmail.ResetOnPrompt = true;
            this.txtEmail.ResetOnSpace = true;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(208, 36);
            this.txtEmail.SkipLiterals = true;
            this.txtEmail.TabIndex = 43;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.UseTallSize = false;
            this.txtEmail.ValidatingType = null;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.AllowPromptAsInput = true;
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.AsciiOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.BeepOnError = false;
            this.txtAddress.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.HidePromptOnLeave = false;
            this.txtAddress.HideSelection = true;
            this.txtAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(192, 360);
            this.txtAddress.Mask = "";
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrefixSuffixText = null;
            this.txtAddress.PromptChar = '_';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.RejectInputOnFirstFailure = false;
            this.txtAddress.ResetOnPrompt = true;
            this.txtAddress.ResetOnSpace = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(656, 36);
            this.txtAddress.SkipLiterals = true;
            this.txtAddress.TabIndex = 44;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.UseTallSize = false;
            this.txtAddress.ValidatingType = null;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ClearErrorMessage_Validating);
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfBirth.Location = new System.Drawing.Point(640, 197);
            this.dtDateOfBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(208, 29);
            this.dtDateOfBirth.TabIndex = 45;
            // 
            // cbCountry
            // 
            this.cbCountry.AutoResize = false;
            this.cbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCountry.Depth = 0;
            this.cbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCountry.DropDownHeight = 118;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.DropDownWidth = 121;
            this.cbCountry.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.IntegralHeight = false;
            this.cbCountry.ItemHeight = 29;
            this.cbCountry.Location = new System.Drawing.Point(640, 304);
            this.cbCountry.MaxDropDownItems = 4;
            this.cbCountry.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(208, 35);
            this.cbCountry.StartIndex = 0;
            this.cbCountry.TabIndex = 47;
            this.cbCountry.UseTallSize = false;
            // 
            // llblSetImage
            // 
            this.llblSetImage.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.BackColor = System.Drawing.Color.Transparent;
            this.llblSetImage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.llblSetImage.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.llblSetImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.llblSetImage.Location = new System.Drawing.Point(936, 408);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(76, 20);
            this.llblSetImage.TabIndex = 49;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // pbPersonPicture
            // 
            this.pbPersonPicture.Image = global::DVLD.Properties.Resources.DefaultPicture;
            this.pbPersonPicture.Location = new System.Drawing.Point(864, 192);
            this.pbPersonPicture.Name = "pbPersonPicture";
            this.pbPersonPicture.Size = new System.Drawing.Size(208, 208);
            this.pbPersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonPicture.TabIndex = 48;
            this.pbPersonPicture.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = global::DVLD.Properties.Resources.save;
            this.btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSave.Location = new System.Drawing.Point(624, 424);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(104, 36);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = global::DVLD.Properties.Resources.circle_xmark;
            this.btnClose.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnClose.Location = new System.Drawing.Point(744, 424);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(104, 36);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.HideSelection = true;
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(640, 248);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PrefixSuffixText = null;
            this.txtPhone.ReadOnly = false;
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(208, 36);
            this.txtPhone.TabIndex = 54;
            this.txtPhone.TabStop = false;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.UseSystemPasswordChar = false;
            this.txtPhone.UseTallSize = false;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 479);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llblSetImage);
            this.Controls.Add(this.pbPersonPicture);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label963);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdatePerson";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label963;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label666;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtFirstName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSecondName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtThirdName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtLastName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNationalNo;
        private ReaLTaiizor.Controls.MaterialRadioButton rbMale;
        private ReaLTaiizor.Controls.MaterialRadioButton rbFemale;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAddress;
        private ReaLTaiizor.Controls.PoisonDateTime dtDateOfBirth;
        private ReaLTaiizor.Controls.MaterialComboBox cbCountry;
        private System.Windows.Forms.PictureBox pbPersonPicture;
        private ReaLTaiizor.Controls.DungeonLinkLabel llblSetImage;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnClose;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}