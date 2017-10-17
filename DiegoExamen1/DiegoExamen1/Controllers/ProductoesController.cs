using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiegoExamen1.Models;

namespace DiegoExamen1.Controllers
{
    public class ProductoesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Productoes
        public ActionResult Index()
        {
            var productoes = db.Productoes.Include(p => p.Categorias).Include(p => p.Clientes).Include(p => p.Proveedor).Include(p => p.Vendedores);
            return View(productoes.ToList());
        }

        // GET: Productoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // GET: Productoes/Create
        public ActionResult Create()
        {
            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "Nombre");
            ViewBag.idCliente = new SelectList(db.Clientes, "idCliente", "Nombre_Cliente");
            ViewBag.idProveedor = new SelectList(db.Proveedors, "idProveedor", "Nombre");
            ViewBag.idVendedor = new SelectList(db.Vendedors, "idVendedor", "Nombre_Vendedor");
            return View();
        }

        // POST: Productoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProducto,Nombre,PrecioUnitario,Cantidad,idCategoria,idProveedor,idCliente,idVendedor,FechaCreado")] Producto producto)
           
        {
            if (ModelState.IsValid)
            {
                producto.idCliente = 1;
                producto.idVendedor = 1;
                
                db.Productoes.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "Nombre", producto.idCategoria);
            ViewBag.idCliente = new SelectList(db.Clientes, "idCliente", "Nombre_Cliente", producto.idCliente);
            ViewBag.idProveedor = new SelectList(db.Proveedors, "idProveedor", "Nombre", producto.idProveedor);
           ViewBag.idVendedor = new SelectList(db.Vendedors, "idVendedor", "Nombre_Vendedor", producto.idVendedor);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "Nombre", producto.idCategoria);
            ViewBag.idCliente = new SelectList(db.Clientes, "idCliente", "Nombre_Cliente", producto.idCliente);
            ViewBag.idProveedor = new SelectList(db.Proveedors, "idProveedor", "Nombre", producto.idProveedor);
            ViewBag.idVendedor = new SelectList(db.Vendedors, "idVendedor", "Nombre_Vendedor", producto.idVendedor);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idProducto,Nombre,PrecioUnitario,Cantidad,idCategoria,idProveedor,idCliente,idVendedor,FechaCreado")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "Nombre", producto.idCategoria);
            ViewBag.idCliente = new SelectList(db.Clientes, "idCliente", "Nombre_Cliente", producto.idCliente);
            ViewBag.idProveedor = new SelectList(db.Proveedors, "idProveedor", "Nombre", producto.idProveedor);
            ViewBag.idVendedor = new SelectList(db.Vendedors, "idVendedor", "Nombre_Vendedor", producto.idVendedor);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productoes.Find(id);
            db.Productoes.Remove(producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    




    // GET: Productoes/Edit/5
    public ActionResult ventaProductos(int? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Producto producto = db.Productoes.Find(id);
        if (producto == null)
        {
            return HttpNotFound();
        }
        ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "Nombre", producto.idCategoria);
        ViewBag.idCliente = new SelectList(db.Clientes, "idCliente", "Nombre_Cliente", producto.idCliente);
        ViewBag.idProveedor = new SelectList(db.Proveedors, "idProveedor", "Nombre", producto.idProveedor);
        ViewBag.idVendedor = new SelectList(db.Vendedors, "idVendedor", "Nombre_Vendedor", producto.idVendedor);
        return View(producto);
    }

    // POST: Productoes/Edit/5
    // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
    // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult ventaProductos([Bind(Include = "idProducto,Nombre,PrecioUnitario,Cantidad,idCategoria,idProveedor,idCliente,idVendedor,FechaCreado")] Producto producto, int cantidadProducto)
    {
        if (ModelState.IsValid)
        {
                Venta x = new Venta();
       

             

                x.Total_Venta = producto.PrecioUnitario * cantidadProducto;
                  
                x.Nom_Cliente = Convert.ToString (producto.idCliente);
                x.Nom_Vendedor = Convert.ToString(producto.idVendedor);
                x.Nom_Producto = producto.idProducto;
                x.Precio = producto.PrecioUnitario;
               x.Cantidad_Vendida = cantidadProducto;

                producto.Cantidad = producto.Cantidad - cantidadProducto;
                db.Ventas.Add(x);
                db.SaveChanges();



                db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        ViewBag.idCategoria = new SelectList(db.Categorias, "idCategoria", "Nombre", producto.idCategoria);
        ViewBag.idCliente = new SelectList(db.Clientes, "idCliente", "Nombre_Cliente", producto.idCliente);
        ViewBag.idProveedor = new SelectList(db.Proveedors, "idProveedor", "Nombre", producto.idProveedor);
        ViewBag.idVendedor = new SelectList(db.Vendedors, "idVendedor", "Nombre_Vendedor", producto.idVendedor);
        return View(producto);

            }


        public ActionResult precioDeVenta(int id_Producto, int cantidad_producto)
        {
            var valorProducto = (from producto in db.Productoes
                                 where producto.idProducto == id_Producto
                                 select producto.PrecioUnitario).FirstOrDefault();

            int valor = int.Parse(valorProducto.ToString());
            return Content((valor * cantidad_producto).ToString());


        }
    }
}
