using Microsoft.AspNetCore.Mvc;
using OficinaConectada.Models;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace OficinaConectada.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static async Task SaveMessage(string text)
        {
            using StreamWriter file = new("contatos.txt", append: true);
            await file.WriteLineAsync(text);
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            string name = contact.name;
            string email = contact.email;
            string phone = contact.phone;
            string mechanic = contact.mechanic;
            string message = contact.message;


            string contato =
            "\n\nNome: " + contact.name + 
            "\nEmail: " + contact.email + 
            "\nWhatsapp: " + contact.phone +
            "\nÉ mecânico ou dono de centro automotivo? " + contact.mechanic + 
            "\nMensagem: " + contact.message +
            "\n--------------------------------------------------------------------";

            Task task = SaveMessage(contato);         

            return View();
        }
    }
}