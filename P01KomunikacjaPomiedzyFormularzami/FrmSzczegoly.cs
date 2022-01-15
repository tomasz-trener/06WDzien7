using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01KomunikacjaPomiedzyFormularzami
{
    public partial class FrmSzczegoly : Form
    {
        public Label LblKomuniakt {  get { return lblKomuniakt; } }
        FrmStartowy fs;

        public FrmSzczegoly(FrmStartowy fs)
        {
            InitializeComponent();

            this.fs = fs;


        }

        private void btnWylisj_Click(object sender, EventArgs e)
        {
            fs.LblKomunikat.Text = txtKomuniakt.Text;
        }
    }
}
