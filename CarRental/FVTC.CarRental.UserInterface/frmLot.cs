using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FVTC.CarRental.BusinessLogic;

namespace FVTC.CarRental.UserInterface
{
    public partial class frmLot : Form
    {
        //Global Variable for objects
        CLot oLot;
        CLotList oLotList;

        CCar oCar;
        CCarList oCarList;

        string SelectedLot;

        public frmLot()
        {
            InitializeComponent();
        }

        private void frmLot_Load(object sender, EventArgs e)
        {
            List<RadioButton> myRadios = new List<RadioButton>();

            myRadios.Add(radLotA);
            myRadios.Add(radLotB);
            myRadios.Add(radLotC);
            myRadios.Add(radLotD);

        }

        private void GetVehicles(string myLot)
        {
            oCar = new CCar();
            oCarList = new CCarList();


        }

        private void GetLot()
        {
            oLotList = new CLotList();
            oLot = new CLot();

            oLotList.SelectLots();

            for (int iCount = 0; iCount < oLotList.Count; iCount++)
            {
                oLot = oLotList[iCount];

                if (oLot.Row == SelectedLot)
                {
                    //Code to check that i'm getting right lot
                    lstLot.Items.Add(oLot.Id);
                    
                    //grab lot.id and add vehicle with matching lot.id

                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Clear lstbox
            lstLot.Items.Clear();

            GetLot();
        }

        private void radLotA_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotA.Text;

            //Clear lstbox
            lstLot.Items.Clear();
            GetLot();
        }

        private void radLotB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotB.Text;

            //Clear lstbox
            lstLot.Items.Clear();
            GetLot();
        }

        private void radLotC_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotC.Text;

            //Clear lstbox
            lstLot.Items.Clear();
            GetLot();
        }

        private void radLotD_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotD.Text;

            //Clear lstbox
            lstLot.Items.Clear();
            GetLot();
        }

        private void lstLot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
