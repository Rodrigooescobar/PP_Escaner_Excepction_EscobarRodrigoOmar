using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AvanzarEstadoTerminadoException : Exception
    {
        string nombreMetodo;

        public AvanzarEstadoTerminadoException(string mensaje, string metodo, Exception innerExepction)
            : base(mensaje, innerExepction)
        {
            this.nombreMetodo = metodo;
        }

        public string NombreMetodo { get => nombreMetodo;}


        //string nombreMetodo;
        //string nombreClase;

        //public AvanzarEstadoTerminadoException(string mensaje, string metodo, Exception argumentException)
        //    : base(mensaje, argumentException)
        //{
        //    this.nombreMetodo = metodo;
        //    this.nombreClase = argumentException.Message;
        //}

        //public string NombreMetodo { get => nombreMetodo; }
        //public string NombreClase { get => nombreClase; set => nombreClase = value; }
    }
}
