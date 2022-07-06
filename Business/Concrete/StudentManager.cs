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
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.GetMessage("Student",Process.Add));
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.GetMessage("Student", Process.Delete));
        }

        public IDataResult<Student> Get(int studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(s=>s.Id==studentId));
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll());
        }

        public IDataResult<Student> GetLastStudentPrivateCode()
        {
            return new SuccessDataResult<Student>(_studentDal.GetAll().Last());
        }

        public IDataResult<List<StudentDetailDto>> GetStudentDetailDtoActive()
        {
            return new SuccessDataResult<List<StudentDetailDto>>(_studentDal.GetStudentDetailDto().Where(s=>s.State==true).ToList());
        }

        public IDataResult<List<StudentDetailDto>> GetStudentDetailDtoPassive()
        {
            return new SuccessDataResult<List<StudentDetailDto>>(_studentDal.GetStudentDetailDto().Where(s => s.State == false).ToList());
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.GetMessage("Student", Process.Update));
        }
    }
}
