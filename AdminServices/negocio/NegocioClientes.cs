using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class NegocioClientes
    {
        public List<Clientes> ListClients()
        {
            List<Clientes> clientes = new List<Clientes>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT Id, Nombre, FechaServicio, LugarServicio, Pago, Celular, Mail,Descripcion, Activo FROM CLIENTES WHERE Activo=1;";
                datos.nuevaConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Clientes cliente = MapearClientes(datos.Lector);
                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.terminarConexion();
            }

        }
        public void NewClient(Clientes clientes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "insert into CLIENTES(Nombre, FechaServicio, LugarServicio, Pago, Celular, Mail,Descripcion,Activo) VALUES(@Nombre,@FechaServicio,@LugarServicio,@Pago,@Celular,@Mail,@Descripcion,1);";
                
                datos.Parametro("@Nombre", clientes.NombreCliente);
                datos.Parametro("@FechaServicio", clientes.FechaServicio);
                datos.Parametro("@LugarServicio", clientes.LugarServicio);                
                datos.Parametro("@Pago", clientes.PagoRecibido);
                datos.Parametro("@Celular", clientes.Celular);
                datos.Parametro("@Mail", clientes.Mail);
                datos.Parametro("@Descripcion", clientes.Descripcion);
                datos.nuevaConsulta(consulta);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                datos.terminarConexion();
            }
        }
        public void UpdateClient(Clientes clientes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "update CLIENTES SET Nombre=@Nombre,FechaServicio=@FechaServicio,LugarServicio=@LugarServicio, Pago=@Pago,Celular=@Celular,Mail=@Mail, Descripcion=@Descripcion WHERE id =@IdCliente;";
                datos.Parametro("@Nombre", clientes.NombreCliente);
                datos.Parametro("@FechaServicio", clientes.FechaServicio);
                datos.Parametro("@LugarServicio", clientes.LugarServicio);
                datos.Parametro("@Pago", clientes.PagoRecibido);
                datos.Parametro("@Celular", clientes.Celular);
                datos.Parametro("@Mail", clientes.Mail);
                datos.Parametro("@Descripcion", clientes.Descripcion);
                datos.Parametro("@IdCliente", clientes.Id);
                datos.nuevaConsulta(consulta);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.terminarConexion(); }
        }
        public void DeleteClient(Clientes clientes) {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.nuevaConsulta("update CLIENTES set Activo = 0 where id = @IdClientes");
                datos.Parametro("@IdClientes", clientes.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
        }

        public void getDeletedClients()
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

               //Desarrollar query
            }
            catch (Exception ex) { throw ex; }
        }
        //Clase help
        public Clientes MapearClientes(IDataReader lector) {
            return new Clientes
            {
                Id = (int)lector["Id"],
                NombreCliente = (string)lector["Nombre"],
                PagoRecibido = (decimal)lector["Pago"],
                FechaServicio = (DateTime)lector["FechaServicio"],
                LugarServicio = (string)lector["LugarServicio"],
                Celular = (int)lector["Celular"],
                Mail = (string)lector["Mail"],
                Descripcion = (string)lector["Descripcion"]
            };
        } 


    }
}
