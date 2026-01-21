using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
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
    }
}
