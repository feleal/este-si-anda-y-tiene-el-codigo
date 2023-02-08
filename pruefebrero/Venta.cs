using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruefebrero
{
    public  class Venta
    {
        private int Id { get; set; }
        private string Comentarios { get; set; }
        private int IdUsuario { get; set; }

        public int id
        {
            get => Id;set => Id = value;
        }
        public string comentarios
        {
            get=>Comentarios; set => Comentarios = value;
        }
        public int idUsuario
        {
            get => IdUsuario;   set => IdUsuario = value;   
        }

        public Venta()
        {

        }
        public Venta(int id,string comentarios,int idusuario)
        {
            this.Id = id;
            this.Comentarios = comentarios; 
            this.IdUsuario = idUsuario; 
        }
    }
}
