using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3GSB
{
    public partial class FrmModifierRapport : Form
    {
        gsbrapports2021Entities gsbrapports;
        public FrmModifierRapport(gsbrapports2021Entities gsbrapports)
        {
            InitializeComponent();
            this.gsbrapports = new gsbrapports2021Entities();
            this.gsbrapports= gsbrapports;
            this.bdgRapport.DataSource = this.gsbrapports.rapport.ToList();
            this.bdgOffrir.DataSource = this.gsbrapports.offrir.ToList();
            this.bdgMedicament.DataSource = this.gsbrapports.medicament.ToList();
            this.bdgMedecin.DataSource = this.gsbrapports.medecin.ToList();
            this.bdgVisiteur.DataSource = this.gsbrapports.visiteur.ToList();


        }

        private void FrmModifierRapport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bdgRapport.EndEdit();
            this.bdgOffrir.EndEdit();
            this.bdgMedicament.EndEdit();
            this.gsbrapports.SaveChanges();
            this.Close();
        }
    }
}
