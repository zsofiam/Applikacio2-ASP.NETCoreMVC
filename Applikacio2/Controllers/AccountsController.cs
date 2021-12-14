using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Applikacio2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;

namespace Applikacio2.Controllers
{
    public class AccountsController : Controller
    {
        private readonly registryContext _context;
        private readonly ILogger _logger;

        public AccountsController(registryContext context, ILogger<AccountsController> logger)
        {
            _context = context;
            _logger = logger;
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
            _logger.LogInformation("Login attempt at " + DateTime.Now);
            _logger.LogInformation("Login attempt from " + "IP ADDRESS " +
                Request.HttpContext.Connection.RemoteIpAddress);

            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
           
            var loginEvent = new LoginEvent();

            if (username != null && password != null)
            {
                
                var loggedInUser = _context.Accounts
                .Where(x => x.Username == username && x.Password == password).FirstOrDefault();

                if (loggedInUser == null) {
                    //query1

                    loginEvent.IPAddress = ipAddress.ToString();
                    loginEvent.HappenedAt = DateTime.Now;
                    loginEvent.Username = username;
                    loginEvent.Result = "unsuccessful";
                    loginEvent.Counter = 0;

                    _context.LoginEvents.Add(loginEvent);

                    _context.SaveChanges();

                    ViewBag.error = "Invalid Username or Password";
                    return View("Login");
                   
                }
                else {
                    //query2

                    loginEvent.IPAddress = ipAddress.ToString();
                    loginEvent.HappenedAt = DateTime.Now;
                    loginEvent.Username = username;
                    loginEvent.Result = "successful";
                    loginEvent.Counter = 1;

                    _context.LoginEvents.Add(loginEvent);

                    _context.SaveChanges();

                    HttpContext.Session.SetString("username", loggedInUser.Username);
                return View("Success");
                }
            }
            else
            {

                loginEvent.IPAddress = ipAddress.ToString();
                loginEvent.HappenedAt = DateTime.Now;
                loginEvent.Username = username;
                loginEvent.Result = "unsuccessful";
                loginEvent.Counter = 0;

                _context.LoginEvents.Add(loginEvent);

                _context.SaveChanges();

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
