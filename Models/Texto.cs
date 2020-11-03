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
        public int idTexto { get; set;}
        [ForeignKey("Usuario")]
        [Display(Name = "Nombre completo")]
        public int idUsuario { get; set; }

        [Display(Name = "Fecha publicación")]
        public DateTime fechaPublicacion { get; set; }
        [Display(Name = "Título del texto")]
        public String titulo { get; set; }
        [Display(Name = "Cuerpo del texto")]
        public String contenido { get; set; }

        [EnumDataType(typeof(GeneroDeEscritura))]
        [Display(Name = "Género del texto")]
        public GeneroDeEscritura genero { get; set; }

        public virtual Usuario Usuario { get; set; }

    }

}
