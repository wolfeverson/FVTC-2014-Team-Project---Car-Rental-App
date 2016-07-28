using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CCar
    {
        #region Propoerties
        private int Vehicle_Id;
        public int Id
        {
            get { return Vehicle_Id; }
            set { Vehicle_Id = value; }
        }

        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string category; //(compact, mid-size, full-size, convertible, luxury or sporty)
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string year;
        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private string vin;
        public string Vin
        {
            get { return vin; }
            set { vin = value; }
        }

        private decimal cost;
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private DateTime registrationexpiration;
        public DateTime Registrationexpiration
        {
            get { return registrationexpiration; }
            set { registrationexpiration = value; }
        }

        private int Lot_Id;
        public int Lot_id
        {
            get { return Lot_Id; }
            set { Lot_Id = value; }
        }

        private int mileage;
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        private int lastoilchange;
        public int LastOilChange
        {
            get { return lastoilchange; }
            set { lastoilchange = value; }
        }

        private int lastbrakejob;
        public int LastBrakeJob
        {
            get { return lastbrakejob; }
            set { lastbrakejob = value; }
        }

        private int lastairfilter;
        public int LastAirFilter
        {
            get { return lastairfilter; }
            set { lastairfilter = value; }
        }

        private int tirethreads;
        public int TireThreads
        {
            get { return tirethreads; }
            set { tirethreads = value; }
        }

        private DateTime lastcoolingflush;
        public DateTime LastCoolingFlush
        {
            get { return lastcoolingflush; }
            set { lastcoolingflush = value; }
        }

        private DateTime inservice;
        public DateTime InService
        {
            get { return inservice; }
            set { inservice = value; }
        }

        private int inservicemiles;
        public int InServiceMiles
        {
            get { return inservicemiles; }
            set { inservicemiles = value; }
        }

        private bool needanalysis;
        public bool NeedAnalysis
        {
            get { return needanalysis; }
            set { needanalysis = value; }
        }
        #endregion

        #region Methods
        public void Insert()
        {
            try
            {
                CarRentalDataContext oDc = new CarRentalDataContext();
                RentalVehicle otblVehicle = new RentalVehicle();

                otblVehicle.Vehicle_Id = Vehicle_Id;
                otblVehicle.Make = make;
                otblVehicle.Model = model;
                otblVehicle.Category = category;
                otblVehicle.Year = year;
                otblVehicle.VinNumber = vin;
                otblVehicle.Cost = cost;
                otblVehicle.RegistrationExpiration = registrationexpiration;
                otblVehicle.Location_Id = Lot_Id;
                otblVehicle.Mileage = mileage;
                otblVehicle.LastOilChange = lastoilchange;
                otblVehicle.LastBrakeJob = lastbrakejob;
                otblVehicle.LastAirFilter = lastairfilter;
                otblVehicle.TireTreads = tirethreads;
                otblVehicle.LastCoolingFlush = lastcoolingflush;
                otblVehicle.InService = InService;
                otblVehicle.InServiceMiles = inservicemiles;
                otblVehicle.NeedAnalysis = needanalysis;

                oDc.RentalVehicles.InsertOnSubmit(otblVehicle);
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
                RentalVehicle otblVehicle = (from c in oDc.RentalVehicles
                                             where c.Vehicle_Id == Vehicle_Id
                                               select c).FirstOrDefault();

                otblVehicle.Vehicle_Id = Vehicle_Id;
                otblVehicle.Make = make;
                otblVehicle.Model = model;
                otblVehicle.Category = category;
                otblVehicle.Year = year;
                otblVehicle.VinNumber = vin;
                otblVehicle.Cost = cost;
                otblVehicle.RegistrationExpiration = registrationexpiration;
                otblVehicle.Location_Id = Lot_Id;
                otblVehicle.Mileage = mileage;
                otblVehicle.LastOilChange = lastoilchange;
                otblVehicle.LastBrakeJob = lastbrakejob;
                otblVehicle.LastAirFilter = lastairfilter;
                otblVehicle.TireTreads = tirethreads;
                otblVehicle.LastCoolingFlush = lastcoolingflush;
                otblVehicle.InService = InService;
                otblVehicle.InServiceMiles = inservicemiles;
                otblVehicle.NeedAnalysis = needanalysis;

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

                RentalVehicle otblVehicle = (from c in oDc.RentalVehicles
                                             where c.Vehicle_Id == Vehicle_Id
                                               select c).FirstOrDefault();

                oDc.RentalVehicles.DeleteOnSubmit(otblVehicle);
                oDc.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load(RentalVehicle otblVehicle)
        {
            try
            {
                Vehicle_Id = otblVehicle.Vehicle_Id;
                make = otblVehicle.Make;
                model = otblVehicle.Model;
                category = otblVehicle.Category;
                year = otblVehicle.Year;
                vin = otblVehicle.VinNumber;
                cost = (decimal)otblVehicle.Cost;
                registrationexpiration = (DateTime)otblVehicle.RegistrationExpiration;
                Lot_Id = (int)otblVehicle.Location_Id;
                mileage = otblVehicle.Mileage;
                lastoilchange = (int)otblVehicle.LastOilChange;
                lastbrakejob = (int)otblVehicle.LastBrakeJob;
                lastairfilter = (int)otblVehicle.LastAirFilter;
                tirethreads = (int)otblVehicle.TireTreads;
                lastcoolingflush = (DateTime)otblVehicle.LastCoolingFlush;
                InService = (DateTime)otblVehicle.InService;
                inservicemiles = (int)otblVehicle.InServiceMiles;
                needanalysis = (bool)otblVehicle.NeedAnalysis;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load(sp_GetOccupiedLotsResult otblVehicle)
        {
            try
            {
                Vehicle_Id = otblVehicle.Vehicle_Id;
                make = otblVehicle.Make;
                model = otblVehicle.Model;
                category = otblVehicle.Category;
                year = otblVehicle.Year;
                vin = otblVehicle.VinNumber;
                cost = (decimal)otblVehicle.Cost;
                registrationexpiration = (DateTime)otblVehicle.RegistrationExpiration;
                Lot_Id = (int)otblVehicle.Location_Id;
                mileage = otblVehicle.Mileage;
                lastoilchange = (int)otblVehicle.LastOilChange;
                lastbrakejob = (int)otblVehicle.LastBrakeJob;
                lastairfilter = (int)otblVehicle.LastAirFilter;
                tirethreads = (int)otblVehicle.TireTreads;
                lastcoolingflush = (DateTime)otblVehicle.LastCoolingFlush;
                InService = (DateTime)otblVehicle.InService;
                inservicemiles = (int)otblVehicle.InServiceMiles;
                needanalysis = (bool)otblVehicle.NeedAnalysis;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
