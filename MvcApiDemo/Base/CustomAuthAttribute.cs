using MvcApiDemo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            //验证Header是否存在
            if (actionContext.Request.Headers.Contains("UserID"))
            {
                //判断当前userID是否存在登陆令牌，如果不存在请重新登陆
                string userid = actionContext.Request.Headers.GetValues("UserID").First();
                byte[] result=RedisHelper.DB.Get(userid);
                if (result!=null &&result.Length>0)
                {
                    RedisHelper.DB.SetEx(userid,  30, System.Text.Encoding.Default.GetBytes(userid));
                }
                else
                { 
                    //不存在需要重新登陆
                    actionContext.Response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.Conflict);
                    actionContext.Response.Content = new StringContent("请登录");
                    actionContext.Response.Headers.Add("rekey", "不存在令牌");
                }
            }
            else
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.Conflict);
                actionContext.Response.Content=new StringContent("请登录");
                actionContext.Response.Headers.Add("rekey", "错误");
            }
        }
    }
}