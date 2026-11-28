namespace DVLD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.lblWelcome = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.txtPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtUserName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(809, 8);
            this.metroControlBox1.MaximizeBox = false;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 1;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            this.lblWelcome.Location = new System.Drawing.Point(568, 136);
            this.lblWelcome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(167, 29);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Caption;
            this.materialLabel1.Location = new System.Drawing.Point(568, 176);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(280, 14);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Don\'t have an account? Contact with administrator.";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialButton1.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(568, 424);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(288, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Login";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(560, 368);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.ReadOnly = false;
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(137, 37);
            this.materialCheckBox1.TabIndex = 3;
            this.materialCheckBox1.Text = "Remember me";
            this.materialCheckBox1.UseAccentColor = false;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(632, 489);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 14);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Forget password";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(728, 488);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 17);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Click here";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowPromptAsInput = true;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AsciiOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BeepOnError = false;
            this.txtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HidePromptOnLeave = false;
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Password";
            this.txtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(568, 312);
            this.txtPassword.Mask = "";
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.PromptChar = '_';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RejectInputOnFirstFailure = false;
            this.txtPassword.ResetOnPrompt = true;
            this.txtPassword.ResetOnSpace = true;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowAssistiveText = true;
            this.txtPassword.Size = new System.Drawing.Size(288, 52);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.TrailingIcon = global::DVLD.Properties.Resources.hide;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.UseTallSize = false;
            this.txtPassword.ValidatingType = null;
            this.txtPassword.TrailingIconClick += new System.EventHandler(this.materialMaskedTextBox1_TrailingIconClick);
            // 
            // txtUserName
            // 
            this.txtUserName.AllowPromptAsInput = true;
            this.txtUserName.AnimateReadOnly = false;
            this.txtUserName.AsciiOnly = false;
            this.txtUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUserName.BeepOnError = false;
            this.txtUserName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUserName.Depth = 0;
            this.txtUserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.HidePromptOnLeave = false;
            this.txtUserName.HideSelection = true;
            this.txtUserName.Hint = "Username";
            this.txtUserName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUserName.LeadingIcon = null;
            this.txtUserName.Location = new System.Drawing.Point(568, 248);
            this.txtUserName.Mask = "";
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PrefixSuffixText = null;
            this.txtUserName.PromptChar = '_';
            this.txtUserName.ReadOnly = false;
            this.txtUserName.RejectInputOnFirstFailure = false;
            this.txtUserName.ResetOnPrompt = true;
            this.txtUserName.ResetOnSpace = true;
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.ShowAssistiveText = true;
            this.txtUserName.Size = new System.Drawing.Size(288, 52);
            this.txtUserName.SkipLiterals = true;
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TabStop = false;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUserName.TrailingIcon = global::DVLD.Properties.Resources.user;
            this.txtUserName.UseSystemPasswordChar = false;
            this.txtUserName.UseTallSize = false;
            this.txtUserName.ValidatingType = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.panel1.BackgroundImage = global::DVLD.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 600);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(8, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "© 2026 DVLD. All rights reserved.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driving License Services, Simplified.\r\n\r\nA smarter way to manage driving licenses" +
    ", vehicle registrations, and licensing services — all in one place.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(141, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(919, 599);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.metroControlBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtUserName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPassword;
        private ReaLTaiizor.Controls.MaterialLabel lblWelcome;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

