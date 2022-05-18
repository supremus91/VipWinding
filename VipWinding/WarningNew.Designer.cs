namespace VipWinding
{
    partial class WarningNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningNew));
            this.Label2 = new System.Windows.Forms.Label();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(175, 34);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(201, 21);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Vuoi duplicare l\'elemento?";
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.BorderThickness = 1;
            this.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
            this.Guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(214)))), ((int)(((byte)(253)))));
            this.Guna2Button2.Location = new System.Drawing.Point(286, 74);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.Size = new System.Drawing.Size(121, 27);
            this.Guna2Button2.TabIndex = 8;
            this.Guna2Button2.Text = "No";
            this.Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.BorderThickness = 1;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(214)))), ((int)(((byte)(253)))));
            this.Guna2Button1.Location = new System.Drawing.Point(159, 74);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(121, 27);
            this.Guna2Button1.TabIndex = 7;
            this.Guna2Button1.Text = "Yes";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(2, 32);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(110, 73);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // WarningNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 127);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Guna2Button2);
            this.Controls.Add(this.Guna2Button1);
            this.Controls.Add(this.PictureBox1);
            this.Name = "WarningNew";
            this.Text = "Warning";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
    }
}