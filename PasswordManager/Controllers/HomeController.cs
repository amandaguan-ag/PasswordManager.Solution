using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Models;
using System.Collections.Generic;
using System.Linq;
// using Microsoft.AspNetCore.Identity;


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
            List<Password> model = _db.Passwords.ToList();

            // Password[] Passwords = _db.Passwords.ToArray();
            // Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            // model.Add("Passwords", Passwords);
            return View(model);
        }
    }
}
