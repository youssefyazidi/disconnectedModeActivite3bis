namespace disconnectedModeActivite3bis
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
            this.grdPass = new System.Windows.Forms.DataGridView();
            this.grdPersPass = new System.Windows.Forms.DataGridView();
            this.grdPers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPass
            // 
            this.grdPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPass.Location = new System.Drawing.Point(624, 74);
            this.grdPass.Name = "grdPass";
            this.grdPass.Size = new System.Drawing.Size(187, 300);
            this.grdPass.TabIndex = 5;
            this.grdPass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPass_CellContentClick);
            this.grdPass.CurrentCellChanged += new System.EventHandler(this.grdPass_CurrentCellChanged);
            // 
            // grdPersPass
            // 
            this.grdPersPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersPass.Location = new System.Drawing.Point(342, 74);
            this.grdPersPass.Name = "grdPersPass";
            this.grdPersPass.Size = new System.Drawing.Size(202, 300);
            this.grdPersPass.TabIndex = 4;
            // 
            // grdPers
            // 
            this.grdPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPers.Location = new System.Drawing.Point(67, 74);
            this.grdPers.Name = "grdPers";
            this.grdPers.Size = new System.Drawing.Size(216, 300);
            this.grdPers.TabIndex = 3;
            this.grdPers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPers_CellContentClick);
            this.grdPers.CurrentCellChanged += new System.EventHandler(this.grdPers_CurrentCellChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 448);
            this.Controls.Add(this.grdPass);
            this.Controls.Add(this.grdPersPass);
            this.Controls.Add(this.grdPers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPass;
        private System.Windows.Forms.DataGridView grdPersPass;
        private System.Windows.Forms.DataGridView grdPers;
    }
}

