namespace VipWinding
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.MainPanel = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnStatore = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRotore = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.BtnRotore);
            this.MainPanel.Controls.Add(this.BtnStatore);
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MainPanel.Location = new System.Drawing.Point(2, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1695, 1006);
            this.MainPanel.TabIndex = 0;
            // 
            // BtnStatore
            // 
            this.BtnStatore.CustomBorderColor = System.Drawing.Color.Black;
            this.BtnStatore.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.BtnStatore.FillColor = System.Drawing.Color.Transparent;
            this.BtnStatore.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.BtnStatore.ForeColor = System.Drawing.Color.Black;
            this.BtnStatore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnStatore.Location = new System.Drawing.Point(5, 44);
            this.BtnStatore.Name = "BtnStatore";
            this.BtnStatore.Size = new System.Drawing.Size(170, 35);
            this.BtnStatore.TabIndex = 270;
            this.BtnStatore.Text = "Statore";
            this.BtnStatore.Click += new System.EventHandler(this.BtnStatore_Click);
            // 
            // BtnRotore
            // 
            this.BtnRotore.CustomBorderColor = System.Drawing.Color.Black;
            this.BtnRotore.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.BtnRotore.FillColor = System.Drawing.Color.Transparent;
            this.BtnRotore.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.BtnRotore.ForeColor = System.Drawing.Color.Black;
            this.BtnRotore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnRotore.Location = new System.Drawing.Point(5, 80);
            this.BtnRotore.Name = "BtnRotore";
            this.BtnRotore.Size = new System.Drawing.Size(170, 35);
            this.BtnRotore.TabIndex = 271;
            this.BtnRotore.Text = "Rotore";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1698, 1012);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Archivio avvolgimenti";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2GroupBox MainPanel;
        internal Guna.UI2.WinForms.Guna2Button BtnStatore;
        internal Guna.UI2.WinForms.Guna2Button BtnRotore;
    }
}

