using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MvcApiDemo.Entity
{
    [DataContract]
    public class SysUserLoginEntity
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string PassWord { get; set; }

    }
}