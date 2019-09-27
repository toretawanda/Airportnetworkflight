namespace AirportNetworkFlightScheduleCSharp
{
    partial class HomeA
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
            this.addFlightDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportAdminInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFlightDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightDetailsToolStripMenuItem,
            this.airportAdminInfoToolStripMenuItem,
            this.viewFlightDetailsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFlightDetailsToolStripMenuItem
            // 
            this.addFlightDetailsToolStripMenuItem.Name = "addFlightDetailsToolStripMenuItem";
            this.addFlightDetailsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.addFlightDetailsToolStripMenuItem.Text = "Add Flight Details";
            this.addFlightDetailsToolStripMenuItem.Click += new System.EventHandler(this.addFlightDetailsToolStripMenuItem_Click);
            // 
            // airportAdminInfoToolStripMenuItem
            // 
            this.airportAdminInfoToolStripMenuItem.Name = "airportAdminInfoToolStripMenuItem";
            this.airportAdminInfoToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.airportAdminInfoToolStripMenuItem.Text = "Airport Admin Info";
            this.airportAdminInfoToolStripMenuItem.Click += new System.EventHandler(this.airportAdminInfoToolStripMenuItem_Click);
            // 
            // viewFlightDetailsToolStripMenuItem
            // 
            this.viewFlightDetailsToolStripMenuItem.Name = "viewFlightDetailsToolStripMenuItem";
            this.viewFlightDetailsToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.viewFlightDetailsToolStripMenuItem.Text = "View Flight Details";
            this.viewFlightDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewFlightDetailsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirportNetworkFlightScheduleCSharp.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(504, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // HomeA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeA";
            this.Text = "HomeA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFlightDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportAdminInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFlightDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}