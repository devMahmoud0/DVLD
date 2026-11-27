namespace DVLD.People
{
    partial class frmShowPersonInfo
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
            this.btnClose = new ReaLTaiizor.Controls.MaterialButton();
            this.ctrlPersonCard1 = new DVLD.Controls.ctrlPersonCard();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(776, 320);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(104, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(32, 48);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(848, 256);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCard1);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonDetails";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Details";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);

        }

        #endregion

        private DVLD.Controls.ctrlPersonCard ctrlPersonCard1;
        private ReaLTaiizor.Controls.MaterialButton btnClose;
    }
}