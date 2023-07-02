using Microsoft.AspNetCore.Mvc;
using PasswordManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace PasswordManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly PasswordManagerContext _db;

        public HomeController(PasswordManagerContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            Password[] passwords = _db.Passwords.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("passwords", passwords);
            return View(model);
        }
    }
}