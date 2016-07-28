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
    public partial class frmVehicle : Form
    {
        CCarList oCars = new CCarList();
        //bool _isFormLoaded = false;
        //vehicle search
        public frmVehicle()
        {
            InitializeComponent();
            btnDelete.Visible = false;
            //remove unavailable cars.
            oCars.OccupiedLots();
        }
        //vehicle admin
        public frmVehicle(string admin)
        {
            InitializeComponent();
            btnDelete.Visible = true;
            oCars.SelectCars();
        }
        private void frmVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                datCars.DataSource = null;
                datCars.DataSource = oCars.CarList;
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }
           //_isFormLoaded = true;
        }

        private void PopulateScreen(CCar oCar)
        {
            txtID.Text  = oCar.Id.ToString();
            txtLastBrake.Text=oCar.LastBrakeJob.ToString();
            txtLastFilter.Text = oCar.LastAirFilter.ToString();
            txtLastFlush.Text = oCar.LastCoolingFlush.ToString();
            txtLastOil.Text = oCar.LastOilChange.ToString();
            txtLocationID.Text = oCar.Lot_id.ToString();
            txtMake.Text = oCar.Make;
            txtMileage.Text = oCar.Mileage.ToString();
            txtModel.Text = oCar.Model;
            txtServiceDate.Text = oCar.InService.ToString();
            txtServiceMiles.Text = oCar.InServiceMiles.ToString();
            txtTires.Text = oCar.TireThreads.ToString();
            txtVIN.Text = oCar.Vin;
            txtYear.Text = oCar.Year;
            txtAnalysis.Text = oCar.NeedAnalysis.ToString();
            txtCategory.Text = oCar.Category;
            txtCost.Text = oCar.Cost.ToString("n2");
            txtExpire.Text = oCar.Registrationexpiration.ToString();
        }

        private void New()
        {
            txtLastBrake.Text=null;
            txtLastFilter.Text = null;
            txtLastFlush.Text = null;
            txtLastOil.Text = null;
            txtLocationID.Text = null;
            txtMake.Text = null;
            txtMileage.Text = null;
            txtModel.Text = null;
            txtServiceDate.Text = null;
            txtServiceMiles.Text = null;
            txtTires.Text = null;
            txtVIN.Text = null;
            txtYear.Text = null;
            txtAnalysis.Text = null;
            txtCategory.Text = null;
            txtCost.Text = null;
            txtExpire.Text = null;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void PopulateCar(CCar oCar)
        {
            oCar.Category = txtCategory.Text;
            oCar.Cost = decimal.Parse(txtCost.Text);
            oCar.InService = System.DateTime.Parse(txtServiceDate.Text);
            oCar.InServiceMiles = int.Parse(txtServiceMiles.Text);
            oCar.LastAirFilter = int.Parse(txtLastFilter.Text);
            oCar.LastBrakeJob = int.Parse(txtLastBrake.Text);
            oCar.LastCoolingFlush =  System.DateTime.Parse(txtLastFlush.Text);
            oCar.LastOilChange = int.Parse(txtLastOil.Text);
            oCar.Lot_id = int.Parse(txtLocationID.Text);
            oCar.Make = txtMake.Text;
            oCar.Mileage = int.Parse(txtMileage.Text);
            oCar.Model = txtModel.Text;
            oCar.NeedAnalysis = bool.Parse(txtAnalysis.Text);
            oCar.Registrationexpiration = System.DateTime.Parse(txtExpire.Text);
            oCar.TireThreads = int.Parse(txtTires.Text);
            oCar.Vin = txtVIN.Text;
            oCar.Year = txtYear.Text;
        }
        private void datCars_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //if (_isFormLoaded)
                //{
                    CCar oCar = oCars[datCars.CurrentRow.Index];
                    PopulateScreen(oCar);
                //}
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        //used for main form returning car Id to main form.
        private void lblCarId_TextChanged(object sender, EventArgs e)
        {
            int CarID = int.Parse(txtID.Text);
            for (int i=0; i < oCars.Count; i++)
            {
                CCar oCar = new CCar();
                oCar = oCars[i];
                if (oCar.Id == CarID)
                {
                    PassCar = oCar;
                }
            }
        }
        private CCar _PassCar;
        public CCar PassCar
        {
            get { return _PassCar; }
            set { _PassCar = value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {  
                CCar oCar = oCars[datCars.CurrentRow.Index];
                oCar.Delete();

                oCars.SelectCars();
                datCars.DataSource = null;
                datCars.DataSource = oCars.CarList;

                statusStrip1.Text = "Vehicle Deleted";
            }
            catch (Exception ex)
            {
                statusStrip1.Text = ex.Message;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            New();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                CCar oCar = new CCar();
                PopulateCar(oCar);
                oCar.Insert();
                oCars.Add(oCar);

                datCars.DataSource = null;
                datCars.DataSource = oCars.CarList;

                StatusLabel.Text = "Vehicle Added";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                CCar oCar = new CCar();
                PopulateCar(oCar);
                oCar.Update();
                oCars.SelectCars();
                datCars.DataSource = null;
                datCars.DataSource = oCars.CarList;

                StatusLabel.Text = "Vehicle Updated";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }
        }
    }
}
