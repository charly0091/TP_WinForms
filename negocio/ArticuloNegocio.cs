using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Articulos.Id,Articulos.Codigo,Articulos.Nombre,Articulos.Descripcion,Articulos.Precio,Marcas.Descripcion as Marca,Categorias.Descripcion as Categoria,Imagenes.ImagenUrl From Articulos\r\ninner join Marcas on Marcas.Id = Articulos.IdMarca\r\ninner join Categorias on Categorias.Id = Articulos.IdCategoria\r\ninner join Imagenes on Imagenes.IdArticulo = Articulos.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion= (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.ImagenUrl= (string)datos.Lector["ImagenUrl"];

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
