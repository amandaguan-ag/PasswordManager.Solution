using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace PasswordManager.Controllers
{
    public class PasswordsController : Controller
    {
        private readonly PasswordManagerContext _db;

        public PasswordsController(PasswordManagerContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Password> model = _db.Passwords.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Password password)
        {
            _db.Passwords.Add(password);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Password thisPassword = _db.Passwords
                                      // .Include(password => password.Passwords)
                                      // .ThenInclude(Password => Password.JoinEntities)
                                      // .ThenInclude(join => join.Tag)
                                      .FirstOrDefault(password => password.PasswordId == id);
            return View(thisPassword);
        }

        public ActionResult Edit(int id)
        {
            Password thisPassword = _db.Passwords.FirstOrDefault(password => password.PasswordId == id);
            return View(thisPassword);
        }

        [HttpPost]
        public ActionResult Edit(Password password)
        {
            _db.Passwords.Update(password);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Password thisPassword = _db.Passwords.FirstOrDefault(password => password.PasswordId == id);
            return View(thisPassword);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Password thisPassword = _db.Passwords.FirstOrDefault(password => password.PasswordId == id);
            _db.Passwords.Remove(thisPassword);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
