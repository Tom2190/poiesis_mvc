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
        public int idUsuario { get; set; }

        [Display(Name = "Fecha publicación")]
        public DateTime fechaPublicacion { get; set; }
        public String titulo { get; set; }
        public String contenido { get; set; }

        [EnumDataType(typeof(GeneroDeEscritura))]
        public GeneroDeEscritura genero { get; set; }

        public virtual Usuario Usuario { get; set; }

    }

}
