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
        
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == PeopleTab && PeopleTab.Controls.Count == 0)
            {
                MaterialForm frm = new frmListPeople();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                PeopleTab.Controls.Add(frm);
                frm.Show();
            }
        }

        // ------------------------ [ People Tab ] ------------------------ //

    }
}