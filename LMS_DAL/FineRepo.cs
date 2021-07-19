using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;

namespace LMS_DAL
{
    public class FineRepo
    {
        LMSDbContext db;
        public FineRepo()
        {
            db = new LMSDbContext();
        }

        public BaseViewModel SaveFineInDB(Fine fine)
        {
            try
            {
                db.fines.Add(fine);
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, data = null, message = "Fine Added Successfully." };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, message = ex.Message, data = null };
            }
           
        }

        public BaseViewModel DeleteFineValueFromDB(int fineId)
        {
            try
            {
                var fineRecord = db.fines.Where(f => f.id == fineId).FirstOrDefault();
                db.fines.Remove(fineRecord);
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, message = "Fine Deleted Successfully.", data = null };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, message = ex.Message, data = null };
            }
        }

        public BaseViewModel UpdateFineRecordInDB(Fine fine)
        {
            try
            {
                var record = db.fines.Where(f => f.id == fine.id).FirstOrDefault();
                record.id = fine.id;
                record.fine = fine.fine;
                db.SaveChanges();
                return new BaseViewModel() { isSuccess = true, data = null, message = "Record Updated Successfully," };
                
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, message = ex.Message, data = null };
            }
        }

        public BaseViewModel GetAllFineListFromDB()
        {
            try
            {
                return new BaseViewModel() { isSuccess = true, data = db.fines.ToList(), message = "Data Retrieved Successfully" };
            }
            catch (Exception ex)
            {
                return new BaseViewModel() { isSuccess = false, message = ex.Message, data = null };
            }
        }
    }
}
