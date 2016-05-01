using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio03PlatziCSharp.WebApi.Models
{
    public class Desafio03PlatziCSharpWebApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Desafio03PlatziCSharpWebApiContext() : base("name=Desafio03PlatziCSharpWebApiContext")
        {
        }

        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
