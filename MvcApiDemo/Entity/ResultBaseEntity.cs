using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApiDemo.Entity
{
    public class ResultBaseEntity
    {
        /// <summary>
        /// 执行结果
        /// </summary>
        public bool IsSuccess
        {
            get;
            set;
        }

        /// <summary>
        /// 错误编码
        /// </summary>
        public int ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorString
        {
            get;
            set;
        }
    }
}