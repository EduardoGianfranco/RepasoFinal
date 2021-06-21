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
        public IActionResult Registro(){
            ViewBag.Categ = _context.TCategoria.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Producto p){
            if(ModelState.IsValid){
                _context.TProductos.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }else{
                return View(p);
            }
        }
    }
}