namespace FVTC.CarRental.UserInterface
{
    partial class frmLot
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
            this.radLotA = new System.Windows.Forms.RadioButton();
            this.radLotB = new System.Windows.Forms.RadioButton();
            this.radLotC = new System.Windows.Forms.RadioButton();
            this.radLotD = new System.Windows.Forms.RadioButton();
            this.lstLot = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radLotA
            // 
            this.radLotA.AutoSize = true;
            this.radLotA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLotA.Location = new System.Drawing.Point(12, 9);
            this.radLotA.Name = "radLotA";
            this.radLotA.Size = new System.Drawing.Size(35, 20);
            this.radLotA.TabIndex = 0;
            this.radLotA.TabStop = true;
            this.radLotA.Text = "A";
            this.radLotA.UseVisualStyleBackColor = true;
            this.radLotA.CheckedChanged += new System.EventHandler(this.radLotA_CheckedChanged);
            // 
            // radLotB
            // 
            this.radLotB.AutoSize = true;
            this.radLotB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLotB.Location = new System.Drawing.Point(64, 9);
            this.radLotB.Name = "radLotB";
            this.radLotB.Size = new System.Drawing.Size(35, 20);
            this.radLotB.TabIndex = 1;
            this.radLotB.TabStop = true;
            this.radLotB.Text = "B";
            this.radLotB.UseVisualStyleBackColor = true;
            this.radLotB.CheckedChanged += new System.EventHandler(this.radLotB_CheckedChanged);
            // 
            // radLotC
            // 
            this.radLotC.AutoSize = true;
            this.radLotC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLotC.Location = new System.Drawing.Point(116, 9);
            this.radLotC.Name = "radLotC";
            this.radLotC.Size = new System.Drawing.Size(35, 20);
            this.radLotC.TabIndex = 2;
            this.radLotC.TabStop = true;
            this.radLotC.Text = "C";
            this.radLotC.UseVisualStyleBackColor = true;
            this.radLotC.CheckedChanged += new System.EventHandler(this.radLotC_CheckedChanged);
            // 
            // radLotD
            // 
            this.radLotD.AutoSize = true;
            this.radLotD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLotD.Location = new System.Drawing.Point(168, 9);
            this.radLotD.Name = "radLotD";
            this.radLotD.Size = new System.Drawing.Size(36, 20);
            this.radLotD.TabIndex = 3;
            this.radLotD.TabStop = true;
            this.radLotD.Text = "D";
            this.radLotD.UseVisualStyleBackColor = true;
            this.radLotD.CheckedChanged += new System.EventHandler(this.radLotD_CheckedChanged);
            // 
            // lstLot
            // 
            this.lstLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLot.FormattingEnabled = true;
            this.lstLot.ItemHeight = 16;
            this.lstLot.Location = new System.Drawing.Point(12, 35);
            this.lstLot.Name = "lstLot";
            this.lstLot.Size = new System.Drawing.Size(192, 164);
            this.lstLot.TabIndex = 4;
            this.lstLot.SelectedIndexChanged += new System.EventHandler(this.lstLot_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 221);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(424, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(285, 61);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(126, 26);
            this.txtYear.TabIndex = 8;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(285, 87);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(126, 26);
            this.txtMake.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Make";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(285, 113);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(126, 26);
            this.txtModel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Model";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(285, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(126, 26);
            this.txtId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // frmLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 243);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstLot);
            this.Controls.Add(this.radLotD);
            this.Controls.Add(this.radLotC);
            this.Controls.Add(this.radLotB);
            this.Controls.Add(this.radLotA);
            this.Name = "frmLot";
            this.Text = "Lot Viewer";
            this.Load += new System.EventHandler(this.frmLot_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radLotA;
        private System.Windows.Forms.RadioButton radLotB;
        private System.Windows.Forms.RadioButton radLotC;
        private System.Windows.Forms.RadioButton radLotD;
        private System.Windows.Forms.ListBox lstLot;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
    }
}