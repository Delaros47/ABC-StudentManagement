using Business.Abstract;
using Business.Contants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult(Messages.GetMessage("Contact",Process.Add));
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult(Messages.GetMessage("Contact", Process.Delete));
        }

        public IDataResult<Contact> Get(int contactId)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(c=>c.Id==contactId));
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }

        public IDataResult<List<ContactDetailDto>> GetContactDetailDtoActive()
        {
            return new SuccessDataResult<List<ContactDetailDto>>(_contactDal.GetContactDetailDto().Where(c=>c.State==true).ToList());
        }

        public IDataResult<List<ContactDetailDto>> GetContactDetailDtoPassive()
        {
            return new SuccessDataResult<List<ContactDetailDto>>(_contactDal.GetContactDetailDto().Where(c => c.State == false).ToList());
        }

        public IDataResult<Contact> GetLastContactPrivateCode()
        {
            return new SuccessDataResult<Contact>(_contactDal.GetAll().Last());
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult(Messages.GetMessage("Contact", Process.Update));
        }
    }
}
