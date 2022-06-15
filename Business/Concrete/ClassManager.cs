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
    public class ClassManager : IClassService
    {

        private readonly IClassDal _classDal;
        public ClassManager(IClassDal classDal)
        {
            _classDal = classDal;
        }

        public IResult Add(Class classs)
        {
            _classDal.Add(classs);
            return new SuccessResult(Messages.GetMessage("Class",Process.Add));
        }

        public IResult Delete(Class classs)
        {
            _classDal.Delete(classs);
            return new SuccessResult(Messages.GetMessage("Class", Process.Delete));
        }

        public IDataResult<Class> Get(int classId)
        {
            return new SuccessDataResult<Class>(_classDal.Get(c=>c.Id==classId));
        }

        public IDataResult<List<Class>> GetAll()
        {
            return new SuccessDataResult<List<Class>>(_classDal.GetAll());
        }

        public IDataResult<List<Class>> GetClassActive()
        {
            return new SuccessDataResult<List<Class>>(_classDal.GetAll(c=>c.State==true));
        }

        public IDataResult<List<ClassDetailDto>> GetClassDetailDtoActive()
        {
            return new SuccessDataResult<List<ClassDetailDto>>(_classDal.GetClassDetailDto().Where(c => c.State == true).ToList());
        }

        public IDataResult<List<ClassDetailDto>> GetClassDetailDtoPassive()
        {
            return new SuccessDataResult<List<ClassDetailDto>>(_classDal.GetClassDetailDto().Where(c => c.State == false).ToList());
        }

        public IDataResult<List<Class>> GetClassPassive()
        {
            return new SuccessDataResult<List<Class>>(_classDal.GetAll(c => c.State == false));
        }

        public IDataResult<Class> GetLastClassPrivateCode()
        {
            return new SuccessDataResult<Class>(_classDal.GetAll().Last());
        }

        public IResult Update(Class classs)
        {
            _classDal.Update(classs);
            return new SuccessResult(Messages.GetMessage("Class", Process.Update));
        }
    }
}
