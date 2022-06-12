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
    public class GuidanceCounselorManager : IGuidanceCounselorService
    {
        private readonly IGuidanceCounselorDal _guidanceCounselorDal;
        public GuidanceCounselorManager(IGuidanceCounselorDal guidanceCounselorDal)
        {
            _guidanceCounselorDal = guidanceCounselorDal;
        }

        public IResult Add(GuidanceCounselor guidanceCounselor)
        {
            _guidanceCounselorDal.Add(guidanceCounselor);
            return new SuccessResult(Messages.GetMessage("Guidance Counselor",Process.Add));
        }

        public IResult Delete(GuidanceCounselor guidanceCounselor)
        {
            _guidanceCounselorDal.Delete(guidanceCounselor);
            return new SuccessResult(Messages.GetMessage("Guidance Counselor", Process.Delete));
        }

        public IDataResult<GuidanceCounselor> Get(int GuidanceCounselorId)
        {
            return new SuccessDataResult<GuidanceCounselor>(_guidanceCounselorDal.Get(g=>g.Id==GuidanceCounselorId));
        }

        public IDataResult<List<GuidanceCounselor>> GetAll()
        {
            return new SuccessDataResult<List<GuidanceCounselor>>(_guidanceCounselorDal.GetAll());
        }

        public IDataResult<List<GuidanceCounselor>> GetGuidanceCounselorActive()
        {
            return new SuccessDataResult<List<GuidanceCounselor>>(_guidanceCounselorDal.GetAll(g=>g.State==true));
        }

        public IDataResult<List<GuidanceCounselor>> GetGuidanceCounselorPassive()
        {
            return new SuccessDataResult<List<GuidanceCounselor>>(_guidanceCounselorDal.GetAll(g => g.State == false));
        }

        public IDataResult<GuidanceCounselor> GetLastGuidanceCounselorPrivateCode()
        {
            return new SuccessDataResult<GuidanceCounselor>(_guidanceCounselorDal.GetAll().Last());
        }

        public IResult Update(GuidanceCounselor guidanceCounselor)
        {
            _guidanceCounselorDal.Update(guidanceCounselor);
            return new SuccessResult(Messages.GetMessage("Guidance Counselor", Process.Update));
        }
    }
}
