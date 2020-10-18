using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Schooldemo;

namespace Exam.Controllers
{
    public class AccountController : Controller
    {
        SchoolContext ctx = new SchoolContext();
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult UserLogin(string username, string password)
        {
           
            if (ctx.Users.Any(a => a.Username == username && a.Password == password))
            {
                string url = $"Welcome?user={username}";
                return Redirect(url);
            }
            return RedirectToAction("Login");
        }
        public string Welcome(string user)
        {
            return "Welcome Dear " + user + " !";

        }
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult UserSignUp(string username,string email,string passowrd)
        {

            ctx.Users.Add(new User()
            {
                Username = username,
               Password =passowrd,
                Email = email
            });
            //ctx.Users.Add(ur);
            ctx.SaveChanges();
           
            return RedirectToAction("index", "user");



        }
    }
}
