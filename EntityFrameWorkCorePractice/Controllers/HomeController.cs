using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFrameWorkCorePractice.Models;
using EntityFrameWorkCorePractice.Models.Data;

namespace EntityFrameWorkCorePractice.Controllers
{
    public class HomeController : Controller
    {
        DemoContext Context;
        public HomeController(DemoContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            //  Context.Siteusers.Add(new SiteUser() {Name="Jafrul Hasan",UserName="Taj025",Password="489198" });
            //    Context.Courses.Add(new Course() {Name="PHP Larabel",SiteUserId=2});
            //  Context.Courses.Add(new Course() { Name = "ASP.Net Core MVC", SiteUserId = 2 });
            //  var courseName = Context.Courses.Where(x => x.ID == 1).FirstOrDefault();
            //  var Name = Context.Siteusers.Where(x => x.ID == 1).FirstOrDefault();

            //  foreach( Course Co in courseName)
            //  Context.Remove(courseName);
            //  Context.Remove(Name);
            var coursesOfJafrul = Context.Courses.Where(c => c.SiteUser.ID==2).ToList();
            //Context.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
