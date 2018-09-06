using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int idUsuario { get; set; } 
        private string usuario { get; set; }
        private string password { get; set; }
        private string telefono { get; set; }
        private string mail { get; set; }
        private List<Perro> perrosEncontrados { get; set; }

        public Usuario(string usuario,string password,string telefono, string mail)
        {
            this.idUsuario= 0; // consultar como hacer con ID
            this.usuario = usuario;
            this.password = password;
            this.telefono = telefono;
            this.mail = mail;
            this.perrosEncontrados = new List<Perro>();
        }

    }
}
