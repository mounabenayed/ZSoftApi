using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Repositories;
using System.Web.Http;

namespace ZSoftApi.Controllers
{
    [RoutePrefix("api/user")]

    public class UserController : ApiController
    {
        private readonly IUserRepository _userIRepository;

        public UserController()
        {
            this._userIRepository = new UserRepository() ;
        }
        [Route("{email}")]
        public IHttpActionResult GetUserInfo(string email)
        {
            try
            {
                var userInfo = this._userIRepository.GetUserInfo(email);
                return Ok(userInfo);

            }
            catch
            {
                return NotFound();
            }
        }


        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
