using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Dominio
{
    public class Facturas
    {
        //ATRIBUTOS
        private int idFactura;
        private int idDetalle;
        private string cliente;
        private int idArticulo;
        private int precioUnitario;
        private int cantidad;
        private int idFormaPago;
        private DateTime fecha;

        //Props
        public int IdFactura { get { return idFactura; } set { idFactura = value; } }
        public int IdDetalle { get { return idDetalle; } set { idDetalle = value; } }
        public string Cliente { get { return cliente; } set { cliente = value; } }
        public int IdArticulo { get { return idArticulo; } set { idArticulo = value; } }
        public int PrecioUnitario { get { return precioUnitario; } set { precioUnitario = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public int IdFormaPago { get { return idFormaPago; } set { idFormaPago = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }

        //METODOS
        public override string ToString()
        {
            return "NUMERO FACTURA: " + IdFactura + ", CLIENTE: " + Cliente + ", FORMA DE PAGO: " + IdFormaPago +
                   ", ARTICULO, PRECIO Y CANTIDAD: " + IdArticulo + ", $" + PrecioUnitario + ", " + Cantidad;
        }
    }
}
