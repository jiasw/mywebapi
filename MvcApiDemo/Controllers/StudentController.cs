using MvcApiDemo.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcApiDemo.Controllers
{
    public class StudentController : ApiController
    {
        private List<Student> studentlist = new List<Student>();

        private List<Student> InitStudentList()
        {
            List<Student> list = new List<Student>();


            return list;
        }
    }
}
