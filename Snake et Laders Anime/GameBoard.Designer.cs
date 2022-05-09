
namespace Snake_et_Laders_Anime
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBxDé = new System.Windows.Forms.PictureBox();
            this.BtnLancer = new System.Windows.Forms.Button();
            this.LblResultatDé = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxDé)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PBxDé
            // 
            this.PBxDé.Location = new System.Drawing.Point(152, 656);
            this.PBxDé.Name = "PBxDé";
            this.PBxDé.Size = new System.Drawing.Size(63, 50);
            this.PBxDé.TabIndex = 1;
            this.PBxDé.TabStop = false;
            // 
            // BtnLancer
            // 
            this.BtnLancer.Location = new System.Drawing.Point(30, 671);
            this.BtnLancer.Name = "BtnLancer";
            this.BtnLancer.Size = new System.Drawing.Size(75, 23);
            this.BtnLancer.TabIndex = 2;
            this.BtnLancer.Text = "Lancer";
            this.BtnLancer.UseVisualStyleBackColor = true;
            // 
            // LblResultatDé
            // 
            this.LblResultatDé.AutoSize = true;
            this.LblResultatDé.Location = new System.Drawing.Point(267, 676);
            this.LblResultatDé.Name = "LblResultatDé";
            this.LblResultatDé.Size = new System.Drawing.Size(86, 13);
            this.LblResultatDé.TabIndex = 3;
            this.LblResultatDé.Text = "Vous avez fait 5 ";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 718);
            this.Controls.Add(this.LblResultatDé);
            this.Controls.Add(this.BtnLancer);
            this.Controls.Add(this.PBxDé);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxDé)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBxDé;
        private System.Windows.Forms.Button BtnLancer;
        private System.Windows.Forms.Label LblResultatDé;
    }
}