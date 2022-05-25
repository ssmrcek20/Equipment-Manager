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
    public partial class FrmPosudbe : Form
    {
        public FrmPosudbe()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPosudba();
        }

        private void ShowPosudba()
        {
            List<Posudba> posudbe = PosudbaRepository.GetPosudbe();
            dgvPosudbe.DataSource = posudbe;
        }

        private void btnNovaPosudba_Click(object sender, EventArgs e)
        {
            FrmNovaPosudba frmNovaPosudba = new FrmNovaPosudba();
            frmNovaPosudba.ShowDialog();
        }
    }
}
