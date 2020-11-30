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

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50)]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50)]
        public String apellido { get; set; }


        public String nombreCompleto
        {
            get { return this.nombre + " " + this.apellido;}
        }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(00000000,99999999)]
        public String dni { get; set; }

       
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"^((\(?\d{3}\)? \d{4})|(\(?\d{4}\)? \d{3})|(\(?\d{5}\)? \d{2}))-\d{4}$",
        ErrorMessage = "Debe ingresar un celular válido Ej: (011) 1111-2222")]
        public String celular { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",
        ErrorMessage = "Debe ingresar un email válido Ej: test@test.com")]
        public String email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Experiencia de escritura")]
        public String experienciaDeEscritura { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Contraseña")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage = "El password debe contener al menos: 1 número, 1 mayusc, 1 minusc y 8 caracteres de largo")]
        public String contrasenia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Género de escritura")]
        [EnumDataType(typeof(GeneroDeEscritura))]
         public GeneroDeEscritura generoDeEscritura { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Frecuencia de lectura")]
        [EnumDataType(typeof(FrecuenciaDeLectura))]
        public FrecuenciaDeLectura frecuenciaDeLectura { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Elección de día y horario")]
        [EnumDataType(typeof(EleccionDiaYHorario))]
        public EleccionDiaYHorario eleccionDiaYHorario { get; set; }

        public IEnumerable<Texto> Texto { get; set; }

        public override string ToString()
        {
            return "Usuario: " + nombreCompleto + " " + contrasenia + " " + email;
        }
    }

}
