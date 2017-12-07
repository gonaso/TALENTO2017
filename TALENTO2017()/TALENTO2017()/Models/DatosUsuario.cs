using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TALENTO2017__.Models
{
    //Recuperar datos de la tabla usuario de la base de datos
    [Table("usuario", Schema = "public")]
    public class DatosUsuario
    {
        [Key]
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }

        public Boolean esArtista { get; set; }

    }
}