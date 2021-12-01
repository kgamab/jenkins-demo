using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using JenkinsTryOut.Controllers;

namespace JenkinsTryOut.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JenkinsTryOutControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
