﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
namespace MvcApiDemo.Base
{
    public class CustomAuthAttribute: AuthorizeAttribute {
        private bool localAllowed;
        public CustomAuthAttribute(bool allowedParam) {
            localAllowed = allowedParam;
        }

        public override void OnAuthorization(HttpActionContext actionContext)
        { 
            
        }
    }
}