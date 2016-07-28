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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //form main is for rentals.  Will be main screen.  
            //With buttons for user form, car form, and(???) lot form.
        }

        private void btnCustomer_Click(object sender, EventArgs e) 
        {
            //This is the maintenance field for customers.  
            new frmCustomer().ShowDialog();
        }

        private void btnCustLook_Click(object sender, EventArgs e)
        {
            //This is the lookup field for customers
            using (var form = new frmCustomer())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string CustID = form.CustID; //CustId is exposed property on customer form. 
                    txtCustID.Text = CustID;
                }
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmCar form = new frmCar();
            form.ShowDialog();
        }

        private void btnLot_Click(object sender, EventArgs e)
        {
            frmLot form = new frmLot();
            form.ShowDialog();
        }
    }
}
