namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.ventesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 2, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1094, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.acceuilToolStripMenuItem.Text = "Acceuil";
            this.acceuilToolStripMenuItem.Click += new System.EventHandler(this.acceuilToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.produitsToolStripMenuItem.Text = "Produits";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // ventesToolStripMenuItem
            // 
            this.ventesToolStripMenuItem.Name = "ventesToolStripMenuItem";
            this.ventesToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ventesToolStripMenuItem.Text = "Ventes";
            this.ventesToolStripMenuItem.Click += new System.EventHandler(this.ventesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 653);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

