using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vásquez_susan
{
    class Classempleado
    {
        int nitcliente;
        String producvendido;
        int cantprodvendido;
        int subtotal;
        int total;
        private int dinerecibido;
        DateTime fhventa;
        String nomcajero;

        public int Nitcliente { get => nitcliente; set => nitcliente = value; }
        public string Producvendido { get => producvendido; set => producvendido = value; }
        public int Cantprodvendido { get => cantprodvendido; set => cantprodvendido = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int Total { get => total; set => total = value; }
        public DateTime Fhventa { get => fhventa; set => fhventa = value; }
        public string Nomcajero { get => nomcajero; set => nomcajero = value; }
    }
}
