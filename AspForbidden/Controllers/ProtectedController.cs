using System.Collections.Generic;
using System.Web.Http;

namespace AspForbidden.Controllers
{
    public class ProtectedController : ApiController
    {
        // GET: api/Protected
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
