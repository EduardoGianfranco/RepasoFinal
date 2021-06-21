using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepasoFinal.Models;

namespace RepasoFinal.Controllers
{
    public class ProductoController : Controller
    {
        private readonly BuscoContext _context;
        public ProductoController(BuscoContext context){
            _context = context;
        }
        public IActionResult Registroll(){
            ViewBag.Categ = _context.TCategoria.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Registroll(Producto p){
            if(ModelState.IsValid){
                _context.TProductos.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }else{
                ViewBag.Categ = _context.TCategoria.Select(x => new SelectListItem(x.Nombre, x.Id.ToString())); //Al añadir esto el combo box no se bugeará y quedará en blanco, al fallar en poner los datos correctamente y ser redireccionado a Registroll
                return View(p);
            }
        }
    }
}