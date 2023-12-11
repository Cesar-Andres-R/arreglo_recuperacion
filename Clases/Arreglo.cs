using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace arreglo_recuperacion.Clases
{
    public class Arreglo
    {
        
        struct ProductoYPrecio
        {
            public string Nombre;
            public double Precio;
        }
        ProductoYPrecio[] productos = new ProductoYPrecio[10];


        public void Insertar()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el producto = ");
                string nombreProducto = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del producto");
                int precioProducto;
                while (!int.TryParse(Console.ReadLine(), out precioProducto))
                {
                    Console.WriteLine("Ingrese un precio válido.");
                }

                productos[i] = new ProductoYPrecio { Nombre = nombreProducto, Precio = precioProducto };
            }
        }


        public void Mostrar()
        {
            Console.WriteLine("");
            Console.WriteLine("Productos del arreglo = ");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"{productos[i].Nombre}, precio es : {productos[i].Precio}");
            }
        }


        public void OrdenarPrecios()
        {
            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = i + 1; j < productos.Length; j++)
                {
                    if (productos[i].Precio > productos[j].Precio)
                    {
                        ProductoYPrecio tempProducto = productos[i];
                        productos[i] = productos[j];
                        productos[j] = tempProducto;
                    }
                }
            }
        }

        //Esto no me sirve
        //public void OrdenarPreciosDes()
        //{
        //    for (int i = 0; i > precios.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j > precios.Length; j++)
        //        {
        //            if (precios[i] < precios[j])
        //            {
        //                double tempPrecio = precios[i];
        //                precios[i] = precios[j];
        //                precios[j] = tempPrecio;


        //                string tempProducto = productos[i];
        //                productos[i] = productos[j];
        //                productos[j] = tempProducto;
        //            }
        //        }
        //    }
        //}



        public void MostrarOrden()
        {
            OrdenarPrecios();
            Mostrar();
        }


        //Esto tampoco me sirve
        //public void MostrarDes() 
        //{
        //    OrdenarPreciosDes();
        //    Mostrar();
        //}


        public void BuscarPorPrecio()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el precio a buscar");
            int precioBuscar;
            while (!int.TryParse(Console.ReadLine(), out precioBuscar))
            {
                Console.WriteLine("Ingrese un precio válido.");
            }

            bool encontrado = false;

            Console.WriteLine($"Productos con precios {precioBuscar}: ");
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Precio == precioBuscar)
                {
                    Console.WriteLine($"{productos[i].Nombre}, precio es : {productos[i].Precio}");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"No se encontró ningún producto con ese precio.");
            }
        }
    }
}