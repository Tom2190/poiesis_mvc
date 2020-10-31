using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace poiesis_mvc.Models
{
    public  class Usuario
    {
        
        public Usuario()
        {
            Texto = new HashSet<Texto>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public String celular { get; set; }
        public String email { get; set; }
        [Display(Name = "Experiencia de escritura")]
        public String experienciaDeEscritura { get; set; }
        [Display(Name = "Contraseña")]
        public String contrasenia { get; set; }
        [EnumDataType(typeof(GeneroDeEscritura))]
         public GeneroDeEscritura generoDeEscritura { get; set; }
        [EnumDataType(typeof(FrecuenciaDeLectura))]
        public FrecuenciaDeLectura frecuenciaDeLectura { get; set; }
        [EnumDataType(typeof(EleccionDiaYHorario))]
        public EleccionDiaYHorario eleccionDiaYHorario { get; set; }

        public IEnumerable<Texto> Texto { get; set; }
    }

}
