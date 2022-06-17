using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ILawyerService
    {
        IDataResult<List<Lawyer>> GetAll();
        IDataResult<Lawyer> Get(int lawyerId);
        IDataResult<Lawyer> GetLastBankPrivateCode();
        IDataResult<List<LawyerDetailDto>> GetLawyerDetailActiveDto();
        IDataResult<List<LawyerDetailDto>> GetLawyerDetailPassiveDto();
        IResult Add(Lawyer lawyer);
        IResult Update(Lawyer lawyer);
        IResult Delete(Lawyer lawyer);
    }
}
