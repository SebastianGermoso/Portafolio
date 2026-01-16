using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
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
            var persona = new Persona()
            {
                Nombre = "Sebastian Germoso Marrero",
                Edad = 18
            };

            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexDTO() {
                Proyectos = proyectos,
                Nombre = persona.Nombre,
                Edad = persona.Edad
            };

            return View(modelo);
        }


        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() { new ProyectoDTO { 
                Titulo = "Amazon",
                Descipcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/amazon.PNG"
            }, new ProyectoDTO{
                Titulo = "New York Times",
                Descipcion = "Pagina de noticias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/imagenes/nyt.PNG"

            }, new ProyectoDTO{
                Titulo = "Reddit",
                Descipcion = "Red social para compartir en comunidades",
                Link = "https://reddit.com",
                ImagenURL = "/imagenes/reddit.PNG"

            }, new ProyectoDTO{
                Titulo = "Steam",
                Descipcion = "Tienda en linea de videojuegos",
                Link = "https://storesteampowered.com",
                ImagenURL = "/imagenes/steam.PNG"

            },
            };

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
    }
}
