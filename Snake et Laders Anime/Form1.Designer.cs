
namespace Snake_et_Laders_Anime
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
            this.CmBxNbJoueur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmBxNbJoueur
            // 
            this.CmBxNbJoueur.FormattingEnabled = true;
            this.CmBxNbJoueur.Location = new System.Drawing.Point(227, 96);
            this.CmBxNbJoueur.Name = "CmBxNbJoueur";
            this.CmBxNbJoueur.Size = new System.Drawing.Size(121, 21);
            this.CmBxNbJoueur.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmBxNbJoueur);
            this.Name = "Form1";
            this.Text = "Snake & Lader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmBxNbJoueur;
    }
}

