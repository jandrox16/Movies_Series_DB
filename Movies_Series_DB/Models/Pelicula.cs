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

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Titulo { get; set; }

        [Display(Name = "Fecha de salida")]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genero { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Sinopsis { get; set; }

        [Required]
        public int Calificacion { get; set; }

        [Display(Name = "Web-Streaming")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(300)]
        public string WebStreaming { get; set; }
    }
}
