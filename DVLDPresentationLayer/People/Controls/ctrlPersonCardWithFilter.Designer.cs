namespace DVLD.People.Controls
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtSearch = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cbFilterBy = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnFind = new ReaLTaiizor.Controls.MaterialButton();
            this.btnAddNewPerson = new ReaLTaiizor.Controls.MaterialButton();
            this.ctrlPersonCard1 = new DVLD.Controls.ctrlPersonCard();
            this.thunderGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // thunderGroupBox1
            // 
            this.thunderGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.thunderGroupBox1.BodyColorA = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.thunderGroupBox1.BodyColorB = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.thunderGroupBox1.BodyColorC = System.Drawing.Color.White;
            this.thunderGroupBox1.BodyColorD = System.Drawing.Color.White;
            this.thunderGroupBox1.Controls.Add(this.btnAddNewPerson);
            this.thunderGroupBox1.Controls.Add(this.btnFind);
            this.thunderGroupBox1.Controls.Add(this.mtxtSearch);
            this.thunderGroupBox1.Controls.Add(this.cbFilterBy);
            this.thunderGroupBox1.Controls.Add(this.label1);
            this.thunderGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.thunderGroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.thunderGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.thunderGroupBox1.Name = "thunderGroupBox1";
            this.thunderGroupBox1.Size = new System.Drawing.Size(848, 104);
            this.thunderGroupBox1.TabIndex = 3;
            this.thunderGroupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // mtxtSearch
            // 
            this.mtxtSearch.AllowPromptAsInput = true;
            this.mtxtSearch.AnimateReadOnly = false;
            this.mtxtSearch.AsciiOnly = false;
            this.mtxtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtSearch.BeepOnError = false;
            this.mtxtSearch.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSearch.Depth = 0;
            this.mtxtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSearch.HidePromptOnLeave = false;
            this.mtxtSearch.HideSelection = true;
            this.mtxtSearch.Hint = "Type to search";
            this.mtxtSearch.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtSearch.LeadingIcon = null;
            this.mtxtSearch.Location = new System.Drawing.Point(304, 44);
            this.mtxtSearch.Mask = "";
            this.mtxtSearch.MaxLength = 32767;
            this.mtxtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.PrefixSuffixText = null;
            this.mtxtSearch.PromptChar = '_';
            this.mtxtSearch.ReadOnly = false;
            this.mtxtSearch.RejectInputOnFirstFailure = false;
            this.mtxtSearch.ResetOnPrompt = true;
            this.mtxtSearch.ResetOnSpace = true;
            this.mtxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.ShortcutsEnabled = true;
            this.mtxtSearch.ShowAssistiveText = true;
            this.mtxtSearch.Size = new System.Drawing.Size(202, 52);
            this.mtxtSearch.SkipLiterals = true;
            this.mtxtSearch.TabIndex = 9;
            this.mtxtSearch.TabStop = false;
            this.mtxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtSearch.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSearch.TrailingIcon = null;
            this.mtxtSearch.UseSystemPasswordChar = false;
            this.mtxtSearch.UseTallSize = false;
            this.mtxtSearch.ValidatingType = null;
            this.mtxtSearch.Visible = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.AutoResize = false;
            this.cbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Depth = 0;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilterBy.DropDownHeight = 118;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.DropDownWidth = 121;
            this.cbFilterBy.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.IntegralHeight = false;
            this.cbFilterBy.ItemHeight = 29;
            this.cbFilterBy.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(88, 44);
            this.cbFilterBy.MaxDropDownItems = 4;
            this.cbFilterBy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 35);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 10;
            this.cbFilterBy.UseTallSize = false;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.AutoSize = false;
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFind.Depth = 0;
            this.btnFind.HighEmphasis = true;
            this.btnFind.Icon = global::DVLD.Properties.Resources.find;
            this.btnFind.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnFind.Location = new System.Drawing.Point(520, 44);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFind.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnFind.Name = "btnFind";
            this.btnFind.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFind.Size = new System.Drawing.Size(96, 36);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFind.UseAccentColor = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.AutoSize = false;
            this.btnAddNewPerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPerson.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddNewPerson.Depth = 0;
            this.btnAddNewPerson.HighEmphasis = true;
            this.btnAddNewPerson.Icon = global::DVLD.Properties.Resources.user_add;
            this.btnAddNewPerson.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAddNewPerson.Location = new System.Drawing.Point(632, 45);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewPerson.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNewPerson.Size = new System.Drawing.Size(180, 36);
            this.btnAddNewPerson.TabIndex = 14;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewPerson.UseAccentColor = false;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 120);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(847, 252);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thunderGroupBox1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(847, 373);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.thunderGroupBox1.ResumeLayout(false);
            this.thunderGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DVLD.Controls.ctrlPersonCard ctrlPersonCard1;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtxtSearch;
        private ReaLTaiizor.Controls.MaterialComboBox cbFilterBy;
        private ReaLTaiizor.Controls.MaterialButton btnFind;
        private ReaLTaiizor.Controls.MaterialButton btnAddNewPerson;
    }
}
