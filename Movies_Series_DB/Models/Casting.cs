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
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string NombreDir { get; set; }
        
        [Display(Name = "Apellido Director")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string ApellidosDir { get; set; } //Clave primaria 2
        
        [Display(Name = "País Director")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string PaisDir { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento Director")]
        public DateTime FechaNacDir { get; set; }

        [Display(Name = "Nombre Protagonista")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string NombreActPpal { get; set; }
        [Display(Name = "Apellido Protagonista")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string ApellidosActPpal { get; set; } //Clave primaria 2

        [Display(Name = "País Protagonista")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string PaisActPpal { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento Protagonista")]
        public DateTime FechaNacActPpal { get; set; }

        [Display(Name = "Personaje que interpreta")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string PersonajeActPpal { get; set; }
    }
}
