using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CCustomerList
    {
        private List<CCustomer> oCustomerList;
        public List<CCustomer> CustomerList
        {
            get { return oCustomerList; }
            set { oCustomerList = value; }
        }

        public int Count
        {
            get { return oCustomerList.Count; }
        }

        public void RemoveAt(int index)
        {
            oCustomerList.RemoveAt(index);
        }

        public CCustomer this[int index]
        {
            get { return oCustomerList[index]; }
            set { oCustomerList[index] = value; }
        }

        public void Add(CCustomer oCustomer)
        {
            oCustomerList.Add(oCustomer);
        }

        public void SelectCustomers()
        {
            CarRentalDataContext oDc = new CarRentalDataContext();

            //Select customers using LINQ
            var otblCustomers = from c in oDc.RentalCustomers select c;
            oCustomerList = new List<CCustomer>();

            //Fill our Generic List of Customers
            foreach (RentalCustomer otblCustomer in otblCustomers)
            {
                CCustomer oCustomer = new CCustomer();

                //Pass in the LINQ table row to the class and load
                oCustomer.Load(otblCustomer);
                oCustomerList.Add(oCustomer);
            }
        }


        public List<CCustomer> GetCustomers()
        {
            CarRentalDataContext oDc = new CarRentalDataContext();

            //select customers select * in LINQ
            var otblCustomers = from c in oDc.RentalCustomers select c;
            oCustomerList = new List<CCustomer>();

            //fill generic list
            foreach (RentalCustomer otblCustomer in otblCustomers)
            {
                //pass in LINQ tblrow to class and populate
                CCustomer oCustomer = new CCustomer();
                oCustomer.Load(otblCustomer);
                oCustomerList.Add(oCustomer);

            }
            return oCustomerList;
        }



        public void SelectCustomersByLastName(string lastname)
        {
            try
            {
                //context of database
                CarRentalDataContext oDc = new CarRentalDataContext();

                //select customers select * in LINQ
                var otblCustomers = from c in oDc.sp_GetCustomerByLastName(lastname)
                                    select c;

                oCustomerList = new List<CCustomer>();

                //fill generic list of customers from CUSTOMER column of table

                foreach (sp_GetCustomerByLastNameResult otblCustomer in otblCustomers)
                {
                    //pass in LINQ tblrow to class and populate
                    CCustomer oCustomer = new CCustomer();
                    oCustomer.Load(otblCustomer);
                    oCustomerList.Add(oCustomer);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

       
    }
}
