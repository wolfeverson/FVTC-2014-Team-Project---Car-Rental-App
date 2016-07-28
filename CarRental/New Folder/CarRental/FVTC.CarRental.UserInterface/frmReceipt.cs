using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FVTC.CarRental.UserInterface
{
    public partial class frmReceipt : Form
    {
        public frmReceipt(int tranID, int CustID, int VehID, double fuel, double days, double miles, string name)
        {
            InitializeComponent();
            lblCus.Text = CustID.ToString();
            lblVeh.Text = VehID.ToString();
            lbltrans.Text = tranID.ToString();
            lblfuel.Text = fuel.ToString("C");
            lblmile.Text = miles.ToString("C");
            lblrent.Text = days.ToString("C");
            double total = fuel + days + miles;
            lblsub.Text = total.ToString("C");
            double tax = total * .05;
            lblsales.Text = tax.ToString("C");
            double final = total + tax;
            lbltotal.Text = final.ToString("C");
            lblcustname.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //blanks
        }
    }
}
