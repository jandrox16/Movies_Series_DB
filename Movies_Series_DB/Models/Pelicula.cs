using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_Series_DB.Models
{
    public class Pelicula
    {
        public int ID { get; set; } //Clave primaria
        public string Titulo { get; set; }

        [Display(Name = "Fecha de salida")]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
        public string Genero { get; set; }
        public string Sinopsis { get; set; }
        public int Calificacion { get; set; }

        [Display(Name = "Web-Streaming")]
        public string WebStreaming { get; set; }
    }
}
