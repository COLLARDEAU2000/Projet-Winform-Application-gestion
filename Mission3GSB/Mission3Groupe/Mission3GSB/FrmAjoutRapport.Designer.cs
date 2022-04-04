
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
            this.labListeViisteur = new System.Windows.Forms.Label();
            this.ComboListeMedecin = new System.Windows.Forms.ComboBox();
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
            this.textBoxIdRapport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIdFamille = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxNomCommercial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxQuantite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxComposition = new System.Windows.Forms.TextBox();
            this.textBoxContreIndication = new System.Windows.Forms.TextBox();
            this.textBoxEffet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdMedicament = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labListeViisteur
            // 
            this.labListeViisteur.AutoSize = true;
            this.labListeViisteur.Location = new System.Drawing.Point(376, 26);
            this.labListeViisteur.Name = "labListeViisteur";
            this.labListeViisteur.Size = new System.Drawing.Size(99, 13);
            this.labListeViisteur.TabIndex = 1;
            this.labListeViisteur.Text = "Liste des visiteurs : ";
            // 
            // ComboListeMedecin
            // 
            this.ComboListeMedecin.FormattingEnabled = true;
            this.ComboListeMedecin.Location = new System.Drawing.Point(379, 109);
            this.ComboListeMedecin.Name = "ComboListeMedecin";
            this.ComboListeMedecin.Size = new System.Drawing.Size(121, 21);
            this.ComboListeMedecin.TabIndex = 2;
            // 
            // labListeDesMedecin
            // 
            this.labListeDesMedecin.AutoSize = true;
            this.labListeDesMedecin.Location = new System.Drawing.Point(376, 90);
            this.labListeDesMedecin.Name = "labListeDesMedecin";
            this.labListeDesMedecin.Size = new System.Drawing.Size(106, 13);
            this.labListeDesMedecin.TabIndex = 5;
            this.labListeDesMedecin.Text = "Liste des medecins : ";
            // 
            // labDateRapport
            // 
            this.labDateRapport.AutoSize = true;
            this.labDateRapport.Location = new System.Drawing.Point(6, 90);
            this.labDateRapport.Name = "labDateRapport";
            this.labDateRapport.Size = new System.Drawing.Size(71, 13);
            this.labDateRapport.TabIndex = 7;
            this.labDateRapport.Text = "Date Rpport :";
            // 
            // labMotif
            // 
            this.labMotif.AutoSize = true;
            this.labMotif.Location = new System.Drawing.Point(147, 27);
            this.labMotif.Name = "labMotif";
            this.labMotif.Size = new System.Drawing.Size(39, 13);
            this.labMotif.TabIndex = 8;
            this.labMotif.Text = "Motif : ";
            // 
            // labelBilanRapport
            // 
            this.labelBilanRapport.AutoSize = true;
            this.labelBilanRapport.Location = new System.Drawing.Point(147, 90);
            this.labelBilanRapport.Name = "labelBilanRapport";
            this.labelBilanRapport.Size = new System.Drawing.Size(77, 13);
            this.labelBilanRapport.TabIndex = 9;
            this.labelBilanRapport.Text = "Bilan Rapport :";
            // 
            // textboxMotif
            // 
            this.textboxMotif.Location = new System.Drawing.Point(150, 43);
            this.textboxMotif.Multiline = true;
            this.textboxMotif.Name = "textboxMotif";
            this.textboxMotif.Size = new System.Drawing.Size(175, 20);
            this.textboxMotif.TabIndex = 12;
            // 
            // textBilan
            // 
            this.textBilan.Location = new System.Drawing.Point(150, 106);
            this.textBilan.Multiline = true;
            this.textBilan.Name = "textBilan";
            this.textBilan.Size = new System.Drawing.Size(175, 93);
            this.textBilan.TabIndex = 13;
            this.textBilan.TextChanged += new System.EventHandler(this.textBilan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Rapport :";
            // 
            // dateTimeRapport
            // 
            this.dateTimeRapport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRapport.Location = new System.Drawing.Point(9, 106);
            this.dateTimeRapport.Name = "dateTimeRapport";
            this.dateTimeRapport.Size = new System.Drawing.Size(126, 20);
            this.dateTimeRapport.TabIndex = 15;
            this.dateTimeRapport.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            // 
            // buttonEnregistrementRapport
            // 
            this.buttonEnregistrementRapport.Location = new System.Drawing.Point(247, 528);
            this.buttonEnregistrementRapport.Name = "buttonEnregistrementRapport";
            this.buttonEnregistrementRapport.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrementRapport.TabIndex = 16;
            this.buttonEnregistrementRapport.Text = "Enregistrer Rapport";
            this.buttonEnregistrementRapport.UseVisualStyleBackColor = true;
            this.buttonEnregistrementRapport.Click += new System.EventHandler(this.buttonEnregistrementRapport_Click);
            // 
            // comboListeVisiteur
            // 
            this.comboListeVisiteur.FormattingEnabled = true;
            this.comboListeVisiteur.Location = new System.Drawing.Point(379, 42);
            this.comboListeVisiteur.Name = "comboListeVisiteur";
            this.comboListeVisiteur.Size = new System.Drawing.Size(121, 21);
            this.comboListeVisiteur.TabIndex = 0;
            this.comboListeVisiteur.SelectedIndexChanged += new System.EventHandler(this.comboListeVisiteur_SelectedIndexChanged);
            // 
            // textBoxIdRapport
            // 
            this.textBoxIdRapport.Location = new System.Drawing.Point(6, 43);
            this.textBoxIdRapport.Name = "textBoxIdRapport";
            this.textBoxIdRapport.ReadOnly = true;
            this.textBoxIdRapport.Size = new System.Drawing.Size(126, 20);
            this.textBoxIdRapport.TabIndex = 10;
            this.textBoxIdRapport.TextChanged += new System.EventHandler(this.textBoxIdRapport_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeRapport);
            this.groupBox1.Controls.Add(this.labDateRapport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIdRapport);
            this.groupBox1.Controls.Add(this.labMotif);
            this.groupBox1.Controls.Add(this.textboxMotif);
            this.groupBox1.Controls.Add(this.labelBilanRapport);
            this.groupBox1.Controls.Add(this.ComboListeMedecin);
            this.groupBox1.Controls.Add(this.labListeDesMedecin);
            this.groupBox1.Controls.Add(this.comboListeVisiteur);
            this.groupBox1.Controls.Add(this.textBilan);
            this.groupBox1.Controls.Add(this.labListeViisteur);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 205);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau Rapport  initial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Famille du medicament :";
            // 
            // comboBoxIdFamille
            // 
            this.comboBoxIdFamille.FormattingEnabled = true;
            this.comboBoxIdFamille.Location = new System.Drawing.Point(193, 43);
            this.comboBoxIdFamille.Name = "comboBoxIdFamille";
            this.comboBoxIdFamille.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdFamille.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIdMedicament);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxEffet);
            this.groupBox2.Controls.Add(this.textBoxContreIndication);
            this.groupBox2.Controls.Add(this.textBoxComposition);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxQuantite);
            this.groupBox2.Controls.Add(this.comboBoxNomCommercial);
            this.groupBox2.Controls.Add(this.comboBoxIdFamille);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 290);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nouveau rapport extension : ";
            // 
            // comboBoxNomCommercial
            // 
            this.comboBoxNomCommercial.FormattingEnabled = true;
            this.comboBoxNomCommercial.Location = new System.Drawing.Point(14, 243);
            this.comboBoxNomCommercial.Name = "comboBoxNomCommercial";
            this.comboBoxNomCommercial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomCommercial.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nom Commercial :";
            // 
            // comboBoxQuantite
            // 
            this.comboBoxQuantite.FormattingEnabled = true;
            this.comboBoxQuantite.Location = new System.Drawing.Point(379, 43);
            this.comboBoxQuantite.Name = "comboBoxQuantite";
            this.comboBoxQuantite.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuantite.TabIndex = 23;
            this.comboBoxQuantite.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantite : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Composition :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contre Indication :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Effets : ";
            // 
            // textBoxComposition
            // 
            this.textBoxComposition.Location = new System.Drawing.Point(9, 100);
            this.textBoxComposition.Multiline = true;
            this.textBoxComposition.Name = "textBoxComposition";
            this.textBoxComposition.Size = new System.Drawing.Size(121, 101);
            this.textBoxComposition.TabIndex = 28;
            // 
            // textBoxContreIndication
            // 
            this.textBoxContreIndication.Location = new System.Drawing.Point(379, 100);
            this.textBoxContreIndication.Multiline = true;
            this.textBoxContreIndication.Name = "textBoxContreIndication";
            this.textBoxContreIndication.Size = new System.Drawing.Size(121, 101);
            this.textBoxContreIndication.TabIndex = 29;
            // 
            // textBoxEffet
            // 
            this.textBoxEffet.Location = new System.Drawing.Point(193, 101);
            this.textBoxEffet.Multiline = true;
            this.textBoxEffet.Name = "textBoxEffet";
            this.textBoxEffet.Size = new System.Drawing.Size(121, 100);
            this.textBoxEffet.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Id medicament :";
            // 
            // textBoxIdMedicament
            // 
            this.textBoxIdMedicament.Location = new System.Drawing.Point(14, 44);
            this.textBoxIdMedicament.Name = "textBoxIdMedicament";
            this.textBoxIdMedicament.ReadOnly = true;
            this.textBoxIdMedicament.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdMedicament.TabIndex = 32;
            // 
            // FrmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEnregistrementRapport);
            this.Name = "FrmAjoutRapport";
            this.Text = "FrmAjoutRapport";
            this.Load += new System.EventHandler(this.FrmAjoutRapport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIdFamille;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxNomCommercial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxQuantite;
        private System.Windows.Forms.TextBox textBoxIdMedicament;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEffet;
        private System.Windows.Forms.TextBox textBoxContreIndication;
        private System.Windows.Forms.TextBox textBoxComposition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}