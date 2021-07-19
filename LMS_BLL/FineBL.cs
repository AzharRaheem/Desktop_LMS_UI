using LMS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DomainModel;
using LMS_DomainModel.ViewModels;

namespace LMS_BLL
{
    public class FineBL
    {
        FineRepo fineRepo;
        public FineBL()
        {
            fineRepo = new FineRepo();
        }

        public BaseViewModel SaveFine(Fine fine)
        {
            return fineRepo.SaveFineInDB(fine);
        }

        public BaseViewModel GetAllFinesList()
        {
            return fineRepo.GetAllFineListFromDB();
        }

        public BaseViewModel DeleteFineValue(int fineId)
        {
            return fineRepo.DeleteFineValueFromDB(fineId);
        }

        public BaseViewModel UpdateFineRecord(Fine fine)
        {
            return fineRepo.UpdateFineRecordInDB(fine);
        }
    }
}
