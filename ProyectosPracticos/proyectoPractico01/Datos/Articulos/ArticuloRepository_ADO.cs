using proyectoPractico01.Dominio;
using proyectoPractico01.Datos.Articulos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos.Articulos
{
    public class ArticuloRepository_ADO : IAplication
    {
        public bool Actualizar(Dominio.Articulos oArticulo)
        {
            var Parametros = new List<Parametros>()
           {
                new Parametros("@id",oArticulo.Codigo),
               new Parametros("@nombre",oArticulo.Nombre),
               new Parametros("@precio_unitario",oArticulo.PrecioUnitario),

           };
            int filasAfectadas = DataHelper.GetInstance().ExecSPDML("SP_ACTUALIZAR_ARTICULOS", Parametros);
            return filasAfectadas > 0;
        }

        public bool Borrar(int id)
        {
            var Parametros = new List<Parametros>()
           {
                new Parametros("@id",id)

           };
            int filasAfectadas = DataHelper.GetInstance().ExecSPDML("SP_BORRAR_ARTICULOS", Parametros);
            return filasAfectadas > 0;
        }

        public bool Guardar(Dominio.Articulos oArticulo)
        {
            var Parametros = new List<Parametros>()
           {
               new Parametros("@nombre",oArticulo.Nombre),
               new Parametros("@precio_unitario",oArticulo.PrecioUnitario),

           };
            int filasAfectadas = DataHelper.GetInstance().ExecSPDML("SP_CREAR_ARTICULOS", Parametros);
            return filasAfectadas > 0;
        }

        public Dominio.Articulos TraerPorID(int id)
        {
            var parametros = new List<Parametros>()
            {
                new Parametros("@id", id)
            };

            var articulos = new Dominio.Articulos();

            if (id > 0)
            {
                DataTable tabla = DataHelper.GetInstance().ExecSPQuery("SP_ARTICULO_ID", parametros);

                if (tabla != null)
                {
                    foreach (DataRow row in tabla.Rows)
                    {
                        var articulo = new Dominio.Articulos()
                        {
                            Codigo = (int)row["id_articulo"],
                            Nombre = row["nombre"].ToString(),
                            PrecioUnitario = (int)(row["precio_unitario"])
                        };
                        articulos = articulo;
                    }
                }
            }

            return articulos;
        }

        public List<Dominio.Articulos> TraerTodos()
        {
            var Articulos = new List<Dominio.Articulos>();
            DataTable tabla = DataHelper.GetInstance().ExecSPQuery("SP_MOSTRAR_ARTICULOS", null);

            if (tabla != null)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    var Articulo = new Dominio.Articulos()
                    {
                        Codigo = (int)row["id_articulo"],
                        Nombre = row["nombre"].ToString(),
                        PrecioUnitario = (int)(row["precio_unitario"])

                    };
                    Articulos.Add(Articulo);
                }
            }
            return Articulos;
        }
    }
}
