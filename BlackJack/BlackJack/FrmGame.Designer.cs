﻿namespace BlackJack
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            this.tmrTurn = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrTurn
            // 
            this.tmrTurn.Interval = 800;
            this.tmrTurn.Tick += new System.EventHandler(this.tmrTurn_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 517);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jeux";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.Click += new System.EventHandler(this.FrmGame_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTurn;
    }
}

