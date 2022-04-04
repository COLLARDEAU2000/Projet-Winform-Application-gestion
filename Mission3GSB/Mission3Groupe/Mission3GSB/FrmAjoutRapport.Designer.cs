
namespace Mission3GSB
{
    partial class FrmAjoutRapport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labListeViisteur = new System.Windows.Forms.Label();
            this.ComboListeMedecin = new System.Windows.Forms.ComboBox();
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.labListeDesMedecin = new System.Windows.Forms.Label();
            this.labDateRapport = new System.Windows.Forms.Label();
            this.labMotif = new System.Windows.Forms.Label();
            this.labelBilanRapport = new System.Windows.Forms.Label();
            this.textboxMotif = new System.Windows.Forms.TextBox();
            this.textBilan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeRapport = new System.Windows.Forms.DateTimePicker();
            this.buttonEnregistrementRapport = new System.Windows.Forms.Button();
            this.comboListeVisiteur = new System.Windows.Forms.ComboBox();
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxIdRapport = new System.Windows.Forms.TextBox();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bdgOffre = new System.Windows.Forms.BindingSource(this.components);
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.bdgFamille = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).BeginInit();
            this.SuspendLayout();
            // 
            // labListeViisteur
            // 
            this.labListeViisteur.AutoSize = true;
            this.labListeViisteur.Location = new System.Drawing.Point(324, 86);
            this.labListeViisteur.Name = "labListeViisteur";
            this.labListeViisteur.Size = new System.Drawing.Size(99, 13);
            this.labListeViisteur.TabIndex = 1;
            this.labListeViisteur.Text = "Liste des visiteurs : ";
            // 
            // ComboListeMedecin
            // 
            this.ComboListeMedecin.DataSource = this.bdgMedecin;
            this.ComboListeMedecin.DisplayMember = "id";
            this.ComboListeMedecin.FormattingEnabled = true;
            this.ComboListeMedecin.Location = new System.Drawing.Point(436, 134);
            this.ComboListeMedecin.Name = "ComboListeMedecin";
            this.ComboListeMedecin.Size = new System.Drawing.Size(121, 21);
            this.ComboListeMedecin.TabIndex = 2;
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(Mission3GSB.medecin);
            // 
            // labListeDesMedecin
            // 
            this.labListeDesMedecin.AutoSize = true;
            this.labListeDesMedecin.Location = new System.Drawing.Point(324, 142);
            this.labListeDesMedecin.Name = "labListeDesMedecin";
            this.labListeDesMedecin.Size = new System.Drawing.Size(106, 13);
            this.labListeDesMedecin.TabIndex = 5;
            this.labListeDesMedecin.Text = "Liste des medecins : ";
            // 
            // labDateRapport
            // 
            this.labDateRapport.AutoSize = true;
            this.labDateRapport.Location = new System.Drawing.Point(22, 75);
            this.labDateRapport.Name = "labDateRapport";
            this.labDateRapport.Size = new System.Drawing.Size(71, 13);
            this.labDateRapport.TabIndex = 7;
            this.labDateRapport.Text = "Date Rpport :";
            // 
            // labMotif
            // 
            this.labMotif.AutoSize = true;
            this.labMotif.Location = new System.Drawing.Point(22, 142);
            this.labMotif.Name = "labMotif";
            this.labMotif.Size = new System.Drawing.Size(39, 13);
            this.labMotif.TabIndex = 8;
            this.labMotif.Text = "Motif : ";
            // 
            // labelBilanRapport
            // 
            this.labelBilanRapport.AutoSize = true;
            this.labelBilanRapport.Location = new System.Drawing.Point(324, 39);
            this.labelBilanRapport.Name = "labelBilanRapport";
            this.labelBilanRapport.Size = new System.Drawing.Size(77, 13);
            this.labelBilanRapport.TabIndex = 9;
            this.labelBilanRapport.Text = "Bilan Rapport :";
            // 
            // textboxMotif
            // 
            this.textboxMotif.Location = new System.Drawing.Point(99, 139);
            this.textboxMotif.Multiline = true;
            this.textboxMotif.Name = "textboxMotif";
            this.textboxMotif.Size = new System.Drawing.Size(200, 100);
            this.textboxMotif.TabIndex = 12;
            // 
            // textBilan
            // 
            this.textBilan.Location = new System.Drawing.Point(436, 36);
            this.textBilan.Name = "textBilan";
            this.textBilan.Size = new System.Drawing.Size(121, 20);
            this.textBilan.TabIndex = 13;
            this.textBilan.TextChanged += new System.EventHandler(this.textBilan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Rapport :";
            // 
            // dateTimeRapport
            // 
            this.dateTimeRapport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRapport.Location = new System.Drawing.Point(99, 69);
            this.dateTimeRapport.Name = "dateTimeRapport";
            this.dateTimeRapport.Size = new System.Drawing.Size(126, 20);
            this.dateTimeRapport.TabIndex = 15;
            this.dateTimeRapport.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            // 
            // buttonEnregistrementRapport
            // 
            this.buttonEnregistrementRapport.Location = new System.Drawing.Point(249, 280);
            this.buttonEnregistrementRapport.Name = "buttonEnregistrementRapport";
            this.buttonEnregistrementRapport.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrementRapport.TabIndex = 16;
            this.buttonEnregistrementRapport.Text = "Enregistrer Rapport";
            this.buttonEnregistrementRapport.UseVisualStyleBackColor = true;
            this.buttonEnregistrementRapport.Click += new System.EventHandler(this.buttonEnregistrementRapport_Click);
            // 
            // comboListeVisiteur
            // 
            this.comboListeVisiteur.DataSource = this.bdgVisiteur;
            this.comboListeVisiteur.DisplayMember = "id";
            this.comboListeVisiteur.FormattingEnabled = true;
            this.comboListeVisiteur.Location = new System.Drawing.Point(436, 78);
            this.comboListeVisiteur.Name = "comboListeVisiteur";
            this.comboListeVisiteur.Size = new System.Drawing.Size(121, 21);
            this.comboListeVisiteur.TabIndex = 0;
            this.comboListeVisiteur.SelectedIndexChanged += new System.EventHandler(this.comboListeVisiteur_SelectedIndexChanged);
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(Mission3GSB.visiteur);
            // 
            // textBoxIdRapport
            // 
            this.textBoxIdRapport.Location = new System.Drawing.Point(99, 32);
            this.textBoxIdRapport.Name = "textBoxIdRapport";
            this.textBoxIdRapport.ReadOnly = true;
            this.textBoxIdRapport.Size = new System.Drawing.Size(126, 20);
            this.textBoxIdRapport.TabIndex = 10;
            this.textBoxIdRapport.TextChanged += new System.EventHandler(this.textBoxIdRapport_TextChanged);
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(Mission3GSB.offrir);
            // 
            // bdgOffre
            // 
            this.bdgOffre.DataSource = typeof(Mission3GSB.offrir);
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3GSB.medicament);
            // 
            // bdgFamille
            // 
            this.bdgFamille.DataSource = typeof(Mission3GSB.famille);
            // 
            // FrmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 349);
            this.Controls.Add(this.buttonEnregistrementRapport);
            this.Controls.Add(this.dateTimeRapport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBilan);
            this.Controls.Add(this.textboxMotif);
            this.Controls.Add(this.textBoxIdRapport);
            this.Controls.Add(this.labelBilanRapport);
            this.Controls.Add(this.labMotif);
            this.Controls.Add(this.labDateRapport);
            this.Controls.Add(this.labListeDesMedecin);
            this.Controls.Add(this.ComboListeMedecin);
            this.Controls.Add(this.labListeViisteur);
            this.Controls.Add(this.comboListeVisiteur);
            this.Name = "FrmAjoutRapport";
            this.Text = "FrmAjoutRapport";
            this.Load += new System.EventHandler(this.FrmAjoutRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labListeViisteur;
        private System.Windows.Forms.ComboBox ComboListeMedecin;
        private System.Windows.Forms.Label labListeDesMedecin;
        private System.Windows.Forms.Label labDateRapport;
        private System.Windows.Forms.Label labMotif;
        private System.Windows.Forms.Label labelBilanRapport;
        private System.Windows.Forms.TextBox textboxMotif;
        private System.Windows.Forms.TextBox textBilan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeRapport;
        private System.Windows.Forms.Button buttonEnregistrementRapport;
        private System.Windows.Forms.ComboBox comboListeVisiteur;
        private System.Windows.Forms.TextBox textBoxIdRapport;
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.BindingSource bdgOffre;
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.BindingSource bdgFamille;
    }
}