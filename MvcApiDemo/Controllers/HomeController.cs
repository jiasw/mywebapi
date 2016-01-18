using MvcApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApiDemo.Controllers
{
    public class HomeController : Controller
    {

        public List<Student> Inilist = new List<Student> { new Student() {Name="张三",ClassName="语文",Score=100 },
                                       new Student() {Name="李四",ClassName="语文",Score=90 },
                                       new Student() {Name="王五",ClassName="数学",Score=100 },
                                       };

        public JsonResult Index()
        {
            return Json(Inilist,JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetListByNameAndScore(string name,string score)
        {
            return Json(Inilist, JsonRequestBehavior.AllowGet);
        }
    }
}
