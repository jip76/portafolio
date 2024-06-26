﻿using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion ="E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/amazon.png"
            },
                new Proyecto
            {
                Titulo = "Reddit",
                Descripcion ="red social para compartir em comunidades",
                Link ="https://reddit.com",
                ImagenURL ="/imagenes/reddit.jpeg"
            },
                new Proyecto
            {
                Titulo = "New Your Time",
                Descripcion ="Paginas de noticas en React",
                Link ="https://nytimes.com",
                ImagenURL ="/imagenes/nyt.png"
            },
                new Proyecto
            {
                Titulo = "Steam",
                Descripcion ="Tienda en linea para comprar videosjuegos",
                Link ="https://store.steampowered.com",
                ImagenURL ="/imagenes/steam.png"
            },
            };
        }
    }
}
