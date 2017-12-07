using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TALENTO2017__.Models
{
    public class PGDbContext : DbContext
    {
        public PGDbContext() : base(nameOrConnectionString: "ConexionBaseDatosTalento") { }
        public virtual DbSet<Users> Usr { get; set; }
        public virtual DbSet<CvUsuarios> curriculum { get; set; }
        public virtual DbSet<ImagenesPerfilUsuario> imgUsuarioPerfil { get; set; }
        public virtual DbSet<TipoUsuario> tipoUsuario { get; set; }
        public virtual DbSet<DatosUsuario> datosUsuario { get; set; }
    }
}
