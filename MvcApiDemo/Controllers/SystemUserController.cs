using MvcApiDemo.Entity;
using MvcApiDemo.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace MvcApiDemo.Controllers
{
    //用户登陆接口
    public class SystemUserController : ApiController
    {
        public List<Student> Inilist = new List<Student> { new Student() {Name="张三",ClassName="语文",Score=100,PassWord="123456" },
                                       new Student() {Name="李四",ClassName="语文",Score=90,PassWord="123456" },
                                       new Student() {Name="王五",ClassName="数学",Score=100,PassWord="123456" },
                                       };

        [HttpPost]
        public UserScore  Login([FromBody]SysUserLoginEntity user)
        {
            List<Student> listresult= Inilist.FindAll(n => n.Name == user.UserName );
            UserScore result = new UserScore() {ErrorCode=-1,IsSuccess=false };
            foreach (var item in listresult)
            {
                result.IsSuccess = true;
                result.Score = item.Score.ToString();
                result.Username = item.Name;
            }
            return result;
        }

        // GET api/systemuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/systemuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/systemuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/systemuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/systemuser/5
        public void Delete(int id)
        {
        }
    }
}
