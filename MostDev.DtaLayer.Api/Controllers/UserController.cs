#region ...   [Header]   ...

// Solution      ::    MostDev.DataLayer
// Filename      ::    MostDev.DataLayer.Api.ValuesController.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;
using System.Web.Http;
using MostDev.DataLayer.Models.Interfaces;

#endregion

namespace MostDev.DataLayer.Api.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        [Route("")]
        public IEnumerable<IUserModel> Get()
        {
            using (var service = new UserService())
            {
                return service.GetAllItems();

                // return new[] {"value1", "value2"};
            }
        }

        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("search/byname/{term}")]
        [HttpGet]
        public IEnumerable<IUserModel> SearchUserByName(string term)
        {
            using (var service = new UserService())
            {
                return service.GetAllItems();

                // return new[] {"value1", "value2"};
            }
        }

        [Route("search/bylastaccessed/{term}")]
        [HttpGet]
        public IEnumerable<IUserModel> SearchUserBylastAccessed(string term)
        {
            using (var service = new UserService())
            {
                return service.GetAllItems();

                // return new[] {"value1", "value2"};
            }
        }
    }
}