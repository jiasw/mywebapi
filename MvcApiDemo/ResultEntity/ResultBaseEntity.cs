using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MvcApiDemo.Entity
{
    [DataContract]
    public class ResultBaseEntity
    {
        /// <summary>
        /// 执行结果
        /// </summary>
        [DataMember]
        public bool IsSuccess
        {
            get;
            set;
        }

        /// <summary>
        /// 错误编码
        /// </summary>
        [DataMember]
        public int ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        [DataMember]
        public string ErrorString
        {
            get;
            set;
        }
    }
}