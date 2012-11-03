using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCVenta.Models;
using MVCVenta.ViewModels;

namespace MVCVenta.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/
        public readonly VentaDataClassesDataContext _data;

        public ProductoController(VentaDataClassesDataContext data)
        {
            _data = data;
        }

        public ProductoController()
        {
            _data = new VentaDataClassesDataContext();
        }

        public ActionResult Index()
        {
            //return View();
            //return View(_data.TB_Productos.Select(p => new ProductoList(p.Pk_eProducto, p.cEspecificacion, p.cDescripcion, p.dPrecio,p.cEspecificacion)));
            // var dataContext = new ProductsDataContext();
            List<ProductoList> listaProductos = null;
            var productos = (from p in _data.TB_Productos
                             join d in _data.TB_Dominios
                             on p.Fk_eDominio equals d.Pk_eDominio
                             select new
                                  {
                                      p.Pk_eProducto,
                                      dominio = d.cDescripcion,
                                      producto = p.cDescripcion,
                                      p.dPrecio,
                                      p.cEspecificacion,
                                      p.bImagen
                                  }).ToList();

            listaProductos = productos.ConvertAll(o => new ProductoList(o.Pk_eProducto,o.dominio,o.producto,o.dPrecio,o.cEspecificacion,o.bImagen));

            return View(listaProductos);
        }

        //
        // GET: /Producto/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Producto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Producto/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Producto/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Producto/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Producto/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Producto/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
