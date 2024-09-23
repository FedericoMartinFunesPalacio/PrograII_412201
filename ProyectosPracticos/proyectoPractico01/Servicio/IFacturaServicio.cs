using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Servicio
{
    public interface IFacturaServicio
    {
        public bool Delete(int id);
        public bool Registrar_Editar(Facturas oFactura);
        public List<Facturas> GetAll();
        public List<Facturas> ConsultarFactura(int id);
    }
}
