using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos
{
    public interface IFacturaRepository
    {
        List<Facturas> GetAll();
        List<Facturas> GetForID(int id);
        bool Save(Facturas oFacturas);
        bool Delete(int id);
    }
}
