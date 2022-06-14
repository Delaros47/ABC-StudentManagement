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
    public class DocumentManager : IDocumentService
    {

        private readonly IDocumentDal _documentDal;
        public DocumentManager(IDocumentDal documentDal)
        {
            _documentDal = documentDal;
        }

        public IResult Add(Document document)
        {
            _documentDal.Add(document);
            return new SuccessResult(Messages.GetMessage("Document",Process.Add));
        }

        public IResult Delete(Document document)
        {
            _documentDal.Delete(document);
            return new SuccessResult(Messages.GetMessage("Document", Process.Delete));
        }

        public IDataResult<Document> Get(int documentId)
        {
            return new SuccessDataResult<Document>(_documentDal.Get(d=>d.Id==documentId));
        }

        public IDataResult<List<Document>> GetAll()
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetAll());
        }

        public IDataResult<List<Document>> GetDocumentActive()
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetAll(d=>d.State==true));
        }

        public IDataResult<List<Document>> GetDocumentPassive()
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetAll(d => d.State == false));
        }

        public IDataResult<Document> GetLastDocumentPrivateCode()
        {
            return new SuccessDataResult<Document>(_documentDal.GetAll().Last());
        }

        public IResult Update(Document document)
        {
            _documentDal.Update(document);
            return new SuccessResult(Messages.GetMessage("Document", Process.Update));
        }
    }
}
