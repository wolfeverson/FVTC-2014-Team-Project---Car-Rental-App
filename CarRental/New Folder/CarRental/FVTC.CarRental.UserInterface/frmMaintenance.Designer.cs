namespace FVTC.CarRental.UserInterface
{
    partial class frmMaintenance
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxMaintenance = new System.Windows.Forms.GroupBox();
            this.btnFindLot = new System.Windows.Forms.Button();
            this.cbxNeedAnalysis = new System.Windows.Forms.CheckBox();
            this.txtLotID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstTasksForVehicle = new System.Windows.Forms.ListBox();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.txtLastCoolingFlush = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTireTreads = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastAirFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastBrakeJob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastOilChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gbxMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(12, 13);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.Size = new System.Drawing.Size(544, 267);
            this.dgvVehicles.TabIndex = 0;
            this.dgvVehicles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVehicles_RowsAdded);
            this.dgvVehicles.SelectionChanged += new System.EventHandler(this.dgvVehicles_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // gbxMaintenance
            // 
            this.gbxMaintenance.Controls.Add(this.btnFindLot);
            this.gbxMaintenance.Controls.Add(this.cbxNeedAnalysis);
            this.gbxMaintenance.Controls.Add(this.txtLotID);
            this.gbxMaintenance.Controls.Add(this.label7);
            this.gbxMaintenance.Controls.Add(this.lstTasksForVehicle);
            this.gbxMaintenance.Controls.Add(this.btnUpdateVehicle);
            this.gbxMaintenance.Controls.Add(this.txtLastCoolingFlush);
            this.gbxMaintenance.Controls.Add(this.label6);
            this.gbxMaintenance.Controls.Add(this.txtTireTreads);
            this.gbxMaintenance.Controls.Add(this.label5);
            this.gbxMaintenance.Controls.Add(this.txtLastAirFilter);
            this.gbxMaintenance.Controls.Add(this.label4);
            this.gbxMaintenance.Controls.Add(this.txtLastBrakeJob);
            this.gbxMaintenance.Controls.Add(this.label3);
            this.gbxMaintenance.Controls.Add(this.txtLastOilChange);
            this.gbxMaintenance.Controls.Add(this.label2);
            this.gbxMaintenance.Controls.Add(this.txtMileage);
            this.gbxMaintenance.Controls.Add(this.label1);
            this.gbxMaintenance.Location = new System.Drawing.Point(12, 286);
            this.gbxMaintenance.Name = "gbxMaintenance";
            this.gbxMaintenance.Size = new System.Drawing.Size(544, 226);
            this.gbxMaintenance.TabIndex = 2;
            this.gbxMaintenance.TabStop = false;
            this.gbxMaintenance.Text = "Check Up";
            // 
            // btnFindLot
            // 
            this.btnFindLot.Location = new System.Drawing.Point(230, 101);
            this.btnFindLot.Name = "btnFindLot";
            this.btnFindLot.Size = new System.Drawing.Size(115, 23);
            this.btnFindLot.TabIndex = 17;
            this.btnFindLot.Text = "Find Lot";
            this.btnFindLot.UseVisualStyleBackColor = true;
            this.btnFindLot.Click += new System.EventHandler(this.btnFindLot_Click);
            // 
            // cbxNeedAnalysis
            // 
            this.cbxNeedAnalysis.AutoSize = true;
            this.cbxNeedAnalysis.Location = new System.Drawing.Point(127, 196);
            this.cbxNeedAnalysis.Name = "cbxNeedAnalysis";
            this.cbxNeedAnalysis.Size = new System.Drawing.Size(96, 17);
            this.cbxNeedAnalysis.TabIndex = 16;
            this.cbxNeedAnalysis.Text = "Need Analysis:";
            this.cbxNeedAnalysis.UseVisualStyleBackColor = true;
            // 
            // txtLotID
            // 
            this.txtLotID.Location = new System.Drawing.Point(124, 170);
            this.txtLotID.Name = "txtLotID";
            this.txtLotID.Size = new System.Drawing.Size(100, 20);
            this.txtLotID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lot ID:";
            // 
            // lstTasksForVehicle
            // 
            this.lstTasksForVehicle.FormattingEnabled = true;
            this.lstTasksForVehicle.Location = new System.Drawing.Point(351, 19);
            this.lstTasksForVehicle.Name = "lstTasksForVehicle";
            this.lstTasksForVehicle.Size = new System.Drawing.Size(187, 186);
            this.lstTasksForVehicle.TabIndex = 13;
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(230, 72);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateVehicle.TabIndex = 12;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // txtLastCoolingFlush
            // 
            this.txtLastCoolingFlush.Location = new System.Drawing.Point(124, 144);
            this.txtLastCoolingFlush.Name = "txtLastCoolingFlush";
            this.txtLastCoolingFlush.Size = new System.Drawing.Size(100, 20);
            this.txtLastCoolingFlush.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Cooling Flush:";
            // 
            // txtTireTreads
            // 
            this.txtTireTreads.Location = new System.Drawing.Point(124, 119);
            this.txtTireTreads.Name = "txtTireTreads";
            this.txtTireTreads.Size = new System.Drawing.Size(100, 20);
            this.txtTireTreads.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tire Treads:";
            // 
            // txtLastAirFilter
            // 
            this.txtLastAirFilter.Location = new System.Drawing.Point(124, 94);
            this.txtLastAirFilter.Name = "txtLastAirFilter";
            this.txtLastAirFilter.Size = new System.Drawing.Size(100, 20);
            this.txtLastAirFilter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Air Filter:";
            // 
            // txtLastBrakeJob
            // 
            this.txtLastBrakeJob.Location = new System.Drawing.Point(124, 69);
            this.txtLastBrakeJob.Name = "txtLastBrakeJob";
            this.txtLastBrakeJob.Size = new System.Drawing.Size(100, 20);
            this.txtLastBrakeJob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Brake Job:";
            // 
            // txtLastOilChange
            // 
            this.txtLastOilChange.Location = new System.Drawing.Point(124, 44);
            this.txtLastOilChange.Name = "txtLastOilChange";
            this.txtLastOilChange.Size = new System.Drawing.Size(100, 20);
            this.txtLastOilChange.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Oil Change:";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(124, 19);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(100, 20);
            this.txtMileage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mileage:";
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 538);
            this.Controls.Add(this.gbxMaintenance);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "frmMaintenance";
            this.Text = "Maintenance Schedule";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbxMaintenance.ResumeLayout(false);
            this.gbxMaintenance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox gbxMaintenance;
        private System.Windows.Forms.TextBox txtLastCoolingFlush;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTireTreads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastAirFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastBrakeJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastOilChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.ListBox lstTasksForVehicle;
        private System.Windows.Forms.TextBox txtLotID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxNeedAnalysis;
        private System.Windows.Forms.Button btnFindLot;
    }
}