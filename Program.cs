using arreglo_recuperacion.Clases;
using System;

namespace arreglo_recuperacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arreglo arreglo = new Arreglo();

            arreglo.Insertar();


            arreglo.Mostrar();


            arreglo.MostrarOrden();


            arreglo.BuscarPorPrecio();
        }
    }
}