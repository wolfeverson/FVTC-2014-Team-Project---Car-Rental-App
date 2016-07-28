using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FVTC.CarRental.BusinessLogic;
using System.Drawing.Printing;

namespace FVTC.CarRental.UserInterface
{
    public partial class frmMain : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");
        //attempt to log to transaction table
        
        CCustomer oCust = new CCustomer();
        CCar oCar = new CCar();
        CRental oRent = new CRental();
        CRentalList oList = new CRentalList();
        CCarList oCarList = new CCarList();
        CCustomerList oCustList = new CCustomerList();
        double perday;
        int freemiles;
        double permile;
        double fuelfee;
        double milefee;
        double dayfee;
        public frmMain()
        {
            InitializeComponent();
        }

        #region lookup 
        private void frmMain_Load(object sender, EventArgs e)
        {
            //form main is for rentals.  Will be main screen.  
            //With buttons for user form, car form, and(???) lot form.
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //This is the maintenance field for customers.  
            new frmCustomer("admin").ShowDialog();
        }

        private void btnCustLook_Click(object sender, EventArgs e)
        {
            //This is the lookup field for customers
            using (var form = new frmCustomer())
            {
                form.ShowDialog();
                oCust = form.PassCust;
                if (oCust != null)
                {
                    txtCustID.Text = oCust.Id.ToString();
                    txtCustName.Text = oCust.Lastname + ", " + oCust.Firstname;
                }
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmVehicle form = new frmVehicle("admin");
            form.ShowDialog();
        }

        private void btnLot_Click(object sender, EventArgs e)
        {
            frmLot form = new frmLot();
            form.ShowDialog();
        }

        //plug in existing id aand click to populate fields & Add print reciept button.
        private void button2_Click(object sender, EventArgs e)
        {
            int traid = int.Parse(txtTransID.Text);
            oList.SelectTransaction();
            oCustList.SelectCustomers();
            oCarList.SelectCars();
            for (int i = 0; i < oList.Count; i ++)
            {
                if (oList[i].Id == traid)
                {
                    if (oList[i].TransactionType == "New Rental")
                    {
                        oRent = oList[i];
                    }
                    else
                    {
                        oRent = null;
                    }
                }
            }
            try
            {
                for (int i = 0; i < oCarList.Count; i++)
                {
                    if (oCarList[i].Id == oRent.Vehicle_Id)
                    {
                        oCar = oCarList[i];
                    }
                }
                for (int i = 0; i < oCustList.Count; i++)
                {
                    if (oCustList[i].Id == oRent.Customer_Id)
                    {
                        oCust = oCustList[i];
                    }
                }
                txtVehicleID.Text = oCar.Id.ToString();
                txtCustID.Text = oCust.Id.ToString();
                txtCustName.Text = oCust.Lastname + ", " + oCust.Firstname;
                txtVehicleName.Text = oCar.Year + " " + oCar.Make + " " + oCar.Model;
                StatusLabel.Text = "";
                lstTransStatus.SelectedIndex = 1; //chooses "return rental"
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Transaction ID not found." + ex.Message;
                txtVehicleID.Text = "";
                txtCustID.Text = "";
                txtCustName.Text = "";
                txtVehicleName.Text = "";
            }

        }
        #endregion
        //Checks in vehicle.  Add transaction current to database.  Log4Net
        private void btnRental_Click(object sender, EventArgs e)
        {
            /*
            Uses app.config added to UI / CHECK TARGET ASSEMBLY! > UI > right click properties > Taget framework .net 4.
           
            log.Warn(prepare);e
            log4net.GlobalContext.Properties["Customer_ID"] = txtCustID.Text;
            log4net.GlobalContext.Properties["Vehicle_ID"] = txtVehicleID.Text;
            log4net.GlobalContext.Properties["TransactionType"] = "New Rental";
            log4net.GlobalContext.Properties["TotalCharge"] = txtTotalFee.Text;
            log4net.LogicalThreadContext.Properties["Customer_ID"] = oCust.Id;

            StatusLabel.Text = "Transaction Logged";
*/

            string prepare = txtCustName.Text + "(" + txtCustID.Text + ") " + "has rented vehicle " + txtVehicleName.Text + "(" + txtVehicleID.Text + ")";
            log.Warn(prepare);
            oCar.NeedAnalysis = true;
            oCar.Lot_id = 0;
            oCar.Update();
            oRent.Customer_Id = oCust.Id;
            oRent.Vehicle_Id = oCar.Id;
            oRent.TransactionType = "Return Rental";
            oRent.TransactionDate = dateStart.Value;
            oRent.ReturnDate = dateFinal.Value;
            oRent.RentalCharge = (decimal)fuelfee;
            oRent.FuelCharge = (decimal)milefee;
            oRent.ExcessMilesCharge = (decimal)dayfee;
            oRent.TotalCharge = (decimal)(fuelfee + milefee + dayfee);
            oRent.Comments = "This customer has returned a vehicle";
            oRent.Insert();
            StatusLabel.Text = "Transaction Logged";


        }

       
       

        // Calculate cost, print receipt.  
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //prints receipt from nearest printer
            //PrintIt();
            oList.SelectTransaction();
            for (int i = 0; i < oList.Count; i++)
            {
                if ((oList[i].Customer_Id == oCust.Id) && (oList[i].Vehicle_Id == oCar.Id))
                {
                    if ((oRent == null) || (oRent.TransactionDate < oList[i].TransactionDate))
                    {
                        oRent = oList[i];
                    }
                }
            }
            
            frmReceipt form = new frmReceipt(oRent.Id, oRent.Customer_Id, oRent.Vehicle_Id, fuelfee, dayfee, milefee, (oCust.Firstname +" "+ oCust.Lastname));
            form.ShowDialog();
        }

