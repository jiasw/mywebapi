﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MvcApiDemo.Base
{
    [CustomAuth(false)]
    public class BaseAPIController : ApiController
    {
    }
}