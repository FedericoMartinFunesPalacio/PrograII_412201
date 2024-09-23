using proyectoPractico01.Datos.Factura;
using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Servicio
{
    public class FacturasServicio:IFacturaServicio
    {
        private IFacturaRepository instancia;

        public FacturasServicio()
        {
            instancia = new FacturaRepository_ADO();
        }

        public bool Delete(int id)
        {
            return instancia.Delete(id);
        }
        public bool Registrar_Editar(Facturas oFactura)
        {
            return instancia.Registrar_Editar(oFactura);
        }
        public List<Facturas> GetAll()
        {
            return instancia.GetAll();
        }
        public List<Facturas> ConsultarFactura(int id)
        {
            return instancia.ConsultarFactura(id);
        }
    }
}
