using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProgra
{
    class Carrito
    {
        int cantArticulos;
        double totalCarrito;
        List<string> nombreProductos;

        // Constructor por defecto

        public Carrito()
        {
            cantArticulos = 0;
            totalCarrito = 0;
            nombreProductos = new List<string>();
        }

        //Metodos
        public void agregarItem(int cantidad, double precio, string nombre)
        {
            cantArticulos += cantidad;
            totalCarrito+= precio;
            nombreProductos.Add(nombre);
        }

        //Getters y Setters

        public int getCantidad()
        {
            return cantArticulos;
        }
        public string getNombre()
        {
            string nombres = "";
            foreach (string nombre in nombreProductos)
            {
                nombres = nombres + $", {nombre}";
                
            }
            return nombres;
        }

        public double getTotal()
        {
            return totalCarrito;
        }
    }
}
