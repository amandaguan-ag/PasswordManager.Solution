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
        public async Task<ActionResult> Index()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            var currentUserId = _userManager.GetUserId(User);
            List<Password> model = _db.Passwords
                .Where(password => password.UserId == currentUserId)
                .ToList();

            if (currentUser != null)
            {
                return View(model);
            }
    
            return RedirectToAction("AccessDenied"); // Or any other action you want to redirect to
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
public async Task<ActionResult> Edit(Password password)
{
    var userId = _userManager.GetUserId(User);
    var passwordToUpdate = _db.Passwords.FirstOrDefault(p => p.PasswordId == password.PasswordId);
    if(passwordToUpdate == null) 
    {
        // Handle password not found case
        return View(password);
    }
    passwordToUpdate.UserId = userId; // Added this line
    passwordToUpdate.Site = password.Site;
    passwordToUpdate.SiteUsername = password.SiteUsername;
    passwordToUpdate.SiteEmail = password.SiteEmail;
    passwordToUpdate.SitePassword = password.SitePassword;
    // other properties you wish to update
    _db.Update(passwordToUpdate);
    await _db.SaveChangesAsync();
    return RedirectToAction("Index");
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
