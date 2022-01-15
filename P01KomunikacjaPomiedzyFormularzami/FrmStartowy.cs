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
    public partial class FrmStartowy : Form
    {
        FrmSzczegoly fs;

        public Label LblKomunikat
        {  get { return lblKomuniakt; } }

        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnOtworzSzczegoly_Click(object sender, EventArgs e)
        {
            fs = new FrmSzczegoly(this);
            fs.Show();

        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            fs.LblKomuniakt.Text = txtKomunikat.Text;
        }
    }
}