        #region extra(non)
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //Handle the printing properties
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;

              //  Font printFont = this.btnInvoke.Font;
                Font printFont = this.btnReturn.Font;
                SolidBrush myBrush = new SolidBrush(Color.Blue);

                //RENTAL TRANSACTION INFO WILL GO IN HERE!
                e.Graphics.DrawString("Transaction Id:  Customer:  Vehicle:",
                                      printFont,
                                      myBrush,
                                      leftMargin,
                                      topMargin,
                                      new StringFormat());

                StatusLabel.Text = "Printing";

                myBrush.Dispose();
                myBrush = null;

            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }

        }

        private void PrintIt()
        {
            PrintDialog oPd = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            // Create the delegate between the PrintPage event and the PrintPage method.
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            // Hook the PrintDocument to the PrintDialog Property
            oPd.Document = printDoc;

            if (oPd.ShowDialog() == DialogResult.OK)
            {
                // This does the printing.
                printDoc.Print();
            }

        }


        //This is the lookup field for customers
        private void btnCarLook_Click(object sender, EventArgs e)
        {
            using (var form = new frmVehicle())
            {
                form.ShowDialog();
                oCar = form.PassCar;
                txtVehicleID.Text = oCar.Id.ToString();
                txtVehicleName.Text = oCar.Year + " " + oCar.Make + " " + oCar.Model;
            }
        }

        //call maintenance form.  
        private void btnMainentance_Click(object sender, EventArgs e)
        {
            frmMaintenance form = new frmMaintenance();
            form.ShowDialog();
        }

        private void btnLotLook_Click(object sender, EventArgs e)
        {
            using (var form = new frmLot())
            {
                form.ShowDialog();
                oCar = form.PassCar;
                if (oCar != null)
                {
                    txtVehicleID.Text = oCar.Id.ToString();
                    txtVehicleName.Text = oCar.Year + " " + oCar.Make + " " + oCar.Model;
                }
            }
        }

        private void lstTransStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oCar == null || oCar.Id <= 0)
            {
                StatusLabel.Text = "Please ensure a car is selected";
            }
            else
            {
                string cat = oCar.Category.ToString();
                switch (cat)
                {
                    case "luxury":
                        freemiles = 120;
                        permile = .05;
                        perday = 65;
                        break;
                    case "sport":
                        freemiles = 100;
                        permile = .04;
                        perday = 60;
                        break;
                    case "full size":
                        freemiles = 130;
                        permile = .04;
                        perday = 50;
                        break;
                    case "mid size":
                        freemiles = 110;
                        permile = .03;
                        perday = 45;
                        break;
                    case "compact":
                        freemiles = 150;
                        permile = .04;
                        perday = 40;
                        break;
                    case "convertable":
                        freemiles = 100;
                        permile = .05;
                        perday = 60;
                        break;
                }
            }


            bool regvalid = true;
            if (oCar.Registrationexpiration < dateFinal.Value)
            {
                regvalid = false;
                StatusLabel.Text = "Car expiration will occur before Rental is complete.";
            }
            if (lstTransStatus.Text == "New Rental" && (regvalid))
            {
                btnNewRental.Visible = true;
                btnRental.Visible = false;
                btnReturn.Visible = false;
                //print demo prices.
                txtTempFreeMiles.Text = freemiles.ToString();
                txtTempPerDay.Text = perday.ToString("C");
                txtTempPerMile.Text = permile.ToString("C");
                grpNew.Visible = true;
                grpFinal.Visible = false;
            }
                else if (lstTransStatus.Text == "Rental Return")
                {
                    btnRental.Visible = true;
                    btnReturn.Visible = true;
                    btnNewRental.Visible = false;
                    grpFinal.Visible = true;
                    grpNew.Visible = false;
                    btnCalculate.Visible = true;
                    StatusLabel.Text = "Fill Blue Fields and Calculate";
                }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //blanks
        }

        private void txtMilesOver_TextChanged(object sender, EventArgs e)
        {
            //blanks
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lstTransStatus.Text == "Rental Return")
            {
                TimeSpan tsdays = dateFinal.Value - dateStart.Value;
                int days = tsdays.Days;
                txtDays.Text = days.ToString();
                dayfee = days * perday;
                txtDaysFee.Text = dayfee.ToString("C");
                fuelfee = double.Parse(txtFuel.Text);
                int milagedif = int.Parse(txtNewMiles.Text) - oCar.Mileage;
                int logmildif = milagedif - (days * freemiles);
                txtMilesOver.Text = logmildif.ToString();
                milefee = logmildif * permile;
                txtMilesFee.Text = milefee.ToString("C");
                double feetotal = milefee + dayfee + fuelfee;
                txtTotalFee.Text = feetotal.ToString("C");
            }
        }

        #endregion
        //this is to check out a car.  Take it away from store.  Log4Net
        private void btnNewRental_Click(object sender, EventArgs e)
        {
            try
            {
               /* 
                log4net.ThreadContext.Properties["Customer_ID"] = oCust.Id;
                log4net.ThreadContext.Properties["Vehicle_ID"] = oCar.Id;
                log4net.LogicalThreadContext.Properties["TransactionType"] = "New Rental";
                log4net.LogicalThreadContext.Properties["TransactionDate"] = dateStart.Value.ToString();
                log4net.LogicalThreadContext.Properties["ReturnDate"] = dateFinal.Value.ToString();
                log4net.LogicalThreadContext.Properties["TotalCharge"] = (fuelfee+dayfee+milefee).ToString();
                log4net.LogicalThreadContext.Properties["Comments"] = "Comments>.>";
                log.Warn("message");
                log4net.GlobalContext.Properties["Customer_ID"] = oCust.Id;
                log4net.GlobalContext.Properties["Vehicle_ID"] = oCar.Id;
                log4net.GlobalContext.Properties["TransactionType"] = "New Rental";
                log4net.GlobalContext.Properties["TransactionDate"] = dateStart.Value.ToString();
                log4net.GlobalContext.Properties["ReturnDate"] = dateFinal.Value.ToString();
                log4net.GlobalContext.Properties["TotalCharge"] = (fuelfee + dayfee + milefee).ToString();
                log4net.GlobalContext.Properties["Comments"] = "Comments>.>";
                log.Warn("message");
                */
                int transrec;
                oCar.NeedAnalysis = true;
                oCar.Lot_id = 0;
                oCar.Update(); 
                oRent.Customer_Id = oCust.Id;
                oRent.Vehicle_Id = oCar.Id;
                oRent.TransactionType = "New Rental";
                oRent.TransactionDate = dateStart.Value;
                oRent.ReturnDate = dateFinal.Value;
                oRent.Comments = "This customer has rented a vehicle";
                oRent.Insert();


                oList.SelectTransaction();
                for (int i = 0; i < oList.Count; i++)
                {
                    if (oList[i] != null)
                    {
                        transrec = oList[i].Id;
                        StatusLabel.Text = "Transaction Logged.  ID is:" + transrec.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //blank
        }
    }
}