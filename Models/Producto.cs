using System;
using System.ComponentModel.DataAnnotations;

namespace RepasoFinal.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string NombreComprador { get; set; }
        [Required]
        public string CelularComprador { get; set; }
        [Required]
        public string LugarCompra { get; set; }
        [Required]
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