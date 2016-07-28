using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CCarList
    {
        private List<CCar> oCarList;
        public List<CCar> CarList
        {
            get { return oCarList; }
            set { oCarList = value; }
        }

        public int Count
        {
            get { return oCarList.Count; }
        }

        public void RemoveAt(int index)
        {
            oCarList.RemoveAt(index);
        }

        public CCar this[int index]
        {
            get { return oCarList[index]; }
            set { oCarList[index] = value; }
        }

        public void Add(CCar oCar)
        {
            oCarList.Add(oCar);
        }

        public void SelectCars()
        {
            CarRentalDataContext oDc = new CarRentalDataContext();

            //Select customers using LINQ
            var otblCars = from c in oDc.RentalVehicles select c;
            oCarList = new List<CCar>();

            //Fill our Generic List of Customers
            foreach (RentalVehicle otblCar in otblCars)
            {
                CCar oCar = new CCar();

                //Pass in the LINQ table row to the class and load
                oCar.Load(otblCar);
                oCarList.Add(oCar);
            }
        }

        public void SelectCarsForCheckUp()
        {
            CarRentalDataContext oDc = new CarRentalDataContext();

            //Select customers using LINQ
            var otblCars = from c in oDc.RentalVehicles select c;
            oCarList = new List<CCar>();

            //Fill our Generic List of Customers
            foreach (RentalVehicle otblCar in otblCars)
            {
                CCar oCar = new CCar();

                //Pass in the LINQ table row to the class and load
                oCar.Load(otblCar);

                if (oCar.NeedAnalysis == true)
                {
                    oCarList.Add(oCar);
                }
            }
        }

        public void OccupiedLots()
        {
            CarRentalDataContext odc = new CarRentalDataContext();
            var otblCars = from c in odc.sp_GetOccupiedLots() select c;
            oCarList = new List<CCar>();
            foreach (sp_GetOccupiedLotsResult otblCar in otblCars)
            {
                CCar oCar = new CCar();
                oCar.Load(otblCar);
                oCarList.Add(oCar);
            }
        }
    }
}
