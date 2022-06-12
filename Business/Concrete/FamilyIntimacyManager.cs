using Business.Abstract;
using Business.Contants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class FamilyIntimacyManager : IFamilyIntimacyService
    {
        private readonly IFamilyIntimacyDal _familyIntimacyDal;
        public FamilyIntimacyManager(IFamilyIntimacyDal familyIntimacyDal)
        {
            _familyIntimacyDal = familyIntimacyDal;
        }

        public IResult Add(FamilyIntimacy familyIntimacy)
        {
            _familyIntimacyDal.Add(familyIntimacy);
            return new SuccessResult(Messages.GetMessage("Family Intimacy",Process.Add));
        }

        public IResult Delete(FamilyIntimacy familyIntimacy)
        {
            _familyIntimacyDal.Delete(familyIntimacy);
            return new SuccessResult(Messages.GetMessage("Family Intimacy", Process.Delete));
        }

        public IDataResult<FamilyIntimacy> Get(int familyIntimacyId)
        {
            return new SuccessDataResult<FamilyIntimacy>(_familyIntimacyDal.Get(f=>f.Id==familyIntimacyId));
        }

        public IDataResult<List<FamilyIntimacy>> GetAll()
        {
            return new SuccessDataResult<List<FamilyIntimacy>>(_familyIntimacyDal.GetAll());
        }

        public IDataResult<List<FamilyIntimacy>> GetFamilyIntimacyActive()
        {
            return new SuccessDataResult<List<FamilyIntimacy>>(_familyIntimacyDal.GetAll(f=>f.State==true));
        }

        public IDataResult<List<FamilyIntimacy>> GetFamilyIntimacyPassive()
        {
            return new SuccessDataResult<List<FamilyIntimacy>>(_familyIntimacyDal.GetAll(f => f.State == false));
        }

        public IDataResult<FamilyIntimacy> GetLastFamilyIntimacyPrivateCode()
        {
            return new SuccessDataResult<FamilyIntimacy>(_familyIntimacyDal.GetAll().Last());
        }

        public IResult Update(FamilyIntimacy familyIntimacy)
        {
            _familyIntimacyDal.Update(familyIntimacy);
            return new SuccessResult(Messages.GetMessage("Family Intimacy", Process.Update));
        }
    }
}
