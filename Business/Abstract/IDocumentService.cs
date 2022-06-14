using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        IDataResult<List<Document>> GetAll();
        IDataResult<Document> Get(int documentId);
        IDataResult<List<Document>> GetDocumentActive();
        IDataResult<List<Document>> GetDocumentPassive();
        IDataResult<Document> GetLastDocumentPrivateCode();
        IResult Add(Document document);
        IResult Update(Document document);
        IResult Delete(Document document);
    }
}
