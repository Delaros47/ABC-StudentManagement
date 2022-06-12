using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IGuidanceCounselorService
    {
        IDataResult<List<GuidanceCounselor>> GetAll();
        IDataResult<GuidanceCounselor> Get(int GuidanceCounselorId);
        IDataResult<List<GuidanceCounselor>> GetGuidanceCounselorActive();
        IDataResult<List<GuidanceCounselor>> GetGuidanceCounselorPassive();
        IDataResult<GuidanceCounselor> GetLastGuidanceCounselorPrivateCode();
        IResult Add(GuidanceCounselor guidanceCounselor);
        IResult Update(GuidanceCounselor guidanceCounselor);
        IResult Delete(GuidanceCounselor guidanceCounselor);
    }
}
