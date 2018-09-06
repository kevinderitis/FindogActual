using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro
    {
        private int idPerro { get; set; }
        private string color { get; set; }
        private string tamaño  { get; set; }
        private string raza { get; set; }
        private string zona{ get; set; }
        private string calle1 { get; set; }
        private string calle2 { get; set; }

        private Usuario usuario{ get; set; }
        private byte imagen{ get; set; }


        public Perro(string color, string tamaño, string raza, string zona, string calle1, string calle2, Usuario usuario, byte imagen)
        {
            this.color = color;
            this.tamaño = tamaño;
            this.raza = raza;
            this.calle1 = calle1;
            this.calle2 = calle2;
            this.usuario = usuario;
            this.imagen = imagen;
            
        }



    }
}
