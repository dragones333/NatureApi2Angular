using NatureApi2.Models;
using System.Collections.Generic;
using System.Linq;

namespace NatureApi2.Services
{
    public class PlaceService
    {
        private readonly List<Place> _places;

        public PlaceService()
        {
            _places = new List<Place>
            {
                new Place
                {
                    Id = 1,
                    Nombre = "Parque Metropolitano",
                    Categoria = "Parque",
                    Descripcion = "Gran parque urbano con lago y senderos para caminar.",
                    Latitud = 21.1216,
                    Longitud = -101.6841,
                    Altitud = 1800,
                    Accesible = true,
                    CuotaEntrada = 25.00m,
                    Horario = "6:00 - 19:00",
                    Amenities = new() { "Baños", "Estacionamiento", "Cafetería" },
                    Fotos = new() {
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtDmh4vBFQA926n13-25BjgOnQd6Q0nhiARA&s",
                        "https://3erinforme.leon.gob.mx/wp-content/uploads/2024/09/5-4.jpg"
                    },
                    Senderos = new()
                    {
                        new Trail { Id = 1, Nombre = "Sendero del Lago", DistanciaKm = 2.5, Dificultad = "Fácil", TiempoEstimado = "30 min", EsLoop = true },
                        new Trail { Id = 2, Nombre = "Ruta de las Flores", DistanciaKm = 4.1, Dificultad = "Media", TiempoEstimado = "1 h", EsLoop = false }
                    }
                },
                new Place
                {
                    Id = 2,
                    Nombre = "Zoológico de León",
                    Categoria = "Zoológico",
                    Descripcion = "Espacio natural con gran variedad de especies animales.",
                    Latitud = 21.1229,
                    Longitud = -101.6662,
                    Altitud = 1785,
                    Accesible = true,
                    CuotaEntrada = 40.00m,
                    Horario = "9:00 - 18:00",
                    Amenities = new() { "Restaurante", "Estacionamiento", "Souvenirs" },
                    Fotos = new() {
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdj5GUrC0EoAe19dIzFbwob-TInC7a6c7F7w&s",
                        "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/27/9f/66/zooleon-un-lugar-increible.jpg?w=900&h=500&s=1"
                    },
                    Senderos = new()
                    {
                        new Trail { Id = 3, Nombre = "Ruta de los Felinos", DistanciaKm = 1.2, Dificultad = "Fácil", TiempoEstimado = "20 min", EsLoop = true },
                        new Trail { Id = 4, Nombre = "Camino de Aves", DistanciaKm = 3.0, Dificultad = "Media", TiempoEstimado = "45 min", EsLoop = false }
                    }
                },
                new Place
                {
                    Id = 3,
                    Nombre = "Centro Histórico",
                    Categoria = "Cultural",
                    Descripcion = "Zona histórica con museos y arquitectura colonial.",
                    Latitud = 21.1251,
                    Longitud = -101.6820,
                    Altitud = 1790,
                    Accesible = true,
                    CuotaEntrada = 0.00m,
                    Horario = "8:00 - 20:00",
                    Amenities = new() { "Guías", "Tiendas", "Restaurantes" },
                    Fotos = new() {
                        "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/200000/200762-Guanajuato.jpg",
                        "https://www.leon-mexico.com/centrohistorico/img/ch_55.jpg"
                    },
                    Senderos = new()
                    {
                        new Trail { Id = 5, Nombre = "Ruta Patrimonial", DistanciaKm = 2.0, Dificultad = "Fácil", TiempoEstimado = "40 min", EsLoop = true }
                    }
                }
            };
        }

        public IEnumerable<Place> GetAll() => _places;

        public Place? GetById(int id) => _places.FirstOrDefault(p => p.Id == id);
    }
}