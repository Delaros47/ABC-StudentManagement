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
    public class SpecialCodeManager : ISpecialCodeService
    {
        private readonly ISpecialCodeDal _specialCodeDal;
        public SpecialCodeManager(ISpecialCodeDal specialCodeDal)
        {
            _specialCodeDal = specialCodeDal;
        }

        public IResult Add(SpecialCode specialCode)
        {
            _specialCodeDal.Add(specialCode);
            return new SuccessResult(Messages.GetMessage("Special Code",Process.Add));
        }

        public IResult Delete(SpecialCode specialCode)
        {
            _specialCodeDal.Delete(specialCode);
            return new SuccessResult(Messages.GetMessage("Special Code", Process.Delete));
        }

        public IDataResult<SpecialCode> Get(int specialCodeId)
        {
            return new SuccessDataResult<SpecialCode>(_specialCodeDal.Get(s=>s.Id==specialCodeId));
        }

        public IDataResult<List<SpecialCode>> GetAll()
        {
            return new SuccessDataResult<List<SpecialCode>>(_specialCodeDal.GetAll());
        }

        public IDataResult<SpecialCode> GetLastSpecialCodePrivateCode()
        {
            return new SuccessDataResult<SpecialCode>(_specialCodeDal.GetAll().Last());
        }

        public IResult Update(SpecialCode specialCode)
        {
            _specialCodeDal.Update(specialCode);
            return new SuccessResult(Messages.GetMessage("Special Code", Process.Update));
        }
    }
}
