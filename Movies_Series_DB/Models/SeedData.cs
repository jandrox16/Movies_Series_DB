using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies_Series_DB.Data;
using System;
using System.Linq;

namespace Movies_Series_DB.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Movies_Series_DBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Movies_Series_DBContext>>()))
            {
                // Look for any movies.
                if (context.Pelicula.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pelicula.AddRange(
                    new Pelicula
                    {
                        ID = 1,
                        Titulo = "Peaky Blinders",
                        FechaSalida = DateTime.Parse("2013-7-14"),
                        Genero = "Drama",
                        Sinopsis= "La serie está ambientada en el mundo de los gangsters de los años 20, en Birmingham. Un joven a lomos de un hermoso corcel negro recorre las calles de Birmingham (Inglaterra). Estamos en 1919, la Gran Guerra ha terminado, pero aquel individuo posee el don de atemorizar a su paso a cualquier transeúnte. ¿Quién es? ¿Por qué les asusta tanto? Al parecer busca un hechizo, una pócima, que garantice la victoria de su caballo de carreras. Una mujer oriental proveerá al temido muchacho de una mágica especia que hará que el noble animal equino logre su fin.",
                        Calificacion = 18,
                        WebStreaming = "Actualmente, usted es capaz de ver 'Peaky Blinders' streaming en Netflix, Amazon Prime Video."
                    },

                    new Pelicula
                    {
                        ID = 2,
                        Titulo = "It",
                        FechaSalida = DateTime.Parse("2017-5-25"),
                        Genero = "Terror",
                        Sinopsis = "Remake del clásico de Stephen King en el que un payaso aterroriza a los niños de un vecindario. En un pequeño pueblo de Maine, siete niños conocidos como el Club de los Perdedores se encuentran cara a cara con problemas de la vida, matones y un monstruo que toma la forma de un payaso llamado Pennywise.",
                        Calificacion = 18,
                        WebStreaming = "Actualmente, usted es capaz de ver 'It' streaming en Netflix, HBO, Amazon Prime Video o comprarlo como descarga en Microsoft Store, Apple iTunes, Google Play Movies, Rakuten TV. "
                    }
                );
                context.SaveChanges();
            }
        }
    }
}