using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindogWebApp.Models
{
    public class Usuario
    {
        
        private int Id { get; set; }
        private string usuario { get; set; }
        private string password { get; set; }
        private string telefono { get; set; }
        private string mail { get; set; }
        private List<Perro> perrosEncontrados { get; set; }

        public Usuario(string usuario, string password, string telefono, string mail)
        {

            this.usuario = usuario;
            this.password = password;
            this.telefono = telefono;
            this.mail = mail;
            this.perrosEncontrados = new List<Perro>();
        }





    }
}