
namespace TestMySQL
{
    partial class Form1
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
            this.lstProfil = new System.Windows.Forms.ListBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProfil
            // 
            this.lstProfil.FormattingEnabled = true;
            this.lstProfil.Location = new System.Drawing.Point(12, 12);
            this.lstProfil.Name = "lstProfil";
            this.lstProfil.Size = new System.Drawing.Size(120, 160);
            this.lstProfil.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 178);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(120, 20);
            this.txtNom.TabIndex = 1;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(138, 175);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 2;
            this.btnAjout.Text = "ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(138, 12);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 207);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lstProfil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfil;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSuppr;
    }
}

