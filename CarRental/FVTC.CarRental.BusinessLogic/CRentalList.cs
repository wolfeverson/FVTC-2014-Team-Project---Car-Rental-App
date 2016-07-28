using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CRentalList
    {
        private List<CRental> oRentalList;
        public List<CRental> RentalList
        {
            get { return oRentalList; }
            set { oRentalList = value; }
        }

        public int Count
        {
            get { return oRentalList.Count; }
        }

        public void RemoveAt(int index)
        {
            oRentalList.RemoveAt(index);
        }

        public CRental this[int index]
        {
            get { return oRentalList[index]; }
            set { oRentalList[index] = value; }
        }

        public void Add(CRental oRental)
        {
            oRentalList.Add(oRental);
        }

        public void SelectCustomers()
        {
            CarRentalDataContext oDc = new CarRentalDataContext();

            //Select customers using LINQ
            var otblRentals = from c in oDc.RentalTransactions select c;
            oRentalList = new List<CRental>();

            //Fill our Generic List of Customers
            foreach (RentalTransaction otblRental in otblRentals)
            {
                CRental oRental = new CRental();

                //Pass in the LINQ table row to the class and load
                oRental.Load(otblRental);
                oRentalList.Add(oRental);
            }
        }
    }
}
