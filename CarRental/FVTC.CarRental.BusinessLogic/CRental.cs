using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CRental
    {
        #region Properties
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int customer_id;
        public int Customer_Id
        {
            get { return customer_id; }
            set { customer_id = value; }
        }

        private int vehicle_id;
        public int Vehicle_Id
        {
            get { return vehicle_id; }
            set { vehicle_id = value; }
        }

        private string transactiontype;
        public string TransactionType
        {
            get { return transactiontype; }
            set { transactiontype = value; }
        }

        private DateTime transactiondate;
        public DateTime TransactionDate
        {
            get { return transactiondate; }
            set { transactiondate = value; }
        }

        private decimal rentalcharge;
        public decimal RentalCharge
        {
            get { return rentalcharge; }
            set { rentalcharge = value; }
        }

        private decimal fuelcharge;
        public decimal FuelCharge
        {
            get { return fuelcharge; }
            set { fuelcharge = value; }
        }

        private decimal excessmilescharge;
        public decimal ExcessMilesCharge
        {
            get { return excessmilescharge; }
            set { excessmilescharge = value; }
        }

        private decimal totalcharge;
        public decimal TotalCharge
        {
            get { return totalcharge; }
            set { totalcharge = value; }
        }

        private string comments;
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private bool maintoilchange;
        public bool MaintOilChange
        {
            get { return maintoilchange; }
            set { maintoilchange = value; }
        }

        private bool maintairfilter;
        public bool MaintAirFilter
        {
            get { return maintairfilter; }
            set { maintairfilter = value; }
        }

        private bool maintbrakejob;
        public bool MaintBrakeJob
        {
            get { return maintbrakejob; }
            set { maintbrakejob = value; }
        }

        private bool mainttirechange;
        public bool MaintTireChange
        {
            get { return mainttirechange; }
            set { mainttirechange = value; }
        }
        #endregion

        #region Methods
        public void Insert()
        {
            try
            {
                CarRentalDataContext oDc = new CarRentalDataContext();
                RentalTransaction otblTransaction = new RentalTransaction();

                otblTransaction.TransactionID = Id;
                otblTransaction.Customer_ID = customer_id;
                otblTransaction.Vehicle_ID = vehicle_id;
                otblTransaction.TransactionType = transactiontype;
                otblTransaction.TransactionDate = transactiondate;
                otblTransaction.RentalCharge = rentalcharge;
                otblTransaction.FuelCharge = fuelcharge;
                otblTransaction.ExcessMilesCharge = excessmilescharge;
                otblTransaction.TotalCharge = totalcharge;
                otblTransaction.Comments = comments;
                otblTransaction.MaintOilChange = maintoilchange;
                otblTransaction.MaintAirFilter = maintairfilter;
                otblTransaction.MaintBrakeJob = maintbrakejob;
                otblTransaction.MaintTireChange = mainttirechange;

                oDc.RentalTransactions.InsertOnSubmit(otblTransaction);
                oDc.SubmitChanges();
                oDc = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update()
        {
            int returnValue = 0;
            try
            {
                CarRentalDataContext oDc = new CarRentalDataContext();
                RentalTransaction otblTransaction = (from c in oDc.RentalTransactions
                                                     where c.TransactionID == Id
                                               select c).FirstOrDefault();

                otblTransaction.TransactionID = Id;
                otblTransaction.Customer_ID = customer_id;
                otblTransaction.Vehicle_ID = vehicle_id;
                otblTransaction.TransactionType = transactiontype;
                otblTransaction.TransactionDate = transactiondate;
                otblTransaction.RentalCharge = rentalcharge;
                otblTransaction.FuelCharge = fuelcharge;
                otblTransaction.ExcessMilesCharge = excessmilescharge;
                otblTransaction.TotalCharge = totalcharge;
                otblTransaction.Comments = comments;
                otblTransaction.MaintOilChange = maintoilchange;
                otblTransaction.MaintAirFilter = maintairfilter;
                otblTransaction.MaintBrakeJob = maintbrakejob;
                otblTransaction.MaintTireChange = mainttirechange;

                oDc.SubmitChanges();
                oDc = null;
                returnValue = 1;
                return returnValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete()
        {
            try
            {
                CarRentalDataContext oDc = new CarRentalDataContext();

                RentalTransaction otblTransaction = (from c in oDc.RentalTransactions
                                               where c.TransactionID == Id
                                               select c).FirstOrDefault();

                oDc.RentalTransactions.DeleteOnSubmit(otblTransaction);
                oDc.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load(RentalTransaction otblTransaction)
        {
            try
            {
                Id = otblTransaction.TransactionID;
                customer_id = otblTransaction.Customer_ID;
                vehicle_id = otblTransaction.Vehicle_ID;
                transactiontype = otblTransaction.TransactionType;
                transactiondate = (DateTime)otblTransaction.TransactionDate;
                rentalcharge = (Decimal)otblTransaction.RentalCharge;
                fuelcharge = (Decimal)otblTransaction.FuelCharge;
                excessmilescharge = (Decimal)otblTransaction.ExcessMilesCharge;
                totalcharge = (Decimal)otblTransaction.TotalCharge;
                comments = otblTransaction.Comments;
                maintoilchange = (bool)otblTransaction.MaintOilChange;
                maintairfilter = (bool)otblTransaction.MaintAirFilter;
                maintbrakejob = (bool)otblTransaction.MaintBrakeJob;
                mainttirechange = (bool)otblTransaction.MaintTireChange;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
