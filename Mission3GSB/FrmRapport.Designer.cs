
namespace Mission3GSB
{
    partial class FrmRapport
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.gestionRapportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem1});
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.quitterToolStripMenuItem.Text = "Fichier";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // gestionRapportToolStripMenuItem
            // 
            this.gestionRapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutRapportsToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.visualiserLesRapportsToolStripMenuItem});
            this.gestionRapportToolStripMenuItem.Name = "gestionRapportToolStripMenuItem";
            this.gestionRapportToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.gestionRapportToolStripMenuItem.Text = "Gestion rapports";
            // 
            // ajoutRapportsToolStripMenuItem
            // 
            this.ajoutRapportsToolStripMenuItem.Name = "ajoutRapportsToolStripMenuItem";
            this.ajoutRapportsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ajoutRapportsToolStripMenuItem.Text = "Ajout rapports";
            this.ajoutRapportsToolStripMenuItem.Click += new System.EventHandler(this.ajoutRapportsToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // visualiserLesRapportsToolStripMenuItem
            // 
            this.visualiserLesRapportsToolStripMenuItem.Name = "visualiserLesRapportsToolStripMenuItem";
            this.visualiserLesRapportsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.visualiserLesRapportsToolStripMenuItem.Text = "Visualiser les rapports ";
            this.visualiserLesRapportsToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesRapportsToolStripMenuItem_Click);
            // 
            // FrmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRapport";
            this.Text = "Gestion de rapports";
            this.Load += new System.EventHandler(this.FrmRapport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutRapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesRapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}

