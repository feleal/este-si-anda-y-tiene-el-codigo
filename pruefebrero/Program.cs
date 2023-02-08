// See https://aka.ms/new-console-template for more information
using pruefebrero;
using System.Collections.Specialized;

Console.WriteLine(" Se mostraran los componentes del objeto");

Usuario usu = new Usuario(01,"Martin","Bonano","mabo","manito","bonano@gmail");
Console.WriteLine("el id del usuario es:..." +usu.id);
Console.WriteLine("el nombre del usuario es:.." +usu.nombre);
Console.WriteLine("El Apellido del usuario:.."+usu.apellido);
Console.WriteLine("El nombre usuario es;.."+usu.nombreUsuario);
Console.WriteLine("La contraseña que se ingresa es:.."+usu.contraseña);
Console.WriteLine("La direccion de mail del Usuario es:.."+usu.mail);

Console.WriteLine("####################################################3");

Console.WriteLine("MOSTRANDO LOS DATOS DEL OBJERO VENTA");

Venta vn= new Venta(01,"Hola este es un comentario",01);
Console.WriteLine("este es el id del usuario:.."+vn.id);
Console.WriteLine("No es el mismo producto que se ve el la pagina:..."+vn.comentarios);
Console.WriteLine("el numero del idusuario es:.."+vn.idUsuario);

Console.WriteLine("#######################################################3");
Console.WriteLine("MOSTRANDO LOS DATOS DEL OBJETO PRODUCTO");

Producto produ = new Producto(01,"Mesa Vidrio",100,200,10,02);
Console.WriteLine("Este es el id del producto"+produ.id);
Console.WriteLine("el producto es:... "+produ.descripcion);
Console.WriteLine("el precio de costo es ---"+produ.costo);
Console.WriteLine(" el mismo se vende a :.."+produ.precioventa);
Console.WriteLine("unidades posibles de venta:.."+produ.stock);
Console.WriteLine("identificador del vendedor:...."+produ.idusuario);
Console.WriteLine("###########################################################");

Console.WriteLine("MOSTRANDO LOS DATOS DE PRODUCTO VENDIDO..");

ProductoVendido produ1 = new ProductoVendido(01,02,600,02);
Console.WriteLine("el id del producto vendido es :..."+produ1.id);
Console.WriteLine("el id es: "+produ1.idproducto);
Console.WriteLine(" el stock es de :..."+ produ1.stock);
Console.WriteLine("El id de la venta es :....."+produ1.idventa);
Console.ReadLine();