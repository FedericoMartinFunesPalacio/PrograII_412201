using proyectoPractico01.Datos;
using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Servicio
{
    public class FacturasServicio
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
        public bool Save(Facturas oFactura)
        {
            return instancia.Save(oFactura);
        }
        public List<Facturas> GetAll()
        {
            return instancia.GetAll();
        }
        public List<Facturas> GetForID(int id)
        {
            return instancia.GetForID(id);
        }
    }
}
