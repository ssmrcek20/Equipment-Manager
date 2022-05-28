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
            int idPosudba = posudbe[posudbe.Count-1].ID+1;
            string datumPosudbe = dtpDatumPosudbe.Value.ToString();
            string razlogPosudbe = txtRazlogPosudbe.Text.ToString();
            string datumVracanja = dtpDatumVracanja.Value.ToString();
            if (FrmPosudbe.IDPosudbe == -1)
            {
                PosudbaRepository.InsertPosudba(foiZaposlenik, cipZaposlenik, oprema, idPosudba, datumPosudbe, razlogPosudbe, datumVracanja);
            }
            else
            {
                PosudbaRepository.UpdatePosudba(foiZaposlenik, cipZaposlenik, oprema, FrmPosudbe.IDPosudbe, datumPosudbe, razlogPosudbe, datumVracanja);
                FrmPosudbe.IDPosudbe = -1;
            }
            this.Close();
            frmPosudbe.Osvjezi();
        }

        private void FrmNovaPosudba_Load(object sender, EventArgs e)
        {
            dtpDatumPosudbe.Format = DateTimePickerFormat.Custom;
            dtpDatumPosudbe.CustomFormat = "yyyy-MM-dd HH:mm:ss tt";
            dtpDatumVracanja.Format = DateTimePickerFormat.Custom;
            dtpDatumVracanja.CustomFormat = "yyyy-MM-dd HH:mm:ss tt";
            dtpDatumPosudbe.Value = DateTime.Now;

            var CipZaposlenik = CipZaposlenikRepository.GetCip();
            cboCipZaposlenik.DataSource = CipZaposlenik;
            cboCipZaposlenik.ValueMember = "ID";
            cboCipZaposlenik.DisplayMember = "KorisnickoIme";
            cboCipZaposlenik.SelectedItem = null;

            var FoiZaposlenik = FoiZaposlenikRepository.GetFoi();
            cboFoiZaposlenik.DataSource = FoiZaposlenik;
            cboFoiZaposlenik.ValueMember = "ID";
            cboFoiZaposlenik.DisplayMember = "KorisnickoIme";
            cboFoiZaposlenik.SelectedItem = null;

            var Oprema = OpremaRepository.GetOprema();
            cboOprema.DataSource = Oprema;
            cboOprema.ValueMember = "ID";
            cboOprema.DisplayMember = "NazivOpreme";
            cboOprema.SelectedItem = null;

            if (FrmPosudbe.IDPosudbe != -1)
            {
                GetPodaci(FrmPosudbe.IDPosudbe);
            }
        }
        public void GetPodaci(int id)
        {
            Posudba posudba = PosudbaRepository.GetPosudba(id);
            CipZaposlenik cipZaposlenik = CipZaposlenikRepository.GetCips(posudba.IDCipZaposlenika);
            cboCipZaposlenik.SelectedIndex = cboCipZaposlenik.FindStringExact(cipZaposlenik.KorisnickoIme);
            FoiZaposlenik foiZaposlenik = FoiZaposlenikRepository.GetFois(posudba.IDFoiZaposlenika);
            cboFoiZaposlenik.SelectedIndex = cboFoiZaposlenik.FindStringExact(foiZaposlenik.KorisnickoIme);
            Oprema oprema = OpremaRepository.GetOpreme(posudba.IDOpreme);
            cboOprema.SelectedIndex = cboOprema.FindStringExact(oprema.NazivOpreme);
            dtpDatumPosudbe.Value= DateTime.Parse(posudba.DatumPosudbe);
            dtpDatumVracanja.Value= DateTime.Parse(posudba.DatumVracanja);
            txtRazlogPosudbe.Text =posudba.RazlogPosudbe;

        }
    }
}
