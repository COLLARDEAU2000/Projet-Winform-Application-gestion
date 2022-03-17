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
    public partial class frmVisualiser : Form
    {
        gsbrapports2021Entities gsbrapports;
        public frmVisualiser(gsbrapports2021Entities gsbrapports)
        {
            InitializeComponent();
            this.gsbrapports = new gsbrapports2021Entities();
            this.gsbrapports = gsbrapports;
            this.bdgRapport.DataSource = this.gsbrapports.rapport.Include("offrir").ToList();
            this.bdgOffrir.DataSource = this.gsbrapports.offrir.ToList();
            this.bdgMedecin.DataSource = this.gsbrapports.medecin.ToList();
            this.bdgMedicament.DataSource = this.gsbrapports.medicament.ToList();
            this.bdgVisiteur.DataSource = this.gsbrapports.visiteur.ToList();



                }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.bdgRapport.EndEdit();
            this.bdgOffrir.EndEdit();
            this.bdgMedecin.EndEdit();
            this.bdgVisiteur.EndEdit();
            this.bdgMedicament.EndEdit();
            this.gsbrapports.SaveChanges();
            this.Close();
        }
        private int getNumDernierRapportsAjouter()
        {
            var reqDernier = (from ra in this.gsbrapports.rapport
                              orderby ra.id descending
                              select ra);
            rapport dernierEleve = reqDernier.First();
            int n = dernierEleve.id;
            return n;
        }

        private void frmVisualiser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
