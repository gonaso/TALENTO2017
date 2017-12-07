using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TALENTO2017__.Models
{
    //Recuperar datos de la tabla imagenes de la base de datos
    [Table("imagenes", Schema = "public")]
    public class ImagenesPerfilUsuario
    {
        [Key]
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string url_imagen{ get; set; }

    }
}