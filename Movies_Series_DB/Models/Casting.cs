using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Movies_Series_DB.Models
{
    public class Casting
    {
        public int ID { get; set; } //Clave primaria
        [Display(Name = "Nombre Director")]
        [StringLength(20)]
        [Required]
        public string NombreDir { get; set; }
        
        [Display(Name = "Apellido Director")]
        [StringLength(20)]
        [Required]
        public string ApellidosDir { get; set; } //Clave primaria 2
        
        [Display(Name = "País Director")]
        [StringLength(20)]
        [Required]
        public string PaisDir { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento Director")]
        public DateTime FechaNacDir { get; set; }

        [Display(Name = "Nombre Protagonista")]
        [StringLength(20)]
        [Required]
        public string NombreActPpal { get; set; }
        [Display(Name = "Apellido Protagonista")]
        [StringLength(20)]
        [Required]
        public string ApellidosActPpal { get; set; } //Clave primaria 2

        [Display(Name = "País Protagonista")]
        [StringLength(20)]
        [Required]
        public string PaisActPpal { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento Protagonista")]
        public DateTime FechaNacActPpal { get; set; }

        [Display(Name = "Personaje que interpreta")]
        [StringLength(20)]
        [Required]
        public string PersonajeActPpal { get; set; }
    }
}
