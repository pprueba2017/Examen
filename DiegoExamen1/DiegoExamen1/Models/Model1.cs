namespace DiegoExamen1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Model1' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DiegoExamen1.Models.Model1' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model1'  en el archivo de configuración de la aplicación.
        public Model1()
            : base("name=Model1")
        {
        }

        public System.Data.Entity.DbSet<DiegoExamen1.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<DiegoExamen1.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<DiegoExamen1.Models.Vendedor> Vendedors { get; set; }

        public System.Data.Entity.DbSet<DiegoExamen1.Models.Producto> Productoes { get; set; }

        public System.Data.Entity.DbSet<DiegoExamen1.Models.Proveedor> Proveedors { get; set; }

        public System.Data.Entity.DbSet<DiegoExamen1.Models.Venta> Ventas { get; set; }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}