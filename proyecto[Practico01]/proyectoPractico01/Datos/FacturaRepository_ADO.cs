using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos
{
    public class FacturaRepository_ADO : IFacturaRepository
    {
        private DataHelper Datos;

        public FacturaRepository_ADO()
        {
            Datos = DataHelper.getInstance();
        }
        public bool Delete(int id)
        {
            string nombreSP = "SP_BORRAR_FACTURAS";
            List<Parametros> parametros = new List<Parametros>();

            parametros.Add(new Parametros("@id_factura", id));

            int filasAfectadas = Datos.ExecSPDML(nombreSP, parametros);
            if (filasAfectadas != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Facturas> GetAll()
        {
            string nombreSP = "SP_TRAER_FACTURA";
            List<Facturas> lista = new List<Facturas>();

            DataTable tabla = Datos.ExecSPQuery(nombreSP, null);

            foreach (DataRow item in tabla.Rows)
            {
                Facturas oFactura = new Facturas();
                oFactura.IdFactura = (int)item["id_factura"];
                oFactura.IdDetalle = (int)item["id_detalle_factura"];
                oFactura.Cliente = item["cliente"].ToString();
                oFactura.IdArticulo = (int)item["id_articulo"];
                oFactura.PrecioUnitario = (int)item["precio_unitario"];
                oFactura.Cantidad = (int)item["cantidad"];
                oFactura.IdFormaPago = (int)item["id_forma_pago"];

                lista.Add(oFactura);
            }
            return lista;
        }

        public List<Facturas> GetForID(int id)
        {
            string nombreSP = "SP_TRAER_FACTURA_POR_ID";
            List<Facturas> lista = new List<Facturas>();

            List<Parametros> parametros = new List<Parametros>();

            parametros.Add(new Parametros("@id_factura", id));

            DataTable tabla = Datos.ExecSPQuery(nombreSP, parametros);
            foreach (DataRow item in tabla.Rows)
            {

                Facturas oFactura = new Facturas();
                oFactura.IdFactura = (int)item["id_factura"];
                oFactura.IdDetalle = (int)item["id_detalle_factura"];
                oFactura.Cliente = item["cliente"].ToString();
                oFactura.IdArticulo = (int)item["id_articulo"];
                oFactura.PrecioUnitario = (int)item["precio_unitario"];
                oFactura.Cantidad = (int)item["cantidad"];
                oFactura.IdFormaPago = (int)item["id_forma_pago"];

                lista.Add(oFactura);
            }
            return lista;
        }

        public bool Save(Facturas oFacturas)
        {
            string nombreSP = "SP_GUARDAR_FACTURA";
            List<Parametros> parametros = new List<Parametros>();

            parametros.Add(new Parametros("@id_factura", oFacturas.IdFactura));
            parametros.Add(new Parametros("@cliente", oFacturas.Cliente));
            parametros.Add(new Parametros("@id_articulo", oFacturas.IdArticulo));
            parametros.Add(new Parametros("@cantidad", oFacturas.Cantidad));
            parametros.Add(new Parametros("@id_forma_pago", oFacturas.IdFormaPago));
            parametros.Add(new Parametros("@fecha", oFacturas.Fecha));

            int filasAfectadas = Datos.ExecSPDML(nombreSP, parametros);
            if (filasAfectadas != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
