using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProgra
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "--- Menu Principal --- \n 1- Agregar producto. \n 2- Factura. \n 3- Reporte de cantidad. \n 4- Salir. \n Seleccione una opcion: ";
            char opcion;
            
            Carrito carrito = new Carrito();
            Producto producto1 = new Producto("IPhone 16", 650.000, 15, "2567");
            Producto producto2 = new Producto("Laptop Lenovo", 380.000, 6, "2947");
            Producto producto3 = new Producto("PS5", 450.000, 22, "6378");
            Producto producto4 = new Producto("Headset Sony", 85.000, 11, "8294");
            Producto producto5 = new Producto("Monitor Curvo", 450.000, 18, "3846");
            
            List<Producto> Productos = new List<Producto> { producto1, producto2, producto3, producto4, producto5 };
         
            do
            {
                Console.WriteLine(menu);
                opcion = Char.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("\n Los productos disponibles son: ");
                        foreach (Producto producto in Productos)
                        {
                            producto.mostrarInformacion();
                        }
                        Console.WriteLine("Ingrese el codigo del producto que desea agregar: ");
                        
                        foreach (Producto producto in Productos)
                        {
                            string codigoProducto = Console.ReadLine();
                            if (codigoProducto == producto.getCodigo())
                            {
                                Console.WriteLine("Ingrese la cantidad deseada");
                                int cant = int.Parse(Console.ReadLine());

                                if (cant > producto.getCantidad())
                                {
                                    Console.WriteLine("No hay suficiente stock para esa cantidad");
                                }
                                else
                                {
                                    producto.reducirCantidad(cant);
                                    carrito.agregarItem(cant, producto.getPrecio(), producto.getNombre());
                                    Console.WriteLine("Producto añadido!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("El codigo no pertenece a ningun producto");
                            }
                        }


                        break;
                    case '2':
                        double IVA = carrito.getTotal() * 0.13;
                        double total = carrito.getTotal() + IVA;
                        Console.WriteLine($"Su carrito contiene{carrito.getNombre()} \n El total de productos en su carrito es {carrito.getCantidad()} \n El total a pagar mas IVA es de: {total}");
                        break;
                    case '3':
                        Console.WriteLine("Estas son las cantidades de los productos: ");
                        foreach (Producto producto in Productos)
                        {
                            Console.WriteLine($"{producto.getNombre()}: {producto.getCantidad()}");
                        }
                        break;
                    case '4':
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != '4');
        }
    }
}
