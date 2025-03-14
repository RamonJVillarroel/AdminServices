using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    internal class AccesoDatos
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=ADMIN_CLIENT_DB; integrated security= true");
            command = new SqlCommand();
        }
        public void nuevaConsulta(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                lector = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }

        }
        public void Parametro(string parameter, object value)
        {
            command.Parameters.AddWithValue(parameter,value);
        }
        public void terminarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            connection.Close();
        }
    }
}
