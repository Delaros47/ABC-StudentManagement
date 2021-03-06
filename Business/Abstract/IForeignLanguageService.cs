using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IForeignLanguageService
    {
        IDataResult<List<ForeignLanguage>> GetAll();
        IDataResult<ForeignLanguage> Get(int foreignLanguageId);
        IDataResult<List<ForeignLanguage>> GetForeignLanguageActive();
        IDataResult<List<ForeignLanguage>> GetForeignLanguagePassive();
        IDataResult<ForeignLanguage> GetLastForeignLanguagePrivateCode();
        IResult Add(ForeignLanguage foreignLanguage);
        IResult Update(ForeignLanguage foreignLanguage);
        IResult Delete(ForeignLanguage foreignLanguage);
    }
}
