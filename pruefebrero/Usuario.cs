using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruefebrero
{
    public  class Usuario
    {
        private int Id;
        private string Nombre;
        private string Apellido;
        private string NombreUsuario;
        private string Contraseña;
        private string Mail;

        public int id
        {
            get => Id;set => Id = value;
        }
        public string nombre
        {
            get => Nombre;set => Nombre = value;    
        }
        public string apellido
        {
            get => Apellido; set => Apellido = value;
        }
        public string nombreUsuario
        {
            get => NombreUsuario;  set=> NombreUsuario = value; 
        }
        public string contraseña
        {
            get => Contraseña; set => Contraseña = value;
        }
        public string mail
        {
            get => Mail; set => Mail = value;
        }

        public Usuario()
        {

        }
        public Usuario(int id, string nombre,string apellido, string nombreusuario,string contraseña, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;   
            this.Apellido = apellido;
            this.NombreUsuario= nombreusuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
    }
}
