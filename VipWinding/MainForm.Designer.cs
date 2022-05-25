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
            this.Corona = new Guna.UI2.WinForms.Guna2Button();
            this.Rotor = new Guna.UI2.WinForms.Guna2Button();
            this.Stator = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.Corona);
            this.MainPanel.Controls.Add(this.Rotor);
            this.MainPanel.Controls.Add(this.Stator);
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MainPanel.Location = new System.Drawing.Point(2, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1695, 1006);
            this.MainPanel.TabIndex = 0;
            // 
            // Corona
            // 
            this.Corona.CustomBorderColor = System.Drawing.Color.Black;
            this.Corona.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Corona.FillColor = System.Drawing.Color.Transparent;
            this.Corona.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.Corona.ForeColor = System.Drawing.Color.Black;
            this.Corona.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Corona.Location = new System.Drawing.Point(5, 116);
            this.Corona.Name = "Corona";
            this.Corona.Size = new System.Drawing.Size(170, 35);
            this.Corona.TabIndex = 272;
            this.Corona.Text = "Corona";
            this.Corona.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Rotor
            // 
            this.Rotor.CustomBorderColor = System.Drawing.Color.Black;
            this.Rotor.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Rotor.FillColor = System.Drawing.Color.Transparent;
            this.Rotor.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.Rotor.ForeColor = System.Drawing.Color.Black;
            this.Rotor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Rotor.Location = new System.Drawing.Point(5, 80);
            this.Rotor.Name = "Rotor";
            this.Rotor.Size = new System.Drawing.Size(170, 35);
            this.Rotor.TabIndex = 271;
            this.Rotor.Text = "Rotore";
            this.Rotor.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Stator
            // 
            this.Stator.CustomBorderColor = System.Drawing.Color.Black;
            this.Stator.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Stator.FillColor = System.Drawing.Color.Transparent;
            this.Stator.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.Stator.ForeColor = System.Drawing.Color.Black;
            this.Stator.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Stator.Location = new System.Drawing.Point(5, 44);
            this.Stator.Name = "Stator";
            this.Stator.Size = new System.Drawing.Size(170, 35);
            this.Stator.TabIndex = 270;
            this.Stator.Text = "Statore";
            this.Stator.Click += new System.EventHandler(this.Btn_Click);
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
        internal Guna.UI2.WinForms.Guna2Button Stator;
        internal Guna.UI2.WinForms.Guna2Button Rotor;
        internal Guna.UI2.WinForms.Guna2Button Corona;
    }
}

