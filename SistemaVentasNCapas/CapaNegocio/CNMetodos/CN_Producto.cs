using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importarlibrerias
using CapaDatos.CDMetodos;
using System.Data;

namespace CapaNegocio.CNMetodos
{
    public class CN_Producto
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(int idNProducto, int idCategoria, int idMarca, string descripcion, int idUMedida, bool estado)
        {
            CD_Producto Obj = new CD_Producto();
            Obj.ID_NPRODUCTO = idNProducto;
            Obj.ID_CATEGORIAS = idCategoria;
            Obj.ID_MARCA = idMarca;
            Obj.DESCRIPCION = descripcion;
            Obj.ID_U_MEDIDA = idUMedida;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }

        // Metodo editar que llama el metodo editar de la capa datos
        public static string Actualizar(int idProducto, int idNProducto, int idCategoria, int idMarca, string descripcion, int idUMedida, bool estado)
        {
            CD_Producto Obj = new CD_Producto();
            Obj.ID_PRODUCTOS = idProducto;
            Obj.ID_NPRODUCTO = idNProducto;
            Obj.ID_CATEGORIAS = idCategoria;
            Obj.ID_MARCA = idMarca;
            Obj.DESCRIPCION = descripcion;
            Obj.ID_U_MEDIDA = idUMedida;
            Obj.Estado = estado;

            return Obj.Actualizar(Obj);
        }

        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Eliminar(int idNProducto)
        {
            CD_Producto Obj = new CD_Producto();
            Obj.ID_NPRODUCTO = idNProducto;

            return Obj.Eliminar(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_Producto().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto)
        {
            CD_Producto obj = new CD_Producto();
            obj.TextoBuscar = texto;

            return obj.Buscar(obj);
        }
    }
}
