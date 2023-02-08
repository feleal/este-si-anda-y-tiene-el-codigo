using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruefebrero
{
    public class Producto
    {

        private int Id { get; set; }
        private string Descripcion { get; set; }
        private decimal Costo { get; set; }
        private decimal PrecioVenta { get; set; }
        private int Stock { get; set; }
        private int IdUsuario { get; set; }

        public int id
        {
            get => Id; set => Id = value;
        }
        public string descripcion
        {
            get => Descripcion; set => Descripcion = value;
        }
        public decimal costo
        {
            get => Costo; set => Costo = value;
        }
        public decimal precioventa
        {
            get => PrecioVenta; set => PrecioVenta = value;
        }
        public int stock
        {
            get => Stock;   set => Stock = value;   
        }
        public int idusuario
        {
            get => IdUsuario; set => IdUsuario = value;
        }

        public Producto()
        {

        }
        public Producto(int id,string descripcion,decimal costo,decimal precioventa,int stock, int idusuaurio)
        {
            this.Id= id;    
            this.Descripcion= descripcion;  
            this.Costo= costo;
            this.PrecioVenta= precioventa;  
            this.Stock= stock;
            this.IdUsuario= idusuaurio; 
        }
    }
}
