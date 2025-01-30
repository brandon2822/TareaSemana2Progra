using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProgra
{
    class Producto
    {
        private double precio;
        private int cantidad;
        private string nombre;
        private string codigo;

        // Constructor
        public Producto(string nombre, double precio, int cantidad, string codigo)
        {
            this.precio = precio;
            this.cantidad = cantidad;
            this.nombre = nombre;
            this.codigo = codigo;
        }

        // Metodos

        public void mostrarInformacion()
        {
            Console.WriteLine($" \n Nombre: {nombre} \n Precio: {precio} \n Cantidad: {cantidad} \n Codigo: {codigo}");
        }

        public void reducirCantidad(int cantidad)
        {
            this.cantidad -= cantidad;
        }

        // Getters y Setters
        public string getCodigo()
        {
            return codigo;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public double getPrecio()
        {
            return precio;
        }

        public string getNombre()
        {
            return nombre;
        }

        



    }
}
