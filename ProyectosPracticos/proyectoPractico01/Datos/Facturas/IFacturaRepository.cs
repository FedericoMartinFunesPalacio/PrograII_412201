using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos.Factura
{
    public interface IFacturaRepository
    {
        List<Facturas> GetAll();
        List<Facturas> ConsultarFactura(int id);
        bool Registrar_Editar(Facturas oFacturas);
        bool Delete(int id);
    }
}
