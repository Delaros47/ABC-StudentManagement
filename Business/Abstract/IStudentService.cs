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
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> Get(int studentId);
        IDataResult<List<StudentDetailDto>> GetStudentDetailDtoActive();
        IDataResult<List<StudentDetailDto>> GetStudentDetailDtoPassive();
        IDataResult<Student> GetLastStudentPrivateCode();
        IResult Add(Student student);
        IResult Update(Student student);
        IResult Delete(Student student);
    }
}
