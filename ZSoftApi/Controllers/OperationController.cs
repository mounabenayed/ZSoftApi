using DataLayer.Interfaces;
using DataLayer.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace ZSoftApi.Controllers
{
    [RoutePrefix("api/Operation")]

    public class OperationController : ApiController
    {
        private readonly IOperationRepository _operationIRepository;
        public OperationController()
        {
            this._operationIRepository = new OperationRepository();
        }
        // GET: api/Operation
        [Route("{accountNumber}")]
        public IHttpActionResult GetOperationsByAccount(string accountNumber)
        {
            try
            {
                var operations = this._operationIRepository.GetOperationByAccount(accountNumber);
                return Ok(operations);

            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/Operation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Operation
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Operation/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Operation/5
        public void Delete(int id)
        {
        }
    }
}
