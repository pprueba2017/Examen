using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiegoExamen1.Models
{
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }
        [Required(ErrorMessage = "Este Campo es Requerido")]

        [DisplayName("Nombre Producto")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Precio Unitario")]
        public double PrecioUnitario { get; set; }

        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }


        [Required(ErrorMessage = "Este Campo es Requerido")]
        [DisplayName("Categoria")]
        public int idCategoria { get; set; }
        [ForeignKey("idCategoria")]
        public virtual Categoria Categorias { get; set; }

        
        [DisplayName("Proveedor")]
        public int idProveedor { get; set; }
        [ForeignKey("idProveedor")]
        public virtual Proveedor Proveedor { get; set; }

        [DisplayName("Nombre Cliente")]
        public int idCliente { get; set; }
        [ForeignKey("idCliente")]
        public virtual Cliente Clientes { get; set; }

        [DisplayName("Nombre Vendedor")]
        public int idVendedor { get; set; }
        [ForeignKey("idVendedor")]
        public virtual Vendedor Vendedores { get; set; }

        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }
    }
}