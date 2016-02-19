using MvcApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApiDemo.Entity
{
    public class ResultEntity<T> : ResultBaseEntity where T:ResultBaseEntity 
    {
        
        public T Result { get; set; }
    }
}