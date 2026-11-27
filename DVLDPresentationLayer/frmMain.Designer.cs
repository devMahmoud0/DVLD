namespace DVLD
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.materialDrawer1 = new ReaLTaiizor.Controls.MaterialDrawer();
            this.tcMain = new ReaLTaiizor.Controls.MaterialTabControl();
            this.ApplicationsTab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiDrivingLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tEs55ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsd55ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.test5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.DriversTab = new System.Windows.Forms.TabPage();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.AccountSettingsTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852 = new System.Windows.Forms.TableLayoutPanel();
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6 = new System.Windows.Forms.TableLayoutPanel();
            this.pbCurrentUser = new System.Windows.Forms.PictureBox();
            this.tcMain.SuspendLayout();
            this.ApplicationsTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDrawer1.AutoHide = true;
            this.materialDrawer1.AutoShow = true;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = this.tcMain;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.DrawerHideTabName = new string[0];
            this.materialDrawer1.DrawerNonClickTabPage = new System.Windows.Forms.TabPage[0];
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 4;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 0);
            this.materialDrawer1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.ShowTabControl = this.tcMain;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 798);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = true;
            this.materialDrawer1.UsePreProcessIcons = false;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.ApplicationsTab);
            this.tcMain.Controls.Add(this.PeopleTab);
            this.tcMain.Controls.Add(this.DriversTab);
            this.tcMain.Controls.Add(this.UsersTab);
            this.tcMain.Controls.Add(this.AccountSettingsTab);
            this.tcMain.Depth = 0;
            this.tcMain.ImageList = this.imageList1;
            this.tcMain.Location = new System.Drawing.Point(64, 0);
            this.tcMain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1443, 798);
            this.tcMain.TabIndex = 1;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // ApplicationsTab
            // 
            this.ApplicationsTab.BackColor = System.Drawing.SystemColors.Control;
            this.ApplicationsTab.Controls.Add(this.menuStrip1);
            this.ApplicationsTab.ImageKey = "document.png";
            this.ApplicationsTab.Location = new System.Drawing.Point(4, 31);
            this.ApplicationsTab.Name = "ApplicationsTab";
            this.ApplicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationsTab.Size = new System.Drawing.Size(1435, 763);
            this.ApplicationsTab.TabIndex = 0;
            this.ApplicationsTab.Text = "Applications";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDrivingLicenseServices,
            this.tsmiManageApplications,
            this.tsmiDetainLicenses,
            this.tsmiManageApplicationTypes,
            this.tsmiManageTestTypes});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiDrivingLicenseServices
            // 
            this.tsmiDrivingLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEs55ToolStripMenuItem,
            this.renewDrivingLicenceToolStripMenuItem,
            this.toolStripSeparator1,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem,
            this.toolStripSeparator2,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.tsmiDrivingLicenseServices.Name = "tsmiDrivingLicenseServices";
            this.tsmiDrivingLicenseServices.Size = new System.Drawing.Size(144, 20);
            this.tsmiDrivingLicenseServices.Text = "Driving License Services";
            // 
            // tEs55ToolStripMenuItem
            // 
            this.tEs55ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsd55ToolStripMenuItem,
            this.teestToolStripMenuItem});
            this.tEs55ToolStripMenuItem.Name = "tEs55ToolStripMenuItem";
            this.tEs55ToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.tEs55ToolStripMenuItem.Text = "New Driving Licence";
            // 
            // tsd55ToolStripMenuItem
            // 
            this.tsd55ToolStripMenuItem.Name = "tsd55ToolStripMenuItem";
            this.tsd55ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tsd55ToolStripMenuItem.Text = "Local License";
            // 
            // teestToolStripMenuItem
            // 
            this.teestToolStripMenuItem.Name = "teestToolStripMenuItem";
            this.teestToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.teestToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenceToolStripMenuItem
            // 
            this.renewDrivingLicenceToolStripMenuItem.Name = "renewDrivingLicenceToolStripMenuItem";
            this.renewDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.renewDrivingLicenceToolStripMenuItem.Text = "Renew Driving Licence";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(293, 6);
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // tsmiManageApplications
            // 
            this.tsmiManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationsToolStripMenuItem});
            this.tsmiManageApplications.Name = "tsmiManageApplications";
            this.tsmiManageApplications.Size = new System.Drawing.Size(131, 20);
            this.tsmiManageApplications.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            this.internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            this.internationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            // 
            // tsmiDetainLicenses
            // 
            this.tsmiDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test5ToolStripMenuItem,
            this.test5ToolStripMenuItem1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.tsmiDetainLicenses.Name = "tsmiDetainLicenses";
            this.tsmiDetainLicenses.Size = new System.Drawing.Size(100, 20);
            this.tsmiDetainLicenses.Text = "Detain Licenses";
            // 
            // test5ToolStripMenuItem
            // 
            this.test5ToolStripMenuItem.Name = "test5ToolStripMenuItem";
            this.test5ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.test5ToolStripMenuItem.Text = "Manage Detained Licenses";
            // 
            // test5ToolStripMenuItem1
            // 
            this.test5ToolStripMenuItem1.Name = "test5ToolStripMenuItem1";
            this.test5ToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.test5ToolStripMenuItem1.Text = "Detain License";
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            // 
            // tsmiManageApplicationTypes
            // 
            this.tsmiManageApplicationTypes.Name = "tsmiManageApplicationTypes";
            this.tsmiManageApplicationTypes.Size = new System.Drawing.Size(158, 20);
            this.tsmiManageApplicationTypes.Text = "Manage Application Types";
            // 
            // tsmiManageTestTypes
            // 
            this.tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            this.tsmiManageTestTypes.Size = new System.Drawing.Size(117, 20);
            this.tsmiManageTestTypes.Text = "Manage Test Types";
            // 
            // PeopleTab
            // 
            this.PeopleTab.BackColor = System.Drawing.SystemColors.Control;
            this.PeopleTab.ImageKey = "person_man (1).png";
            this.PeopleTab.Location = new System.Drawing.Point(4, 31);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.PeopleTab.Size = new System.Drawing.Size(1435, 763);
            this.PeopleTab.TabIndex = 1;
            this.PeopleTab.Text = "People";
            // 
            // DriversTab
            // 
            this.DriversTab.BackColor = System.Drawing.SystemColors.Control;
            this.DriversTab.ImageKey = "driver.png";
            this.DriversTab.Location = new System.Drawing.Point(4, 31);
            this.DriversTab.Name = "DriversTab";
            this.DriversTab.Size = new System.Drawing.Size(1435, 763);
            this.DriversTab.TabIndex = 2;
            this.DriversTab.Text = "Drivers";
            // 
            // UsersTab
            // 
            this.UsersTab.BackColor = System.Drawing.SystemColors.Control;
            this.UsersTab.ImageKey = "user (4).png";
            this.UsersTab.Location = new System.Drawing.Point(4, 31);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Size = new System.Drawing.Size(1435, 763);
            this.UsersTab.TabIndex = 3;
            this.UsersTab.Text = "Users";
            // 
            // AccountSettingsTab
            // 
            this.AccountSettingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.AccountSettingsTab.ImageKey = "settings.png";
            this.AccountSettingsTab.Location = new System.Drawing.Point(4, 31);
            this.AccountSettingsTab.Name = "AccountSettingsTab";
            this.AccountSettingsTab.Size = new System.Drawing.Size(1435, 763);
            this.AccountSettingsTab.TabIndex = 4;
            this.AccountSettingsTab.Text = "Account Settings";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document.png");
            this.imageList1.Images.SetKeyName(1, "Logo (1).png");
            this.imageList1.Images.SetKeyName(2, "person_man.png");
            this.imageList1.Images.SetKeyName(3, "person_man (1).png");
            this.imageList1.Images.SetKeyName(4, "settings.png");
            this.imageList1.Images.SetKeyName(5, "driver.png");
            this.imageList1.Images.SetKeyName(6, "user (3).png");
            this.imageList1.Images.SetKeyName(7, "user (4).png");
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
            this.metroControlBox1.Location = new System.Drawing.Point(1403, 5);
            this.metroControlBox1.MaximizeBox = true;
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
            this.metroControlBox1.TabIndex = 2;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            // 
            // object_9c903ea1_ff20_477d_91c1_aed3109bc852
            // 
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.ColumnCount = 3;
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.67742F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.32258F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1034F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.Location = new System.Drawing.Point(0, 200);
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.Name = "object_9c903ea1_ff20_477d_91c1_aed3109bc852";
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowCount = 1;
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.Size = new System.Drawing.Size(1345, 38);
            this.object_9c903ea1_ff20_477d_91c1_aed3109bc852.TabIndex = 6;
            // 
            // object_677e585d_e430_4a33_8b39_3bf3dd50f4a6
            // 
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.ColumnCount = 3;
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.67742F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.32258F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1034F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.Location = new System.Drawing.Point(0, 200);
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.Name = "object_677e585d_e430_4a33_8b39_3bf3dd50f4a6";
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowCount = 1;
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.Size = new System.Drawing.Size(1345, 38);
            this.object_677e585d_e430_4a33_8b39_3bf3dd50f4a6.TabIndex = 6;
            // 
            // pbCurrentUser
            // 
            this.pbCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.pbCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCurrentUser.Image = global::DVLD.Properties.Resources.user__5_;
            this.pbCurrentUser.Location = new System.Drawing.Point(1363, 7);
            this.pbCurrentUser.Name = "pbCurrentUser";
            this.pbCurrentUser.Size = new System.Drawing.Size(24, 24);
            this.pbCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentUser.TabIndex = 3;
            this.pbCurrentUser.TabStop = false;
            this.pbCurrentUser.Click += new System.EventHandler(this.pbCurrentUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 797);
            this.ControlBox = false;
            this.Controls.Add(this.pbCurrentUser);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.metroControlBox1);
            this.Controls.Add(this.tcMain);
            this.DrawerIsOpen = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driving Vehicle License Department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tcMain.ResumeLayout(false);
            this.ApplicationsTab.ResumeLayout(false);
            this.ApplicationsTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.ImageList imageList1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private System.Windows.Forms.PictureBox pbCurrentUser;
        private ReaLTaiizor.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage ApplicationsTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem tEs55ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsd55ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplications;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem test5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTestTypes;
        private System.Windows.Forms.TabPage PeopleTab;
        private System.Windows.Forms.TabPage DriversTab;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.TabPage AccountSettingsTab;
        private System.Windows.Forms.TableLayoutPanel object_9c903ea1_ff20_477d_91c1_aed3109bc852;
        private System.Windows.Forms.TableLayoutPanel object_677e585d_e430_4a33_8b39_3bf3dd50f4a6;
    }
}