using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Profiles.Models;


namespace Profiles.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/users")]
        public ActionResult Users()
        {
          List<AppUser> allUsers = AppUser.GetAll();
            return View(allUsers);
        }

        [HttpGet("/users/new")]
        public ActionResult UserForm()
        {
        return View();
        }

        [HttpPost("/users")]
        public ActionResult AddUser()
        {
            AppUser newUser = new AppUser(Request.Form["new-name"],Request.Form["new-address"],Request.Form["new-number"]);
            List<AppUser> allUsers = AppUser.GetAll();
            return View("Users", allUsers);
        }

        [HttpGet("/users/{id}")]
        public ActionResult UserDetail(int id)
        {
          AppUser user = AppUser.Find(id);
          return View(user);
        }

        [HttpPost("/user/list/clear")]
        public ActionResult UserListClear()
        {
            AppUser.ClearAll();
            return View();
        }
    }
}
