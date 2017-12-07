using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TALENTO2017__.Models
{
    [Table("login", Schema = "public")]
    public class Users
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }

        //[Column ("password")]
        //public int password { get; set; }
    }
}