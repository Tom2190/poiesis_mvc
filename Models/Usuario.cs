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

        public String nombreCompleto
        {
            get { return this.nombre + " " + this.apellido;}
        }
        public String dni { get; set; }
        public String celular { get; set; }
        public String email { get; set; }
        [Display(Name = "Experiencia de escritura")]
        public String experienciaDeEscritura { get; set; }
        [Display(Name = "Contraseña")]
        public String contrasenia { get; set; }
        [Display(Name = "Género de escritura")]
        [EnumDataType(typeof(GeneroDeEscritura))]
         public GeneroDeEscritura generoDeEscritura { get; set; }
        [Display(Name = "Frecuencia de lectura")]
        [EnumDataType(typeof(FrecuenciaDeLectura))]
        public FrecuenciaDeLectura frecuenciaDeLectura { get; set; }
        [Display(Name = "Elección de día y horario")]
        [EnumDataType(typeof(EleccionDiaYHorario))]
        public EleccionDiaYHorario eleccionDiaYHorario { get; set; }

        public IEnumerable<Texto> Texto { get; set; }
    }

}
