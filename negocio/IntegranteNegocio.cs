using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class IntegranteNegocio
    {
        public List<Integrante> Listar()
        {
            List<Integrante> lista = new List<Integrante>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id,Legajo,Nombre,Apellido,Avatar from Integrantes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Integrante aux = new Integrante();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Legajo = (int)datos.Lector["Legajo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    if (!(datos.Lector["Avatar"]is DBNull))
                    {
                        aux.Avatar = (string)datos.Lector["Avatar"];
                    }

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Integrante nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Integrantes(Legajo,Nombre,Apellido,Avatar)Values(@Legajo,@Nombre,@Apellido,@Avatar)");
                datos.setearParametro("@Legajo", nuevo.Legajo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Avatar", nuevo.Avatar);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Integrante nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Integrantes set Legajo=@Legajo,Nombre=@Nombre,Apellido=@Apellido,Avatar=@Avatar Where Id=@Id");
                datos.setearParametro("@Legajo", nuevo.Legajo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Avatar", nuevo.Avatar);
                datos.setearParametro("@Id", nuevo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

