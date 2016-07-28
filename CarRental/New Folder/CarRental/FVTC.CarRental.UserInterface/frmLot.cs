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

        #region RadioButtons
        private void radLotA_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotA.Text;
            GetLot();
        }

        private void radLotB_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotB.Text;
            GetLot();
        }

        private void radLotC_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotC.Text;
            GetLot();
        }

        private void radLotD_CheckedChanged(object sender, EventArgs e)
        {
            SelectedLot = radLotD.Text;
            GetLot();
        }
        #endregion

        private CCar GetVehicle(int _SelectedSlot)
        {
            try
            {
                oCar = new CCar();
                oCarList = new CCarList();

                //Get List of Cars
                oCarList.SelectCars();

                for (int iCount = 0; iCount < oCarList.Count; iCount++)
                {
                    oCar = oCarList[iCount];
                    if (oCar.Lot_id == _SelectedSlot)
                    {
                        break;
                    }
                    else
                    {
                        oCar = null;
                    }
                }
                return oCar;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                return null;
            }
        }

        private void GetLot()
        {
            try
            {
                oLotList = new CLotList();
                oLot = new CLot();

                oLotList.SelectLotsbyRow(SelectedLot);

                lstLot.DataSource = null;
                lstLot.DataSource = oLotList.LotList;
                lstLot.DisplayMember = "Id";
                lstLot.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void PopulateScreen(CCar _Car)
        {
            if (_Car != null)
            {
                txtId.Text = _Car.Id.ToString();
                txtMake.Text = _Car.Make;
                txtModel.Text = _Car.Model;
                txtYear.Text = _Car.Year;
            }
            else
            {
                txtId.Text = string.Empty;
                txtMake.Text = string.Empty;
                txtModel.Text = string.Empty;
                txtYear.Text = string.Empty;
            }
        }

        private CCar _PassCar;
        public CCar PassCar
        {
            get { return _PassCar; }
            set { _PassCar = value; }
        }

        private CLot _PassLot;
        public CLot PassLot
        {
            get { return _PassLot; }
            set { _PassLot = value; }
        }

        private void lstLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //New Car Instances
                oCar = new CCar();
                oLot = new CLot();
                oLotList = new CLotList();

                if (lstLot.SelectedItem != null)
                {
                    oLot = (CLot)lstLot.SelectedItem;
                }

                oCar = GetVehicle(oLot.Id);
                PopulateScreen(oCar);

                //variables to pass id back to other forms
                PassCar = oCar;
                PassLot = oLot;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }
    }
}
