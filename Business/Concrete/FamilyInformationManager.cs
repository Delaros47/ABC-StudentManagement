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
    public class FamilyInformationManager : IFamilyInformationService
    {
        private readonly IFamilyInformationDal _familyInformationDal;
        public FamilyInformationManager(IFamilyInformationDal familyInformationDal)
        {
            _familyInformationDal = familyInformationDal;
        }

        public IResult Add(FamilyInformation familyInformation)
        {
            _familyInformationDal.Add(familyInformation);
            return new SuccessResult(Messages.GetMessage("Family Information",Process.Add));
        }

        public IResult Delete(FamilyInformation familyInformation)
        {
            _familyInformationDal.Delete(familyInformation);
            return new SuccessResult(Messages.GetMessage("Family Information", Process.Delete));
        }

        public IDataResult<FamilyInformation> Get(int familyInformationId)
        {
            return new SuccessDataResult<FamilyInformation>(_familyInformationDal.Get(f=>f.Id==familyInformationId));
        }

        public IDataResult<List<FamilyInformation>> GetAll()
        {
            return new SuccessDataResult<List<FamilyInformation>>(_familyInformationDal.GetAll());
        }

        public IDataResult<List<FamilyInformation>> GetFamilyInformationActive()
        {
            return new SuccessDataResult<List<FamilyInformation>>(_familyInformationDal.GetAll(f=>f.State==true));
        }

        public IDataResult<List<FamilyInformation>> GetFamilyInformationPassive()
        {
            return new SuccessDataResult<List<FamilyInformation>>(_familyInformationDal.GetAll(f => f.State == false));
        }

        public IDataResult<FamilyInformation> GetLastFamilyInformationPrivateCode()
        {
            return new SuccessDataResult<FamilyInformation>(_familyInformationDal.GetAll().Last());
        }

        public IResult Update(FamilyInformation familyInformation)
        {
            _familyInformationDal.Update(familyInformation);
            return new SuccessResult(Messages.GetMessage("Family Information", Process.Update));
        }
    }
}
