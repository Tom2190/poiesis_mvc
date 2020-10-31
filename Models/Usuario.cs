using System;
using System.Collections.Generic;
using System.Text;

namespace poiesis_api
{
    public partial class Usuario
    {

        public Usuario()
        {
            Texto = new HashSet<Texto>();
        }

        public int idUsuario { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public String celular { get; set; }
        public String email { get; set; }
        public String experienciaDeEscritura { get; set; }
        public String contrasenia { get; set; }
        public GeneroDeEscritura generoDeEscritura { get; set; }
        public FrecuenciaDeLectura frecuenciaDeLectura { get; set; }
        public EleccionDiaYHorario eleccionDiaYHorario { get; set; }

        public IEnumerable<Texto> Texto { get; set; }
    }

}
