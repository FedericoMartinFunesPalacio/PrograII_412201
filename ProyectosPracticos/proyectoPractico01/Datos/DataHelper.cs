using proyectoPractico01.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPractico01.Datos
{
    public class DataHelper
    {
        //SINGLETON
        private static DataHelper instancia;
        private SqlConnection conexion;

        private DataHelper()
        {
            conexion = new SqlConnection("Data Source=FEDEPC\\SQLEXPRESSFEDE;Initial Catalog=proyectoPractico01;Integrated Security=True");
        }

        public static DataHelper GetInstance() 
        {
            if (instancia == null)
            {
                instancia = new DataHelper();
            }
            return instancia;
        }
        //FIN SINGLETON
        //DEMAS METODOS
        public DataTable ExecSPQuery(string nombreSP, List<Parametros> parametros)
        {
            DataTable tabla = new DataTable();

            conexion.Open();

            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            if (parametros != null)
            {
                foreach (var param in parametros)
                {
                    comando.Parameters.AddWithValue(param.Parametro, param.Objeto);
                }
            }
            tabla.Load(comando.ExecuteReader());

            conexion.Close(); 
            return tabla;
        }

        public int ExecSPDML(string nombreSP, List<Parametros> parametros)
        {
            int filasAfectadas;

            conexion.Open();

            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            if (parametros != null)
            {
                foreach (var param in parametros)
                {
                    comando.Parameters.AddWithValue(param.Parametro, param.Objeto);
                }
            }
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
        }
    }
}
