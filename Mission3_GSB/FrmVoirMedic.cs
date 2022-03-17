using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3_GSB
{
    public partial class FrmVoirMedic : Form
    {
        private gsbrapports2021Entities mesDonneesEF;
        public FrmVoirMedic(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonnees;
            this.bdgSourceVMedic.DataSource = this.mesDonneesEF.medicament.ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUpdate update = new FrmUpdate(this.mesDonneesEF);
            update.Show();
            this.Close();
        }
    }
}
