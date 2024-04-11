using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using progettoECommerce.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace progettoECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly dbContext _dbContext;

        public int CurrentUserId { get; private set; }

        public HomeController(dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ChiSiamo()
        {
            return View();
        }

        public IActionResult Carrello()
        {
            if (HttpContext.Session.GetString("isAuthenticated") == "OK")
            {
                // Recupera i dati del carrello dal database
                var carrelloItems = _dbContext.Carrelli.Include(c => c.Registrazione)
                                                       .Where(c => c.RegistrazioneId == CurrentUserId)
                                                       .ToList();
                return View(carrelloItems);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult LoginOrRegister()
        {
            // Verifica se l'utente è autenticato
            if (HttpContext.Session.GetString("isAuthenticated") == "OK")
            {
                // Se l'utente è già autenticato, reindirizza al carrello
                return RedirectToAction("Carrello");
            }
            else
            {
                // Se l'utente non è autenticato, reindirizza alla pagina di login o registrazione
                return RedirectToAction("Login");
            }
        }


        [HttpGet]
        public ActionResult Registrazione()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrazione(Registrazione registrazione)
        {
            if (ModelState.IsValid)
            {
                var nuovoUtente = new Registrazione
                {
                    Username = registrazione.Username,
                    Email = registrazione.Email,
                    Password = registrazione.Password
                };

                _dbContext.Registrazioni.Add(nuovoUtente);
                _dbContext.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(registrazione);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            var utente = _dbContext.Registrazioni.FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);
            if (utente != null)
            {
                // Utente autenticato, eseguire il login
                HttpContext.Session.SetString("isAuthenticated", "OK");
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Username o password non validi.");
            return View();
        }

        public ActionResult Logout(Login login)
        {
            HttpContext.Session.SetString("isAuthenticated", "");
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
