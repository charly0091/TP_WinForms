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
                    aux.Avatar = (string)datos.Lector["Avatar"];

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
    }
}

