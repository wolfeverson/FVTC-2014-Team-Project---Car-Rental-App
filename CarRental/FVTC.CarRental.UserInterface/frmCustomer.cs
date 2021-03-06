﻿using System;
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
    public partial class frmCustomer : Form
    {
        CCustomerList oCustomers = new CCustomerList();
        bool _isFormLoaded = false;

        log4net.ILog log = log4net.LogManager.GetLogger("Utility.Logger");


        public frmCustomer()
        {
            InitializeComponent();
        }

        public string CustID  //Exposed variable for Main form access.  
        {
            get
            {
                return lblCustId.Text;
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            try
            {
                oCustomers.SelectCustomers();
                //oCustomers.GetCustomers();
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = oCustomers.CustomerList;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
            _isFormLoaded = true;
        }

        private void PopulateScreen(CCustomer oCustomer)
        {
            lblCustId.Text = oCustomer.Id.ToString();
            txtFirstName.Text = oCustomer.Firstname;
            txtLastName.Text = oCustomer.Lastname;
            txtAddress.Text = oCustomer.Address;
            txtCity.Text = oCustomer.City;
            txtState.Text = oCustomer.State;
            txtZip.Text = oCustomer.Zip;
            txtPhone.Text = oCustomer.Phone;
            txtEmail.Text = oCustomer.Email;
            txtCompanyName.Text = oCustomer.CompanyName;
            txtCompanyPhone.Text = oCustomer.CompanyPhone;
            txtCreditCard.Text = oCustomer.CreditCard;
            txtLicense.Text = oCustomer.LicenseNumber;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_isFormLoaded)
                {
                    //puts selected cust in textboxes
                    CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];
                    PopulateScreen(oCustomer);
                }
            }
                catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }


        //good
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //CCustomerList oCustomers = new CCustomerList(); We dont want a NEW list! This was the problem!
                oCustomers.SelectCustomersByLastName(txtSearchByLastName.Text);
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = oCustomers.CustomerList;
                CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];
                PopulateScreen(oCustomer);

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void PopulateCustomer(CCustomer oCustomer)
        {
            // oCustomer.Id =  txtAddressField.Text ;
            oCustomer.Firstname = txtFirstName.Text;
            oCustomer.Lastname = txtLastName.Text;
            oCustomer.Phone = txtPhone.Text;
            oCustomer.Zip = txtZip.Text;
            oCustomer.State = txtState.Text;
            oCustomer.City = txtCity.Text;
            oCustomer.CompanyPhone = txtCompanyPhone.Text;
            oCustomer.Email = txtEmail.Text;
            oCustomer.Address = txtAddress.Text;
            oCustomer.CompanyName = txtCompanyName.Text;
            oCustomer.CreditCard = txtCreditCard.Text;
            oCustomer.LicenseNumber = txtLicense.Text;
        }

        private void ClearScreen()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtAddress.Text = null;
            txtCity.Text = null;
            txtState.Text = null;
            txtZip.Text = null;
            txtPhone.Text = null;
            txtEmail.Text = null;
            txtCompanyName.Text = null;
            txtCompanyPhone.Text = null;
            txtCreditCard.Text = null;
            txtLicense.Text = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                CCustomer oCustomer = new CCustomer();
                // oCustomer.Id = txtCustId.Text;
                PopulateCustomer(oCustomer);
                oCustomer.Insert();
                oCustomers.Add(oCustomer);

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = oCustomers.CustomerList;

                lblStatus.Text = "Customer Added";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CCustomer oCustomer = new CCustomer();
                PopulateCustomer(oCustomer);
                oCustomer.Update();
                //refresh
                oCustomers.SelectCustomers();
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = oCustomers.CustomerList;

                lblStatus.Text = "Customer Updated";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Uses app.config added to UI / CHECK TARGET ASSEMBLY! > UI > right click properties > Taget framework .net 4.
                log.Warn(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       


    }
}
