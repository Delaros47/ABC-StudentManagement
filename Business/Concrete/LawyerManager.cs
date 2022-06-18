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
    public class LawyerManager : ILawyerService
    {
        private readonly ILawyerDal _lawyerDal;
        public LawyerManager(ILawyerDal lawyerDal)
        {
            _lawyerDal = lawyerDal;
        }

        public IResult Add(Lawyer lawyer)
        {
            _lawyerDal.Add(lawyer);
            return new SuccessResult(Messages.GetMessage("Lawyer", Process.Add));
        }

        public IResult Delete(Lawyer lawyer)
        {
            _lawyerDal.Delete(lawyer);
            return new SuccessResult(Messages.GetMessage("Lawyer", Process.Delete));
        }

        public IDataResult<Lawyer> Get(int lawyerId)
        {
            return new SuccessDataResult<Lawyer>(_lawyerDal.Get(l => l.Id == lawyerId));
        }

        public IDataResult<List<Lawyer>> GetAll()
        {
            return new SuccessDataResult<List<Lawyer>>(_lawyerDal.GetAll());
        }

        public IDataResult<Lawyer> GetLastBankPrivateCode()
        {
            return new SuccessDataResult<Lawyer>(_lawyerDal.GetAll().Last());
        }

        public IDataResult<List<LawyerDetailDto>> GetLawyerDetailActiveDto()
        {
            return new SuccessDataResult<List<LawyerDetailDto>>(_lawyerDal.GetLawyerDetailDto().Where(l => l.State == true).ToList());
        }

        public IDataResult<List<LawyerDetailDto>> GetLawyerDetailPassiveDto()
        {
            return new SuccessDataResult<List<LawyerDetailDto>>(_lawyerDal.GetLawyerDetailDto().Where(l => l.State == false).ToList());
        }

        public IResult Update(Lawyer lawyer)
        {
            _lawyerDal.Update(lawyer);
            return new SuccessResult(Messages.GetMessage("Lawyer", Process.Update));
        }
    }
}
