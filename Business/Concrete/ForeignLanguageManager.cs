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
    public class ForeignLanguageManager : IForeignLanguageService
    {
        private readonly IForeignLanguageDal _foreignLanguageDal;
        public ForeignLanguageManager(IForeignLanguageDal foreignLanguageDal)
        {
            _foreignLanguageDal = foreignLanguageDal;
        }

        public IResult Add(ForeignLanguage foreignLanguage)
        {
            _foreignLanguageDal.Add(foreignLanguage);
            return new SuccessResult(Messages.GetMessage("Foreign Language",Process.Add));
        }

        public IResult Delete(ForeignLanguage foreignLanguage)
        {
            _foreignLanguageDal.Delete(foreignLanguage);
            return new SuccessResult(Messages.GetMessage("Foreign Language", Process.Delete));
        }

        public IDataResult<ForeignLanguage> Get(int foreignLanguageId)
        {
            return new SuccessDataResult<ForeignLanguage>(_foreignLanguageDal.Get(f=>f.Id==foreignLanguageId));
        }

        public IDataResult<List<ForeignLanguage>> GetAll()
        {
            return new SuccessDataResult<List<ForeignLanguage>>(_foreignLanguageDal.GetAll());
        }

        public IDataResult<List<ForeignLanguage>> GetforeignLanguageActive()
        {
            return new SuccessDataResult<List<ForeignLanguage>>(_foreignLanguageDal.GetAll(f=>f.State==true));
        }

        public IDataResult<List<ForeignLanguage>> GetforeignLanguagePassive()
        {
            return new SuccessDataResult<List<ForeignLanguage>>(_foreignLanguageDal.GetAll(f => f.State == false));
        }

        public IDataResult<ForeignLanguage> GetLastforeignLanguagePrivateCode()
        {
            return new SuccessDataResult<ForeignLanguage>(_foreignLanguageDal.GetAll().Last());
        }

        public IResult Update(ForeignLanguage foreignLanguage)
        {
            _foreignLanguageDal.Update(foreignLanguage);
            return new SuccessResult(Messages.GetMessage("Foreign Language", Process.Update));
        }
    }
}
