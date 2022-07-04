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
    public interface IContactParentService
    {
        IDataResult<List<ContactParent>> GetAll();
        IDataResult<ContactParent> GetById(int contactParentId);
        IDataResult<List<ContactParentDetailDto>> GetContactParentDetailDtoActive();
        IDataResult<List<ContactParentDetailDto>> GetContactParentDetailDtoPassive();
        IDataResult<ContactParent> GetLastContactParentPrivateCode();
        IResult Add(ContactParent contactParent);
        IResult Update(ContactParent contactParent);
        IResult Delete(ContactParent contactParent);
    }
}
