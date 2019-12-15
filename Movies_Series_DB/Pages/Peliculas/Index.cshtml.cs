using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movies_Series_DB.Data;
using Movies_Series_DB.Models;

namespace Movies_Series_DB.Pages.Peliculas
{
    public class IndexModel : PageModel
    {
        private readonly Movies_Series_DB.Data.Movies_Series_DBContext _context;

        public IndexModel(Movies_Series_DB.Data.Movies_Series_DBContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; }
        [BindProperty(SupportsGet = true)]
        public string Busqueda { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Generos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string GeneroPelicula { get; set; }
        public SelectList Calificacion { get; set; }
        [BindProperty(SupportsGet = true)]
        public int CalificacionPelicula { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Pelicula
                                            orderby m.Genero
                                            select m.Genero;
            IQueryable<int> calificacionQuery = from m in _context.Pelicula
                                            orderby m.Calificacion
                                            select m.Calificacion;
            var peliculas = from m in _context.Pelicula
                         select m;
            if (!string.IsNullOrEmpty(Busqueda))
            {
                peliculas = peliculas.Where(s => s.Titulo.Contains(Busqueda));
            }
            if (!string.IsNullOrEmpty(GeneroPelicula))
            {
                peliculas = peliculas.Where(x => x.Genero == GeneroPelicula);
            }
            if (CalificacionPelicula != 0)
            {
                peliculas = peliculas.Where(y => y.Calificacion == CalificacionPelicula);
            }
            Generos = new SelectList(await genreQuery.Distinct().ToListAsync());
            Calificacion = new SelectList(await calificacionQuery.Distinct().ToListAsync());
            Pelicula = await peliculas.ToListAsync();
        }
    }
}
