using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MvcApiDemo.Entity
{
    [DataContract]
    public class UserScore : ResultBaseEntity
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Score { get; set; }
    }
}