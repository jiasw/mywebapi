using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace MvcApiDemo.Base
{
    public class CustomFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {

            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
        }
    }
}