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
    public partial class frmMaintenance : Form
    {
        CCar oCar;
        CCarList oCarList;
        CLot oLot;

        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            //On form Load, grab all vehicles that needs an analysis
            try
            {
                GetVehicles();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        #region Data Grid View
        private void dgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oCar = new CCar();
                oCar = oCarList[dgvVehicles.CurrentRow.Index];
                PopulateScreen(oCar);
                GetTasks(oCar);
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void dgvVehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvColumns();
        }

        private void dgvColumns()
        {
            // Hide some of the columns.
            this.dgvVehicles.Columns["Id"].Visible = false;
            this.dgvVehicles.Columns["Make"].Visible = true;
            this.dgvVehicles.Columns["Model"].Visible = true;
            this.dgvVehicles.Columns["Category"].Visible = true;
            this.dgvVehicles.Columns["Year"].Visible = true;
            this.dgvVehicles.Columns["Vin"].Visible = false;
            this.dgvVehicles.Columns["Cost"].Visible = false;
            this.dgvVehicles.Columns["Registrationexpiration"].Visible = false;
            this.dgvVehicles.Columns["Lot_id"].Visible = false;
            this.dgvVehicles.Columns["Mileage"].Visible = true;
            this.dgvVehicles.Columns["LastOilChange"].Visible = false;
            this.dgvVehicles.Columns["LastBrakeJob"].Visible = false;
            this.dgvVehicles.Columns["LastAirFilter"].Visible = false;
            this.dgvVehicles.Columns["TireThreads"].Visible = false;
            this.dgvVehicles.Columns["LastCoolingFlush"].Visible = false;
            this.dgvVehicles.Columns["InService"].Visible = false;
            this.dgvVehicles.Columns["InServiceMiles"].Visible = false;
            this.dgvVehicles.Columns["NeedAnalysis"].Visible = false;
        }
        #endregion

        private void GetVehicles()
        {
            try
            {
                oCar = new CCar();
                oCarList = new CCarList();

                //Select all cars from database
                oCarList.SelectCarsForCheckUp();
                
                //Bind to DataGrid
                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = oCarList.CarList;
                //dgvColumns();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void PopulateScreen(CCar oCar)
        {
            //Maintenance Needs
            txtMileage.Text = oCar.Mileage.ToString();
            txtLastBrakeJob.Text = oCar.LastBrakeJob.ToString();
            txtLastAirFilter.Text = oCar.LastAirFilter.ToString();
            txtLastCoolingFlush.Text = oCar.LastCoolingFlush.ToString("MM/dd/yyyy");
            txtLastOilChange.Text = oCar.LastOilChange.ToString();
            txtTireTreads.Text = oCar.TireThreads.ToString();
            txtLotID.Text = oCar.Lot_id.ToString();
            cbxNeedAnalysis.Checked = oCar.NeedAnalysis;
        }

        private void GetTasks(CCar oCar)
        {
            try
            {
                //Clear List Box before placing tasks in it.
                lstTasksForVehicle.Items.Clear();
                lstTasksForVehicle.Items.Add("Your Tasks are:");

                //Variables for calculating tasks
                int intMileage = int.Parse(txtMileage.Text);
                int intOilChange = int.Parse(txtLastOilChange.Text);
                int intBrakes = int.Parse(txtLastBrakeJob.Text);
                int intAirFilter = int.Parse(txtLastAirFilter.Text);
                int intTireTreads = int.Parse(txtTireTreads.Text);
                int OilChange = int.Parse(txtLastOilChange.Text);
                DateTime dtCoolingFlush = DateTime.Parse(txtLastCoolingFlush.Text);
                TimeSpan tsTimeSinceLastFlush;
               // int intOneYear = 31557600;                                //This didn't do anything?  
                int intResults = 0;

                //Oil Change
                intResults = intMileage - intOilChange;
                if (intResults > 5000)
                {
                    lstTasksForVehicle.Items.Add("Change Oil");
                }

                //Brake Job
                intResults = intMileage - intBrakes;
                if (intResults > 40000)
                {
                    lstTasksForVehicle.Items.Add("Change Brakes");
                }

                //Air Filter
                intResults = intMileage - intAirFilter;
                if (intResults > 20000)
                {
                    lstTasksForVehicle.Items.Add("Change Air Filter");
                }

                //Tire Treads
                if (intTireTreads < 5)
                {
                    lstTasksForVehicle.Items.Add("Change Tires");
                }

                //Cooling Flush
                tsTimeSinceLastFlush = DateTime.Now - dtCoolingFlush;
                if (tsTimeSinceLastFlush.Days > 360)
                {
                    lstTasksForVehicle.Items.Add("Flush Coolant");
                }

                lstTasksForVehicle.Items.Add("Vacuum Interior");
                lstTasksForVehicle.Items.Add("Wash Exterior");
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                oCar = new CCar();
                oCar = oCarList[dgvVehicles.CurrentRow.Index];
                PopulateCar(oCar);
                oCar.Update();
                GetVehicles();
                lblStatus.Text = "Vehicle Updated";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnFindLot_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new frmLot())
            {
                form.ShowDialog();
                oLot = form.PassLot;
                if (oLot != null)
                {
                    txtLotID.Text = oLot.Id.ToString();
                }
            }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void PopulateCar(CCar oCar)
        {
            oCar.LastAirFilter = int.Parse(txtLastAirFilter.Text);
            oCar.LastBrakeJob = int.Parse(txtLastBrakeJob.Text);
            oCar.LastCoolingFlush = System.DateTime.Parse(txtLastCoolingFlush.Text);
            oCar.LastOilChange = int.Parse(txtLastOilChange.Text);
            oCar.Mileage = int.Parse(txtMileage.Text);
            oCar.TireThreads = int.Parse(txtTireTreads.Text);
            oCar.NeedAnalysis = cbxNeedAnalysis.Checked;
            oCar.Lot_id = int.Parse(txtLotID.Text);
        }



        
    }
}
