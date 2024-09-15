using proyectoPractico02.Models;
using System.Data;

namespace proyectoPractico02.Data
{
    public class ArticulosRepository_ADO : IAplication
    {
        public bool Actualizar(Articulos oArticulo)
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

        public bool Guardar(Articulos oArticulo)
        {
            var Parametros = new List<Parametros>()
           {
               new Parametros("@nombre",oArticulo.Nombre),
               new Parametros("@precio_unitario",oArticulo.PrecioUnitario),

           };
            int filasAfectadas = DataHelper.GetInstance().ExecSPDML("SP_CREAR_ARTICULOS", Parametros);
            return filasAfectadas > 0;
        }

        public List<Articulos> TraerPorID(int id)
        {
            var parametros = new List<Parametros>()
            {
                new Parametros("@id", id)
            };

            var articulos = new List<Articulos>();

            if (id > 0)
            {
                DataTable tabla = DataHelper.GetInstance().ExecSPQuery("SP_ARTICULO_ID", parametros);

                if (tabla != null)
                {
                    foreach (DataRow row in tabla.Rows)
                    {
                        var articulo = new Articulos()
                        {
                            Codigo = (int)row["id_articulo"],
                            Nombre = row["nombre"].ToString(),
                            PrecioUnitario = (int)(row["precio_unitario"])
                        };
                        articulos.Add(articulo);
                    }
                }
            }

            return articulos;
        }

        public List<Articulos> TraerTodos()
        {
            var Articulos = new List<Articulos>();
            DataTable tabla = DataHelper.GetInstance().ExecSPQuery("SP_MOSTRAR_ARTICULOS", null);

            if (tabla != null)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    var Articulo = new Articulos()
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
