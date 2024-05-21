using Entidades;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using static Entidades.Documento;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escaner escanerLibro = new Escaner("Marca patito", Escaner.TipoDoc.libro);

            Libro l1 = new Libro("TituloLibro1", "Yo1", 2024, "123", "0123", 20);

            l1.AvanzarEstado();
            l1.AvanzarEstado();
            l1.AvanzarEstado();
            l1.AvanzarEstado();
            try
            {
                l1.AvanzarEstado();
            }
            catch (AvanzarEstadoTerminadoException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message} \n Producida en el metodo: {ex.NombreMetodo}" +
                    $" \n Metodo de la clase: {ex.InnerException?.Message}");
            }

            Console.WriteLine();
            Console.WriteLine($"Estado del libro: {l1.Estado}");
        }

    }
}
