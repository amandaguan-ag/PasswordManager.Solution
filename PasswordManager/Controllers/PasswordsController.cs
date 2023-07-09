using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PasswordManager.Controllers
{
    [Authorize]
    public class PasswordsController : Controller
    {
        private readonly PasswordManagerContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public PasswordsController(UserManager<ApplicationUser> userManager, PasswordManagerContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
          var currentUserId = _userManager.GetUserId(User);
          List<Password> model = _db.Passwords
            .Where(password => password.UserId == currentUserId)
            .ToList();
          return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

     [HttpPost]
    public async Task<ActionResult> Create(Password password)
    {
      if (ModelState.IsValid)
      {
        // Get the current user's Id
        var userId = _userManager.GetUserId(User);
        
        // Set the UserId property on the password record
        password.UserId = userId;
        
        // Add the password record to the database
        _db.Passwords.Add(password);
        await _db.SaveChangesAsync();

        return RedirectToAction("Index");
      }
      
      return View(password);
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
