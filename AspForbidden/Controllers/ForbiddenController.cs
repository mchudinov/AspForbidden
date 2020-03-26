namespace AspForbidden.Controllers
{
    using System.Net.Http;
    public class ForbiddenController : System.Web.Http.ApiController
    {
        // GET: api/Forbidden
        public HttpResponseMessage Get()
        {
            return Request.CreateErrorResponse(System.Net.HttpStatusCode.Forbidden, "This call is not allowed.");
        }
    }
}
