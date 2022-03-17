
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
            this.button2 = new System.Windows.Forms.Button();
            this.dtvRapport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bdgFamille = new System.Windows.Forms.BindingSource(this.components);
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.bdgOffrir = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Terminer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtvRapport
            // 
            this.dtvRapport.AllowUserToOrderColumns = true;
            this.dtvRapport.AutoGenerateColumns = false;
            this.dtvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dtvRapport.DataSource = this.bdgRapport;
            this.dtvRapport.Location = new System.Drawing.Point(10, 23);
            this.dtvRapport.Name = "dtvRapport";
            this.dtvRapport.Size = new System.Drawing.Size(648, 150);
            this.dtvRapport.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(Mission3GSB.rapport);
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(Mission3GSB.visiteur);
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(Mission3GSB.medecin);
            // 
            // bdgFamille
            // 
            this.bdgFamille.DataSource = typeof(Mission3GSB.famille);
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3GSB.medicament);
            // 
            // bdgOffrir
            // 
            this.bdgOffrir.DataSource = typeof(Mission3GSB.offrir);
            this.bdgOffrir.CurrentChanged += new System.EventHandler(this.bdgOffrir_CurrentChanged);
            // 
            // FrmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 293);
            this.Controls.Add(this.dtvRapport);
            this.Controls.Add(this.button2);
            this.Name = "FrmAjoutRapport";
            this.Text = "FrmAjoutRapport";
            this.Load += new System.EventHandler(this.FrmAjoutRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOffrir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bdgFamille;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.BindingSource bdgOffrir;
        private System.Windows.Forms.DataGridView dtvRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
    }
}