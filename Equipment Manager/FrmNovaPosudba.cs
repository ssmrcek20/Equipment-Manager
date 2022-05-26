using Equipment_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Manager
{
    public partial class FrmNovaPosudba : Form
    {
        public FrmNovaPosudba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNovaPosudba_Load(object sender, EventArgs e)
        {
            var CipZaposlenik = CipZaposlenikRepository.GetCip();
            cboCipZaposlenik.DataSource = CipZaposlenik;
            cboCipZaposlenik.ValueMember = "ID";
            cboCipZaposlenik.DisplayMember = "KorisnickoIme";

            var FoiZaposlenik = FoiZaposlenikRepository.GetFoi();
            cboFoiZaposlenik.DataSource = FoiZaposlenik;
            cboFoiZaposlenik.ValueMember = "ID";
            cboFoiZaposlenik.DisplayMember = "KorisnickoIme";
        }
    }
}
