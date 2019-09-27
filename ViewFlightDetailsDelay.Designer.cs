namespace AirportNetworkFlightScheduleCSharp
{
    partial class ViewFlightDetailsDelay
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightdDataSet3 = new AirportNetworkFlightScheduleCSharp.flightdDataSet3();
            this.flightdelayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightdelayTableAdapter = new AirportNetworkFlightScheduleCSharp.flightdDataSet3TableAdapters.flightdelayTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haltstationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delaytimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdelayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(333, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(235, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "View Flight Delay Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Flight No.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.airlinesDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.haltstationDataGridViewTextBoxColumn,
            this.halttimeDataGridViewTextBoxColumn,
            this.delaytimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightdelayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 236);
            this.dataGridView1.TabIndex = 45;
            // 
            // flightdDataSet3
            // 
            this.flightdDataSet3.DataSetName = "flightdDataSet3";
            this.flightdDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightdelayBindingSource
            // 
            this.flightdelayBindingSource.DataMember = "flightdelay";
            this.flightdelayBindingSource.DataSource = this.flightdDataSet3;
            // 
            // flightdelayTableAdapter
            // 
            this.flightdelayTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // airlinesDataGridViewTextBoxColumn
            // 
            this.airlinesDataGridViewTextBoxColumn.DataPropertyName = "airlines";
            this.airlinesDataGridViewTextBoxColumn.HeaderText = "airlines";
            this.airlinesDataGridViewTextBoxColumn.Name = "airlinesDataGridViewTextBoxColumn";
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "arrival";
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            // 
            // haltstationDataGridViewTextBoxColumn
            // 
            this.haltstationDataGridViewTextBoxColumn.DataPropertyName = "halt_station";
            this.haltstationDataGridViewTextBoxColumn.HeaderText = "halt_station";
            this.haltstationDataGridViewTextBoxColumn.Name = "haltstationDataGridViewTextBoxColumn";
            // 
            // halttimeDataGridViewTextBoxColumn
            // 
            this.halttimeDataGridViewTextBoxColumn.DataPropertyName = "halt_time";
            this.halttimeDataGridViewTextBoxColumn.HeaderText = "halt_time";
            this.halttimeDataGridViewTextBoxColumn.Name = "halttimeDataGridViewTextBoxColumn";
            // 
            // delaytimeDataGridViewTextBoxColumn
            // 
            this.delaytimeDataGridViewTextBoxColumn.DataPropertyName = "delay_time";
            this.delaytimeDataGridViewTextBoxColumn.HeaderText = "delay_time";
            this.delaytimeDataGridViewTextBoxColumn.Name = "delaytimeDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirportNetworkFlightScheduleCSharp.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(536, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // ViewFlightDetailsDelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewFlightDetailsDelay";
            this.Text = "ViewFlightDetailsDelay";
            this.Load += new System.EventHandler(this.ViewFlightDetailsDelay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdelayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private flightdDataSet3 flightdDataSet3;
        private System.Windows.Forms.BindingSource flightdelayBindingSource;
        private flightdDataSet3TableAdapters.flightdelayTableAdapter flightdelayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haltstationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delaytimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}