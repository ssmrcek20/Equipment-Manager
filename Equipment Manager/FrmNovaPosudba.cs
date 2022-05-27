using Equipment_Manager.Models;
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
        private readonly FrmPosudbe frmPosudbe;
        public FrmNovaPosudba(FrmPosudbe frm)
        {
            InitializeComponent();
            frmPosudbe = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cipZaposlenik = cboCipZaposlenik.SelectedItem as CipZaposlenik;
            var foiZaposlenik = cboFoiZaposlenik.SelectedItem as FoiZaposlenik;
            var oprema = cboOprema.SelectedItem as Oprema;
            List<Posudba> posudbe = PosudbaRepository.GetPosudbe();
            int idPosudba = posudbe.Count;
            string datumPosudbe = dtpDatumPosudbe.Value.ToString();
            string razlogPosudbe = txtRazlogPosudbe.Text.ToString();
            string datumVracanja = dtpDatumVracanja.Value.ToString();
            PosudbaRepository.InsertPosudba(foiZaposlenik,cipZaposlenik,oprema,idPosudba,datumPosudbe,razlogPosudbe,datumVracanja);
            this.Close();
            frmPosudbe.Osvjezi();
        }

        private void FrmNovaPosudba_Load(object sender, EventArgs e)
        {
            dtpDatumPosudbe.Format = DateTimePickerFormat.Custom;
            dtpDatumPosudbe.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dtpDatumVracanja.Format = DateTimePickerFormat.Custom;
            dtpDatumVracanja.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            var CipZaposlenik = CipZaposlenikRepository.GetCip();
            cboCipZaposlenik.DataSource = CipZaposlenik;
            cboCipZaposlenik.ValueMember = "ID";
            cboCipZaposlenik.DisplayMember = "KorisnickoIme";

            var FoiZaposlenik = FoiZaposlenikRepository.GetFoi();
            cboFoiZaposlenik.DataSource = FoiZaposlenik;
            cboFoiZaposlenik.ValueMember = "ID";
            cboFoiZaposlenik.DisplayMember = "KorisnickoIme";

            var Oprema = OpremaRepository.GetOprema();
            cboOprema.DataSource = Oprema;
            cboOprema.ValueMember = "ID";
            cboOprema.DisplayMember = "NazivOpreme";
        }
    }
}
