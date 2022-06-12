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
    public class ClassGroupManager : IClassGroupService
    {
        private readonly IClassGroupDal _classGroupDal;
        public ClassGroupManager(IClassGroupDal classGroupDal)
        {
            _classGroupDal = classGroupDal;
        }

        public IResult Add(ClassGroup classGroup)
        {
            _classGroupDal.Add(classGroup);
            return new SuccessResult(Messages.GetMessage("Class Group",Process.Add));
        }

        public IResult Delete(ClassGroup classGroup)
        {
            _classGroupDal.Delete(classGroup);
            return new SuccessResult(Messages.GetMessage("Class Group", Process.Delete));
        }

        public IDataResult<ClassGroup> Get(int classGroupId)
        {
            return new SuccessDataResult<ClassGroup>(_classGroupDal.Get(c=>c.Id==classGroupId));
        }

        public IDataResult<List<ClassGroup>> GetAll()
        {
            return new SuccessDataResult<List<ClassGroup>>(_classGroupDal.GetAll());
        }

        public IDataResult<List<ClassGroup>> GetClassGroupActive()
        {
            return new SuccessDataResult<List<ClassGroup>>(_classGroupDal.GetAll(c=>c.State==true));
        }

        public IDataResult<List<ClassGroup>> GetClassGroupPassive()
        {
            return new SuccessDataResult<List<ClassGroup>>(_classGroupDal.GetAll(c => c.State == false));
        }

        public IDataResult<ClassGroup> GetLastClassGroupPrivateCode()
        {
            return new SuccessDataResult<ClassGroup>(_classGroupDal.GetAll().Last());
        }

        public IResult Update(ClassGroup classGroup)
        {
            _classGroupDal.Update(classGroup);
            return new SuccessResult(Messages.GetMessage("Class Group", Process.Update));
        }
    }
}
