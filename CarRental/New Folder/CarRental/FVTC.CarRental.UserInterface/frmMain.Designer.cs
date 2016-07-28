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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCustomer = new System.Windows.Forms.Button();
            this.grpLookup = new System.Windows.Forms.GroupBox();
            this.btnLotLook = new System.Windows.Forms.Button();
            this.btnCarLook = new System.Windows.Forms.Button();
            this.btnCustLook = new System.Windows.Forms.Button();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.btnMainentance = new System.Windows.Forms.Button();
            this.btnLot = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.txtTempPerMile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTempFreeMiles = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTempPerDay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstTransStatus = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.grpFinal = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.txtMilesOver = new System.Windows.Forms.TextBox();
            this.txtMilesFee = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtNewMiles = new System.Windows.Forms.TextBox();
            this.txtDaysFee = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLookup.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            this.grpNew.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.grpFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.grpLookup.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            // btnLotLook
            // 
            this.btnLotLook.Location = new System.Drawing.Point(19, 100);
            this.btnLotLook.Name = "btnLotLook";
            this.btnLotLook.Size = new System.Drawing.Size(75, 23);
            this.btnLotLook.TabIndex = 5;
            this.btnLotLook.Text = "Lot";
            this.btnLotLook.UseVisualStyleBackColor = true;
            this.btnLotLook.Click += new System.EventHandler(this.btnLotLook_Click);
            // 
            // btnCarLook
            // 
            this.btnCarLook.Location = new System.Drawing.Point(19, 69);
            this.btnCarLook.Name = "btnCarLook";
            this.btnCarLook.Size = new System.Drawing.Size(75, 23);
            this.btnCarLook.TabIndex = 4;
            this.btnCarLook.Text = "Vehicle";
            this.btnCarLook.UseVisualStyleBackColor = true;
            this.btnCarLook.Click += new System.EventHandler(this.btnCarLook_Click);
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
            this.grpAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpAdmin.Controls.Add(this.btnMainentance);
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
            // btnMainentance
            // 
            this.btnMainentance.Location = new System.Drawing.Point(19, 157);
            this.btnMainentance.Name = "btnMainentance";
            this.btnMainentance.Size = new System.Drawing.Size(136, 23);
            this.btnMainentance.TabIndex = 3;
            this.btnMainentance.Text = "Mainentance";
            this.btnMainentance.UseVisualStyleBackColor = true;
            this.btnMainentance.Click += new System.EventHandler(this.btnMainentance_Click);
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
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(103, 109);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(207, 20);
            this.txtCustName.TabIndex = 3;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(353, 109);
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
            this.label2.Location = new System.Drawing.Point(316, 112);
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
            this.txtVehicleName.Size = new System.Drawing.Size(207, 20);
            this.txtVehicleName.TabIndex = 8;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(353, 137);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(55, 20);
            this.txtVehicleID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 141);
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
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(103, 169);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 12;
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(103, 199);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(200, 20);
            this.dateFinal.TabIndex = 13;
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
            // grpNew
            // 
            this.grpNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpNew.Controls.Add(this.txtTempPerMile);
            this.grpNew.Controls.Add(this.label10);
            this.grpNew.Controls.Add(this.txtTempFreeMiles);
            this.grpNew.Controls.Add(this.label9);
            this.grpNew.Controls.Add(this.txtTempPerDay);
            this.grpNew.Controls.Add(this.label7);
            this.grpNew.Location = new System.Drawing.Point(19, 256);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(397, 99);
            this.grpNew.TabIndex = 17;
            this.grpNew.TabStop = false;
            this.grpNew.Text = "Pricing";
            this.grpNew.Visible = false;
            // 
            // txtTempPerMile
            // 
            this.txtTempPerMile.Location = new System.Drawing.Point(338, 23);
            this.txtTempPerMile.Name = "txtTempPerMile";
            this.txtTempPerMile.ReadOnly = true;
            this.txtTempPerMile.Size = new System.Drawing.Size(48, 20);
            this.txtTempPerMile.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Per Mile(Over)";
            // 
            // txtTempFreeMiles
            // 
            this.txtTempFreeMiles.Location = new System.Drawing.Point(194, 22);
            this.txtTempFreeMiles.Name = "txtTempFreeMiles";
            this.txtTempFreeMiles.ReadOnly = true;
            this.txtTempFreeMiles.Size = new System.Drawing.Size(46, 20);
            this.txtTempFreeMiles.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Miles/Day";
            // 
            // txtTempPerDay
            // 
            this.txtTempPerDay.Location = new System.Drawing.Point(61, 22);
            this.txtTempPerDay.Name = "txtTempPerDay";
            this.txtTempPerDay.ReadOnly = true;
            this.txtTempPerDay.Size = new System.Drawing.Size(43, 20);
            this.txtTempPerDay.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Per Day:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 401);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(788, 22);
            this.StatusStrip.TabIndex = 18;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(208, 17);
            this.StatusLabel.Text = "Error Messages Will be Displayed here.";
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
            this.lstTransStatus.SelectedIndexChanged += new System.EventHandler(this.lstTransStatus_SelectedIndexChanged);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(258, 76);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 23);
            this.btnCheckIn.TabIndex = 20;
            this.btnCheckIn.Text = "Check-In(Fill Data from ID)";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(152, 361);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(149, 23);
            this.btnRental.TabIndex = 21;
            this.btnRental.Text = "Complete Rental Check-out";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Visible = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(307, 361);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 23);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Print Receipt";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNewRental
            // 
            this.btnNewRental.Location = new System.Drawing.Point(39, 361);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(107, 23);
            this.btnNewRental.TabIndex = 23;
            this.btnNewRental.Text = "Start New Rental";
            this.btnNewRental.UseVisualStyleBackColor = true;
            this.btnNewRental.Visible = false;
            this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
            // 
            // grpFinal
            // 
            this.grpFinal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpFinal.Controls.Add(this.label19);
            this.grpFinal.Controls.Add(this.label18);
            this.grpFinal.Controls.Add(this.label17);
            this.grpFinal.Controls.Add(this.label16);
            this.grpFinal.Controls.Add(this.label11);
            this.grpFinal.Controls.Add(this.label15);
            this.grpFinal.Controls.Add(this.label14);
            this.grpFinal.Controls.Add(this.txtTotalFee);
            this.grpFinal.Controls.Add(this.txtMilesOver);
            this.grpFinal.Controls.Add(this.txtMilesFee);
            this.grpFinal.Controls.Add(this.txtFuel);
            this.grpFinal.Controls.Add(this.txtNewMiles);
            this.grpFinal.Controls.Add(this.txtDaysFee);
            this.grpFinal.Controls.Add(this.txtDays);
            this.grpFinal.Location = new System.Drawing.Point(19, 256);
            this.grpFinal.Name = "grpFinal";
            this.grpFinal.Size = new System.Drawing.Size(397, 99);
            this.grpFinal.TabIndex = 24;
            this.grpFinal.TabStop = false;
            this.grpFinal.Text = "Pricing";
            this.grpFinal.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(256, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Total Cost   $    ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(126, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Mileage   $  ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Days $   ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(211, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Total Miles Over";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Current Mileage";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(205, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Fuel Charge";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Days:";
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFee.Location = new System.Drawing.Point(338, 72);
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.ReadOnly = true;
            this.txtTotalFee.Size = new System.Drawing.Size(48, 13);
            this.txtTotalFee.TabIndex = 5;
            this.txtTotalFee.TextChanged += new System.EventHandler(this.txtMilesOver_TextChanged);
            // 
            // txtMilesOver
            // 
            this.txtMilesOver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMilesOver.Location = new System.Drawing.Point(308, 47);
            this.txtMilesOver.Name = "txtMilesOver";
            this.txtMilesOver.ReadOnly = true;
            this.txtMilesOver.Size = new System.Drawing.Size(48, 13);
            this.txtMilesOver.TabIndex = 5;
            this.txtMilesOver.TextChanged += new System.EventHandler(this.txtMilesOver_TextChanged);
            // 
            // txtMilesFee
            // 
            this.txtMilesFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMilesFee.Location = new System.Drawing.Point(194, 72);
            this.txtMilesFee.Name = "txtMilesFee";
            this.txtMilesFee.ReadOnly = true;
            this.txtMilesFee.Size = new System.Drawing.Size(46, 13);
            this.txtMilesFee.TabIndex = 3;
            // 
            // txtFuel
            // 
            this.txtFuel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuel.Location = new System.Drawing.Point(300, 18);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(46, 20);
            this.txtFuel.TabIndex = 3;
            // 
            // txtNewMiles
            // 
            this.txtNewMiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNewMiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewMiles.Location = new System.Drawing.Point(110, 19);
            this.txtNewMiles.Name = "txtNewMiles";
            this.txtNewMiles.Size = new System.Drawing.Size(46, 20);
            this.txtNewMiles.TabIndex = 3;
            // 
            // txtDaysFee
            // 
            this.txtDaysFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDaysFee.Location = new System.Drawing.Point(61, 72);
            this.txtDaysFee.Name = "txtDaysFee";
            this.txtDaysFee.ReadOnly = true;
            this.txtDaysFee.Size = new System.Drawing.Size(43, 13);
            this.txtDaysFee.TabIndex = 1;
            // 
            // txtDays
            // 
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDays.Location = new System.Drawing.Point(82, 48);
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(43, 13);
            this.txtDays.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(231, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 23);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(788, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpFinal);
            this.Controls.Add(this.btnNewRental);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lstTransStatus);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.grpNew);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.dateStart);
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
            this.Text = "Cheap\'s Car Rental";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpLookup.ResumeLayout(false);
            this.grpAdmin.ResumeLayout(false);
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.grpFinal.ResumeLayout(false);
            this.grpFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.GroupBox grpNew;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Button btnLotLook;
        private System.Windows.Forms.Button btnCarLook;
        private System.Windows.Forms.Button btnMainentance;
        private System.Windows.Forms.Button btnLot;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.ComboBox lstTransStatus;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempPerMile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTempFreeMiles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTempPerDay;
        private System.Windows.Forms.GroupBox grpFinal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMilesOver;
        private System.Windows.Forms.TextBox txtMilesFee;
        private System.Windows.Forms.TextBox txtNewMiles;
        private System.Windows.Forms.TextBox txtDaysFee;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}