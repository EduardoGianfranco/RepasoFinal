using System;
using System.ComponentModel.DataAnnotations;

namespace RepasoFinal.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pon ke vendes ps v:")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Kuale tu nombre ps :v")]
        public string NombreComprador { get; set; }
        [Required]
        [Display(Name = "Tu clularsh")]
        public string CelularComprador { get; set; }
        [Required]
        [Display(Name = "Elmo sabe donde vives, pero igual pon donde vives aqi abajo")]
        public string LugarCompra { get; set; }
        [Required]
        [Display(Name = "No olbides poner por qué deberia comprar tu wea")]
        public string Descripcion { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public decimal Precio { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Categoria Categoria { get; set; }
        [Required]
        public int CategoriaId { get; set; }


        public Producto(){
            FechaRegistro = DateTime.Now;
        }
    }
}