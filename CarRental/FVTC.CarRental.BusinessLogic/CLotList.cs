using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CLotList
    {
        private List<CLot> oLotList;
        public List<CLot> LotList
        {
            get { return oLotList; }
            set { oLotList = value; }
        }

        public int Count
        {
            get { return oLotList.Count; }
        }

        public void RemoveAt(int index)
        {
            oLotList.RemoveAt(index);
        }

        public CLot this[int index]
        {
            get { return oLotList[index]; }
            set { oLotList[index] = value; }
        }

        public void Add(CLot oLot)
        {
            oLotList.Add(oLot);
        }

        public void SelectLots()
        {
            CarRentalDataContext oDc = new CarRentalDataContext();

            //Select customers using LINQ
            var otblLots = from c in oDc.RentalLots select c;
            oLotList = new List<CLot>();

            //Fill our Generic List of Customers
            foreach (RentalLot otblLot in otblLots)
            {
                CLot oLot = new CLot();

                //Pass in the LINQ table row to the class and load
                oLot.Load(otblLot);
                oLotList.Add(oLot);
            }
        }
    }
}
