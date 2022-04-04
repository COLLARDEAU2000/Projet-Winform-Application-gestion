using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;


namespace Mission3GSB
{
    public partial class FrmAjoutRapport : Form
    {
        public FrmAjoutRapport()
        {
            InitializeComponent();
        }

        private gsbrapports2021Entities mesRapports;


        public FrmAjoutRapport(gsbrapports2021Entities mesRapports)
        {
            InitializeComponent();
            this.mesRapports = new gsbrapports2021Entities();
            this.mesRapports = mesRapports;
            this.bdgRapport.DataSource = this.mesRapports.rapport.ToList();
            this.bdgOffre.DataSource = this.mesRapports.offrir.ToList();
            this.bdgMedicament.DataSource = this.mesRapports.medicament.ToList();
            this.bdgMedecin.DataSource = this.mesRapports.medecin.ToList();
            this.bdgVisiteur.DataSource = this.mesRapports.visiteur.ToList();
            this.bdgFamille.DataSource = this.mesRapports.famille.ToList();
            
        }

        //* liste des visiteurs
        public void getVisiteurs()
        {
            List<visiteur>lesVisiteur = this.mesRapports.visiteur.ToList();

            var req = from em in  lesVisiteur
                      select em.id;

            foreach (var em in req)
            {
                comboListeVisiteur.Items.Add(em);
                comboListeVisiteur.SelectedIndex = 0;
            }
        }
        public void getMedecin()
        {
            List<medecin> lesMedecin = this.mesRapports.medecin.ToList();

            var req = from me in lesMedecin
                      select me.id;

            foreach (var me in req)
            {
                ComboListeMedecin.Items.Add(me);
                ComboListeMedecin.SelectedIndex = 0;
            }

        }

        private void recupFamillePourMedicament()
        {


           /* var req = from me in this.mesRapports.medicament
                      where me.idFamille == this.comboBoxIdFamille.SelectedValue.ToString()
                      select me.id;


            foreach (var me in req)
            {
                comboBoxIdMedicament.Items.Add(me);
            }*/



        }




        private void comboListeVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAjoutRapport_Load(object sender, EventArgs e)
        {
            //this.getVisiteurs();
            //this.getMedecin();
            this.textBoxIdRapport.Text = this.getIdRapportCree().ToString();


        }

        //fontion pour inserer automatiquement un id lors de la creation d'un rapport
        private int getIdRapportCree()
        {
            var reqDernier = (from rap in this.mesRapports.rapport
                              orderby rap.id descending
                              select rap);
            rapport dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }

        //permet d'ajouter les infos d'un medicament d'un rapport 

        private void InsertRapportMedicament()
        {

            // preparation des variables table medecament


            //string idMedicament = Convert.ToString(this.textNomMedicament.Text);
            //string nomCommercial = Convert.ToString(this.comboBoxNomMedicament.SelectedValue);
            //string idFamilleMedicament = Convert.ToString(this.comboBoxIdFamille.SelectedValue);
            //string compostionMdicament = Convert.ToString(this.textBoxComposition.Text);
            //string effetMedicament = Convert.ToString(this.textBoxEffets.Text);
            //string contreIndication = Convert.ToString(this.textBoxContreIndication.Text);


            /*insertion des valeurs de l'occurence offrir 

            medicament occurenceMedicament = new medicament();

            / insertion des valeurs de l'occurence medicament 

            occurenceMedicament.id = idMedicament;
            occurenceMedicament.idFamille = idFamilleMedicament;
            occurenceMedicament.nomCommercial = nomCommercial;
            occurenceMedicament.composition = compostionMdicament;
            occurenceMedicament.effets = effetMedicament;
            occurenceMedicament.contreIndications =contreIndication;

            //Ajout dns la table medicament

            this.mesRapports.medicament.Add(occurenceMedicament);
            this.bdgMedicament.EndEdit();*/




        }

        // permet d'ajouter un rapport
        private void InsertRapport()
        {
            


            //preparation des variables table Rapport

            int idRapport = Convert.ToInt32(this.textBoxIdRapport.Text);
            DateTime dateRapport = this.dateTimeRapport.Value;
            string rapportMotif = Convert.ToString(this.textboxMotif.Text.ToString());
            string rapportBilan = Convert.ToString(this.textBilan.Text.ToString());
            medecin idMedecin = (medecin)this.ComboListeMedecin.SelectedValue;
            visiteur idVisiteur = (visiteur)this.comboListeVisiteur.SelectedValue;

           
            //preparation des variables table offrir 

            //int Quantite = 0;


            //creation d'une occurence de type rapport */

            rapport occurenceRapport = new rapport();
            medicament occurenceMedicament = new medicament();
            offrir occurenceOfrre = new offrir();

            // insertion des valeurs de l'occurence rapport

            occurenceRapport.id = idRapport;
            occurenceRapport.date = dateRapport;
            occurenceRapport.motif = rapportMotif;
            occurenceRapport.bilan = rapportBilan;
            occurenceRapport.medecin= idMedecin;
            occurenceRapport.visiteur = idVisiteur;

            

            //occurenceOfrre.quantite = Quantite;*/


            //Enregistrement Formulaire Ajout rapport 

            //recupDonneRapport.Insert((idRapport-1),occurence);
            //this.bdgRapport.Add(occurence);
            //this.bdgRapport.AddNew();
            //this.mesRapports.SaveChangesAsync();
            this.mesRapports.rapport.Add(occurenceRapport);
            this.bdgRapport.EndEdit();



        }


        private void buttonEnregistrementRapport_Click(object sender, EventArgs e)
        {


            this.InsertRapport();
            this.mesRapports.SaveChanges();
            MessageBox.Show($"Rapport N{this.getIdRapportCree()-1} ajouter !");


        }

        private void textBoxIdRapport_TextChanged(object sender, EventArgs e)
        {

            this.textBoxIdRapport.Text = this.getIdRapportCree().ToString();
            
        }


        private void textBilan_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
