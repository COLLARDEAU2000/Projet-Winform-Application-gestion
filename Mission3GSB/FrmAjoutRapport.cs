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
    public partial class FrmAjoutRapport : Form
    {
        private gsbrapports2021Entities mesRapports;



        public FrmAjoutRapport( gsbrapports2021Entities mesRapports)
        {
            InitializeComponent();
            this.mesRapports = new gsbrapports2021Entities();
            this.mesRapports = mesRapports;
            this.bdgRapport.DataSource = this.mesRapports.rapport.ToList();
           
            
        }


      
        private void FrmAjoutRapport_Load(object sender, EventArgs e)
        {
       

        }

        private void Enregistrement_Click(object sender, EventArgs e)
        {

            this.bdgRapport.EndEdit();
            this.mesRapports.SaveChanges();

            MessageBox.Show($"Rapport   ajouter !");
            Form.ActiveForm.Close();


        }


        private void LstVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bdgRapport.EndEdit();
            this.mesRapports.SaveChanges();
            this.Close();

        }

        private void grbOffres_Enter(object sender, EventArgs e)
        {

        }

        private void cmbMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


       
        private void Enregistrement2_Click(object sender, EventArgs e)
        {
            this.bdgRapport.EndEdit();
            this.bdgMedicament.EndEdit();
            this.bdgVisiteur.EndEdit();
            this.bdgMedecin.EndEdit();
            this.bdgFamille.EndEdit();


            this.mesRapports.SaveChanges();

            MessageBox.Show($"Rapport   ajouter !");
            Form.ActiveForm.Close();

        }


        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bdgOffrir_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
