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
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IDataResult<Contact> Get(int contactId);
        IDataResult<List<ContactDetailDto>> GetContactDetailDtoActive();
        IDataResult<List<ContactDetailDto>> GetContactDetailDtoPassive();
        IDataResult<Contact> GetLastContactPrivateCode();
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
    }
}
