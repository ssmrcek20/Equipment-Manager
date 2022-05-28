using Equipment_Manager.Models;
using Equipment_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Manager
{
    public partial class FrmPosudbe : Form
    {
        public static int IDPosudbe = -1;
        public FrmPosudbe()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPosudba();
            dgvPosudbe.Columns["RazlogPosudbe"].Width = 200;
            dgvPosudbe.Columns["ID"].Width = 33;
        }

        private void ShowPosudba()
        {
            List<Posudba> posudbe = PosudbaRepository.GetPosudbe();
            dgvPosudbe.DataSource = posudbe;

            ShowCipZaposlenikKorisnickoIme();
            ShowFoiZaposlenikKorisnickoIme();
            ShowNazivOpreme();
        }
        private void ShowNazivOpreme()
        {
            Oprema oprema = new Oprema();
            if (dgvPosudbe.Columns.Contains("Oprema") == false)
            {
                dgvPosudbe.Columns.Add("Oprema", "Oprema");
            }
            for (int i = 0; i < dgvPosudbe.Rows.Count; i++)
            {
                int cipId = int.Parse(dgvPosudbe.Rows[i].Cells["IDOpreme"].Value.ToString());
                oprema = OpremaRepository.GetOpreme(cipId);
                dgvPosudbe.Rows[i].Cells["Oprema"].Value = oprema.GetNazivOpreme();
            }
            dgvPosudbe.Columns.Remove("IDOpreme");
        }

        private void ShowCipZaposlenikKorisnickoIme()
        {
            CipZaposlenik cipZaposlenik = new CipZaposlenik();
            if (dgvPosudbe.Columns.Contains("CipZaposlenik") == false)
            {
                dgvPosudbe.Columns.Add("CipZaposlenik", "CipZaposlenik");
            }
            dgvPosudbe.Columns["CipZaposlenik"].DisplayIndex = 1;
            for (int i = 0; i < dgvPosudbe.Rows.Count; i++)
            {
                int cipId = int.Parse(dgvPosudbe.Rows[i].Cells["IDCipZaposlenika"].Value.ToString());
                cipZaposlenik = CipZaposlenikRepository.GetCips(cipId);
                dgvPosudbe.Rows[i].Cells["CipZaposlenik"].Value = cipZaposlenik.GetUsername();
            }
            dgvPosudbe.Columns.Remove("IDCipZaposlenika");
        }
        private void ShowFoiZaposlenikKorisnickoIme()
        {
            FoiZaposlenik foiZaposlenik = new FoiZaposlenik();
            if (dgvPosudbe.Columns.Contains("FoiZaposlenik") == false)
            {
                dgvPosudbe.Columns.Add("FoiZaposlenik", "FoiZaposlenik");
            }
            dgvPosudbe.Columns["FoiZaposlenik"].DisplayIndex = 2;
            for (int i = 0; i < dgvPosudbe.Rows.Count; i++)
            {
                int foiId = int.Parse(dgvPosudbe.Rows[i].Cells["IDFoiZaposlenika"].Value.ToString());
                foiZaposlenik = FoiZaposlenikRepository.GetFois(foiId);
                dgvPosudbe.Rows[i].Cells["FoiZaposlenik"].Value = foiZaposlenik.GetUsername();
            }
            dgvPosudbe.Columns.Remove("IDFoiZaposlenika");
        }
        private void btnNovaPosudba_Click(object sender, EventArgs e)
        {
            FrmNovaPosudba frmNovaPosudba = new FrmNovaPosudba(this);
            frmNovaPosudba.ShowDialog();
        }
        public void Osvjezi()
        {
            ShowPosudba();
            dgvPosudbe.Columns["RazlogPosudbe"].Width = 200;
            dgvPosudbe.Columns["ID"].Width = 33;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnUrediPosudbu_Click(object sender, EventArgs e)
        {
            IDPosudbe=dgvPosudbe.CurrentCell.RowIndex;
            FrmNovaPosudba frmNovaPosudba = new FrmNovaPosudba(this);
            frmNovaPosudba.ShowDialog();
            //aa
        }
    }
}
