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
    public class ContactParentManager : IContactParentService
    {
        private readonly IContactParentDal _contactParentDal;
        public ContactParentManager(IContactParentDal contactParentDal)
        {
            _contactParentDal = contactParentDal;
        }

        public IResult Add(ContactParent contactParent)
        {
            _contactParentDal.Add(contactParent);
            return new SuccessResult(Messages.GetMessage("Contact Parent",Process.Add));
        }

        public IResult Delete(ContactParent contactParent)
        {
            _contactParentDal.Delete(contactParent);
            return new SuccessResult(Messages.GetMessage("Contact Parent", Process.Delete));
        }

        public IDataResult<List<ContactParent>> GetAll()
        {
            return new SuccessDataResult<List<ContactParent>>(_contactParentDal.GetAll());
        }

        public IDataResult<ContactParent> GetById(int contactParentId)
        {
            return new SuccessDataResult<ContactParent>(_contactParentDal.Get(x=>x.ContactParentId==contactParentId));
        }

        public IDataResult<List<ContactParentDetailDto>> GetContactParentDetailDtoActive()
        {
            return new SuccessDataResult<List<ContactParentDetailDto>>(_contactParentDal.GetContactDetailDto().Where(c=>c.State==true).ToList());
        }

        public IDataResult<List<ContactParentDetailDto>> GetContactParentDetailDtoPassive()
        {
            return new SuccessDataResult<List<ContactParentDetailDto>>(_contactParentDal.GetContactDetailDto().Where(c => c.State == false).ToList());
        }

        public IDataResult<ContactParent> GetLastContactParentPrivateCode()
        {
            return new SuccessDataResult<ContactParent>(_contactParentDal.GetAll().Last());
        }

        public IResult Update(ContactParent contactParent)
        {
            _contactParentDal.Update(contactParent);
            return new SuccessResult(Messages.GetMessage("Contact Parent", Process.Update));
        }
    }
}
