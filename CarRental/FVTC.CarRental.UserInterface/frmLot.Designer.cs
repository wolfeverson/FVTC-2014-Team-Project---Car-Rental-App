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
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radLotA
            // 
            this.radLotA.AutoSize = true;
            this.radLotA.Location = new System.Drawing.Point(12, 12);
            this.radLotA.Name = "radLotA";
            this.radLotA.Size = new System.Drawing.Size(32, 17);
            this.radLotA.TabIndex = 0;
            this.radLotA.TabStop = true;
            this.radLotA.Text = "A";
            this.radLotA.UseVisualStyleBackColor = true;
            this.radLotA.CheckedChanged += new System.EventHandler(this.radLotA_CheckedChanged);
            // 
            // radLotB
            // 
            this.radLotB.AutoSize = true;
            this.radLotB.Location = new System.Drawing.Point(65, 12);
            this.radLotB.Name = "radLotB";
            this.radLotB.Size = new System.Drawing.Size(32, 17);
            this.radLotB.TabIndex = 1;
            this.radLotB.TabStop = true;
            this.radLotB.Text = "B";
            this.radLotB.UseVisualStyleBackColor = true;
            this.radLotB.CheckedChanged += new System.EventHandler(this.radLotB_CheckedChanged);
            // 
            // radLotC
            // 
            this.radLotC.AutoSize = true;
            this.radLotC.Location = new System.Drawing.Point(118, 12);
            this.radLotC.Name = "radLotC";
            this.radLotC.Size = new System.Drawing.Size(32, 17);
            this.radLotC.TabIndex = 2;
            this.radLotC.TabStop = true;
            this.radLotC.Text = "C";
            this.radLotC.UseVisualStyleBackColor = true;
            this.radLotC.CheckedChanged += new System.EventHandler(this.radLotC_CheckedChanged);
            // 
            // radLotD
            // 
            this.radLotD.AutoSize = true;
            this.radLotD.Location = new System.Drawing.Point(171, 12);
            this.radLotD.Name = "radLotD";
            this.radLotD.Size = new System.Drawing.Size(33, 17);
            this.radLotD.TabIndex = 3;
            this.radLotD.TabStop = true;
            this.radLotD.Text = "D";
            this.radLotD.UseVisualStyleBackColor = true;
            this.radLotD.CheckedChanged += new System.EventHandler(this.radLotD_CheckedChanged);
            // 
            // lstLot
            // 
            this.lstLot.FormattingEnabled = true;
            this.lstLot.Location = new System.Drawing.Point(12, 35);
            this.lstLot.Name = "lstLot";
            this.lstLot.Size = new System.Drawing.Size(192, 173);
            this.lstLot.TabIndex = 4;
            this.lstLot.SelectedIndexChanged += new System.EventHandler(this.lstLot_SelectedIndexChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(65, 225);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 288);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lstLot);
            this.Controls.Add(this.radLotD);
            this.Controls.Add(this.radLotC);
            this.Controls.Add(this.radLotB);
            this.Controls.Add(this.radLotA);
            this.Name = "frmLot";
            this.Text = "Lot Viewer";
            this.Load += new System.EventHandler(this.frmLot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radLotA;
        private System.Windows.Forms.RadioButton radLotB;
        private System.Windows.Forms.RadioButton radLotC;
        private System.Windows.Forms.RadioButton radLotD;
        private System.Windows.Forms.ListBox lstLot;
        private System.Windows.Forms.Button btnTest;
    }
}