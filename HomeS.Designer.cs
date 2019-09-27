namespace AirportNetworkFlightScheduleCSharp
{
    partial class HomeS
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
            this.addFlightDelayDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDelayFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.addFlightDelayDetailsToolStripMenuItem,
            this.viewDelayFlightToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFlightDelayDetailsToolStripMenuItem
            // 
            this.addFlightDelayDetailsToolStripMenuItem.Name = "addFlightDelayDetailsToolStripMenuItem";
            this.addFlightDelayDetailsToolStripMenuItem.Size = new System.Drawing.Size(188, 20);
            this.addFlightDelayDetailsToolStripMenuItem.Text = "Add Flight Delay Details";
            this.addFlightDelayDetailsToolStripMenuItem.Click += new System.EventHandler(this.addFlightDelayDetailsToolStripMenuItem_Click);
            // 
            // viewDelayFlightToolStripMenuItem
            // 
            this.viewDelayFlightToolStripMenuItem.Name = "viewDelayFlightToolStripMenuItem";
            this.viewDelayFlightToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.viewDelayFlightToolStripMenuItem.Text = "View Delay Flight";
            this.viewDelayFlightToolStripMenuItem.Click += new System.EventHandler(this.viewDelayFlightToolStripMenuItem_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(458, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // HomeS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomeS";
            this.Text = "HomeS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFlightDelayDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDelayFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}