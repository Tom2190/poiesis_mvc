using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace poiesis_mvc.Models
{
    public class Texto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTexto { get; set; }
        [ForeignKey("Usuario")]

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Nombre completo")]
        public int idUsuario { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd-MM-yyyy}")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Fecha de publicación")]
        public DateTime fechaPublicacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Título del texto")]
        public String titulo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Cuerpo del texto")]
        public String contenido { get; set; }

        [EnumDataType(typeof(GeneroDeEscritura))]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Género del texto")]
        public GeneroDeEscritura genero { get; set; }

        public virtual Usuario Usuario { get; set; }

        public override string ToString()
        {
            return "Texto: " + fechaPublicacion + " " + titulo + " " + genero;
        }
    }

}
