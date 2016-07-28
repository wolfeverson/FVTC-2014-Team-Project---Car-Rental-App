using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FVTC.CarRental.Data;

namespace FVTC.CarRental.BusinessLogic
{
    public class CLot
    {
        #region Properties
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string row;
        public string Row
        {
            get { return row; }
            set { row = value; }
        }

        private int slot;
        public int Slot
        {
            get { return slot; }
            set { slot = value; }
        }
        #endregion

        #region Methods
        public void Insert()
        {
            try
            {
                CarRentalDataContext oDc = new CarRentalDataContext();
                RentalLot otblLot = new RentalLot();

                otblLot.Location_Id = Id;
                otblLot.Location_Row = Row;
                otblLot.Location_Slot = Slot;

                oDc.RentalLots.InsertOnSubmit(otblLot);
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
                RentalLot otblLot = (from c in oDc.RentalLots
                                               where c.Location_Id == Id
                                               select c).FirstOrDefault();

                otblLot.Location_Id = Id;
                otblLot.Location_Row = Row;
                otblLot.Location_Slot = Slot;

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

                RentalLot otblLot = (from c in oDc.RentalLots
                                          where c.Location_Id == Id
                                          select c).FirstOrDefault();

                oDc.RentalLots.DeleteOnSubmit(otblLot);
                oDc.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load(RentalLot otblLot)
        {
            try
            {
                Id = otblLot.Location_Id;
                Row = otblLot.Location_Row;
                Slot = otblLot.Location_Slot;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load(sp_GetLotByRowResult otblLots)
        {
            try
            {
                this.Id = otblLots.Location_Id;
                this.Row = otblLots.Location_Row;
                this.Slot = otblLots.Location_Slot;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion
    
    }
}
