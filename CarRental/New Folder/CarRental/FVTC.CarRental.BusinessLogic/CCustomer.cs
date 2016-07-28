using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CCustomer
    {
        #region Properties
            private int id;
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            private string firstname;
            public string Firstname
            {
                get { return firstname; }
                set { firstname = value; }
            }

            private string lastname;
            public string Lastname
            {
                get { return lastname; }
                set { lastname = value; }
            }

            private string address;
            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            private string city;
            public string City
            {
                get { return city; }
                set { city = value; }
            }

            private string state;
            public string State
            {
                get { return state; }
                set { state = value; }
            }

            private string zip;
            public string Zip
            {
                get { return zip; }
                set { zip = value; }
            }

            private string phone;
            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            private string companyname;
            public string CompanyName
            {
                get { return companyname; }
                set { companyname = value; }
            }

            private string companyphone;
            public string CompanyPhone
            {
                get { return companyphone; }
                set { companyphone = value; }
            }

            private string email;
            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            private string licensenumber;
            public string LicenseNumber
            {
                get { return licensenumber; }
                set { licensenumber = value; }
            }

            private string creditcard;
            public string CreditCard
            {
                get { return creditcard; }
                set { creditcard = value; }
            }

            private bool donotrent;

            public bool DoNotRent
            {
                get { return donotrent; }
                set { donotrent = value; }
            }
        #endregion

        #region Methods
            public void Insert()
            {
                try
                {
                    CarRentalDataContext oDc = new CarRentalDataContext();
                    RentalCustomer otblCustomer = new RentalCustomer();

                    otblCustomer.Customer_Id = Id;
                    otblCustomer.FirstName = Firstname;
                    otblCustomer.LastName = Lastname;
                    otblCustomer.Address = Address;
                    otblCustomer.City = City;
                    otblCustomer.State = State;
                    otblCustomer.Zip = Zip;
                    otblCustomer.Phone = Phone;
                    otblCustomer.CompanyName = CompanyName;
                    otblCustomer.CompanyPhone = CompanyPhone;
                    otblCustomer.Email = Email;
                    otblCustomer.LicenseNumber = LicenseNumber;
                    otblCustomer.CreditCard = CreditCard;
                    otblCustomer.DoNotRent = DoNotRent;

                    oDc.RentalCustomers.InsertOnSubmit(otblCustomer);
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
                    RentalCustomer otblCustomer = (from c in oDc.RentalCustomers
                                                   where c.Customer_Id == Id
                                                    select c).FirstOrDefault();

                    otblCustomer.Customer_Id = Id;
                    otblCustomer.FirstName = Firstname;
                    otblCustomer.LastName = Lastname;
                    otblCustomer.Address = Address;
                    otblCustomer.City = City;
                    otblCustomer.State = State;
                    otblCustomer.Zip = Zip;
                    otblCustomer.Phone = Phone;
                    otblCustomer.CompanyName = CompanyName;
                    otblCustomer.CompanyPhone = CompanyPhone;
                    otblCustomer.Email = Email;
                    otblCustomer.LicenseNumber = LicenseNumber;
                    otblCustomer.CreditCard = CreditCard;
                    otblCustomer.DoNotRent = DoNotRent;

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

                    RentalCustomer otblCustomer = (from c in oDc.RentalCustomers
                                                   where c.Customer_Id == Id
                                                   select c).FirstOrDefault();

                    oDc.RentalCustomers.DeleteOnSubmit(otblCustomer);
                    oDc.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void Load(RentalCustomer otblCustomer)
            {
                try
                {
                    Id = otblCustomer.Customer_Id;
                    Firstname = otblCustomer.FirstName;
                    Lastname = otblCustomer.LastName;
                    Address = otblCustomer.Address;
                    City = otblCustomer.City;
                    State = otblCustomer.State;
                    Zip = otblCustomer.Zip;
                    Phone = otblCustomer.Phone;

                    if (otblCustomer.CompanyName == DBNull.Value.ToString())
                    {
                        companyname = "";
                    }
                    else
                    {
                        CompanyName = otblCustomer.CompanyName;
                    }


                    CompanyName = otblCustomer.CompanyName;
                    CompanyPhone = otblCustomer.CompanyPhone;
                    Email = otblCustomer.Email;                    
                    LicenseNumber = otblCustomer.LicenseNumber;
                    CreditCard = otblCustomer.CreditCard;
                    DoNotRent = (bool)otblCustomer.DoNotRent;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        //load customers by last name search
        public void Load(sp_GetCustomerByLastNameResult otblCustomer)
            {
                try
                {
                    Id = otblCustomer.Customer_Id;
                    Firstname = otblCustomer.FirstName;
                    Lastname = otblCustomer.LastName;
                    Address = otblCustomer.Address;
                    City = otblCustomer.City;
                    State = otblCustomer.State;
                    Zip = otblCustomer.Zip;
                    Phone = otblCustomer.Phone;
                    CompanyName = otblCustomer.CompanyName;
                    CompanyPhone = otblCustomer.CompanyPhone;
                    Email = otblCustomer.Email;
                    LicenseNumber = otblCustomer.LicenseNumber;
                    CreditCard = otblCustomer.CreditCard;
                    DoNotRent = (bool)otblCustomer.DoNotRent;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }



        #endregion
    }
}
