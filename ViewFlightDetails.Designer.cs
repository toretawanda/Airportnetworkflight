namespace AirportNetworkFlightScheduleCSharp
{
    partial class ViewFlightDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haltstationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightdDataSet2 = new AirportNetworkFlightScheduleCSharp.flightdDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.flightdTableAdapter = new AirportNetworkFlightScheduleCSharp.flightdDataSet2TableAdapters.flightdTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.halttimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 316);
            this.dataGridView1.TabIndex = 0;
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
            // flightdBindingSource
            // 
            this.flightdBindingSource.DataMember = "flightd";
            this.flightdBindingSource.DataSource = this.flightdDataSet2;
            // 
            // flightdDataSet2
            // 
            this.flightdDataSet2.DataSetName = "flightdDataSet2";
            this.flightdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(229, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "View Flight Details";
            // 
            // flightdTableAdapter
            // 
            this.flightdTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirportNetworkFlightScheduleCSharp.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(565, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ViewFlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewFlightDetails";
            this.Text = "ViewFlightDetails";
            this.Load += new System.EventHandler(this.ViewFlightDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private flightdDataSet2 flightdDataSet2;
        private System.Windows.Forms.BindingSource flightdBindingSource;
        private flightdDataSet2TableAdapters.flightdTableAdapter flightdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haltstationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}