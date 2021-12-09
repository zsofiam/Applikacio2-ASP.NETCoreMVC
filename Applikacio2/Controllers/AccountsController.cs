using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Applikacio2.Models;
using Microsoft.AspNetCore.Http;

namespace Applikacio2.Controllers
{
    public class AccountsController : Controller
    {
        private readonly registryContext _context;

        public AccountsController(registryContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("username") != null)
            {
                return View("Success");
            }
            return View();
        }

       
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username != null && password != null)
            {
                var loggedInUser = _context.Accounts
                .Where(x => x.Username == username && x.Password == password).FirstOrDefault();

                if (loggedInUser == null) {
                    ViewBag.error = "Invalid Username or Password";
                    return View("Login");
                   
                }
                HttpContext.Session.SetString("username", loggedInUser.Username);
                return View("Success");
            }
            else
            {
                ViewBag.error = "Invalid Username or Password";
                return View("Login");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Username,Password")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Login));
            }
            return View();
        }

    }
}
