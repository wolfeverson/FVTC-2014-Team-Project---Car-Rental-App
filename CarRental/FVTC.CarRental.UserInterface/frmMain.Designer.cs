namespace FVTC.CarRental.UserInterface
{
    partial class frmMain
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.grpLookup = new System.Windows.Forms.GroupBox();
            this.btnCustLook = new System.Windows.Forms.Button();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.btnCarLook = new System.Windows.Forms.Button();
            this.btnLotLook = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnLot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstTransStatus = new System.Windows.Forms.ComboBox();
            this.grpLookup.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(19, 33);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(136, 23);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer Management";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // grpLookup
            // 
            this.grpLookup.Controls.Add(this.btnLotLook);
            this.grpLookup.Controls.Add(this.btnCarLook);
            this.grpLookup.Controls.Add(this.btnCustLook);
            this.grpLookup.Location = new System.Drawing.Point(577, 12);
            this.grpLookup.Name = "grpLookup";
            this.grpLookup.Size = new System.Drawing.Size(188, 157);
            this.grpLookup.TabIndex = 1;
            this.grpLookup.TabStop = false;
            this.grpLookup.Text = "Lookup/Add";
            // 
            // btnCustLook
            // 
            this.btnCustLook.Location = new System.Drawing.Point(19, 32);
            this.btnCustLook.Name = "btnCustLook";
            this.btnCustLook.Size = new System.Drawing.Size(75, 23);
            this.btnCustLook.TabIndex = 3;
            this.btnCustLook.Text = "Customer";
            this.btnCustLook.UseVisualStyleBackColor = true;
            this.btnCustLook.Click += new System.EventHandler(this.btnCustLook_Click);
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.button1);
            this.grpAdmin.Controls.Add(this.btnLot);
            this.grpAdmin.Controls.Add(this.btnVehicle);
            this.grpAdmin.Controls.Add(this.btnCustomer);
            this.grpAdmin.Location = new System.Drawing.Point(577, 175);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(188, 223);
            this.grpAdmin.TabIndex = 2;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Mainentance/Admin";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(103, 109);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 3;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(246, 109);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(55, 20);
            this.txtCustID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehicle:";
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Location = new System.Drawing.Point(103, 138);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleName.TabIndex = 8;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(246, 137);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(55, 20);
            this.txtVehicleID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(103, 199);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "<Main form for New transactions.  Can also load old ones to finish>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Transaction ID: ";
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(103, 78);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(100, 20);
            this.txtTransID.TabIndex = 16;
            // 
            // grpPricing
            // 
            this.grpPricing.Controls.Add(this.label9);
            this.grpPricing.Location = new System.Drawing.Point(15, 256);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(288, 99);
            this.grpPricing.TabIndex = 17;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "Pricing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "<Transaction Type Dropdown will fill pricing box>";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 414);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(777, 22);
            this.StatusStrip.TabIndex = 18;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // btnCarLook
            // 
            this.btnCarLook.Location = new System.Drawing.Point(19, 69);
            this.btnCarLook.Name = "btnCarLook";
            this.btnCarLook.Size = new System.Drawing.Size(75, 23);
            this.btnCarLook.TabIndex = 4;
            this.btnCarLook.Text = "Vehicle";
            this.btnCarLook.UseVisualStyleBackColor = true;
            // 
            // btnLotLook
            // 
            this.btnLotLook.Location = new System.Drawing.Point(19, 100);
            this.btnLotLook.Name = "btnLotLook";
            this.btnLotLook.Size = new System.Drawing.Size(75, 23);
            this.btnLotLook.TabIndex = 5;
            this.btnLotLook.Text = "Lot";
            this.btnLotLook.UseVisualStyleBackColor = true;
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(19, 71);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(136, 23);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.Text = "Vehicle Management";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnLot
            // 
            this.btnLot.Location = new System.Drawing.Point(19, 111);
            this.btnLot.Name = "btnLot";
            this.btnLot.Size = new System.Drawing.Size(136, 23);
            this.btnLot.TabIndex = 2;
            this.btnLot.Text = "Lot Management";
            this.btnLot.UseVisualStyleBackColor = true;
            this.btnLot.Click += new System.EventHandler(this.btnLot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mainentance";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstTransStatus
            // 
            this.lstTransStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTransStatus.FormattingEnabled = true;
            this.lstTransStatus.Items.AddRange(new object[] {
            "New Rental",
            "Rental Return"});
            this.lstTransStatus.Location = new System.Drawing.Point(103, 229);
            this.lstTransStatus.Name = "lstTransStatus";
            this.lstTransStatus.Size = new System.Drawing.Size(121, 21);
            this.lstTransStatus.TabIndex = 19;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 436);
            this.Controls.Add(this.lstTransStatus);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.grpPricing);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.txtVehicleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.grpLookup);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpLookup.ResumeLayout(false);
            this.grpAdmin.ResumeLayout(false);
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox grpLookup;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.Button btnCustLook;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.GroupBox grpPricing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Button btnLotLook;
        private System.Windows.Forms.Button btnCarLook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLot;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.ComboBox lstTransStatus;
    }
}