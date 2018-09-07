using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindogWebApp.Models
{
    public class Perro
    {

        [Key]
        private int Id { get; set; }
        private string Color { get; set; } 
        private string Tamaño { get; set; }
        private string Raza { get; set; }
        private string Zona { get; set; }
        private string Calle1 { get; set; }
        private string Calle2 { get; set; }

        private Usuario Usuario { get; set; }
        private byte Imagen { get; set; }


        public Perro(string color, string tamaño, string raza, string zona, string calle1, string calle2, Usuario usuario, byte imagen)
        {
            this.Color = color;
            this.Tamaño = tamaño;
            this.Raza = raza;
            this.Calle1 = calle1;
            this.Calle2 = calle2;
            this.Usuario = usuario;
            this.Imagen = imagen;

        }
    }
}