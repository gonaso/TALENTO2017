using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TALENTO2017__.Models
{
    //Recuperar datos de la tabla tipo_usuario de la base de datos
    [Table("tipo_usuario", Schema = "public")]
    public class TipoUsuario
    {
        [Key]
        public int id { get; set; }
        public Boolean esArtista{ get; set; }

    }
}