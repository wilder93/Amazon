using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Amazon.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Por favor ingresa un ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Por favor ingresa un Titulo")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Por favor ingresa un Autor")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Por favor ingresa un Precio")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Por favor ingresa un Nro de paginas")]
        public int? NroPages { get; set; }

        public LevelStock LevelStock { get; set; } = LevelStock.InStock;
    }
}
