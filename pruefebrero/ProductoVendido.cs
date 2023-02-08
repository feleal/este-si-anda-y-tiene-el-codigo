using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruefebrero
{
    public class ProductoVendido
    {
        private int Id { get; set; }
        private int IdProducto { get; set; }
        private int Stock { get; set; }
        private int IdVenta { get; set; }
        
        public int id
        {
            get => Id;set => Id = value;
        }
        public int idproducto
        {
            get => IdProducto; set => IdProducto = value;   
        }
        public int stock
        {
            get => Stock; set => Stock = value;
        }
        public int idventa
        {
            get => IdVenta; set => IdVenta = value; 
        }
        public ProductoVendido() { }
        public ProductoVendido(int id, int idproducto,int stock,int idventa)
        {
            this.Id = id;   
            this.IdProducto = idproducto;   
            this.Stock = stock;
            this.IdVenta = idventa; 

        }
    }
}
