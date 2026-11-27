using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : MaterialForm
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(NationalNo);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
