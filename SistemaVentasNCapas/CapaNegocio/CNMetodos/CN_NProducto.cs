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
    public class CN_NProducto
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(string nombre, bool estado)
        {
            CD_NProducto Obj = new CD_NProducto();
            Obj.NOMBRE_PRODUCTO = nombre;
            Obj.ESTADO = estado;

            return Obj.Insertar(Obj);
        }

        // Metodo editar que llama el metodo editar de la capa datos
        public static string Actualizar(int idNProducto, string nombre, bool estado)
        {
            CD_NProducto Obj = new CD_NProducto();
            Obj.ID_NPRODUCTO = idNProducto;
            Obj.NOMBRE_PRODUCTO = nombre;
            Obj.ESTADO = estado;

            return Obj.Actualizar(Obj);
        }

        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Eliminar(int idNProducto)
        {
            CD_NProducto Obj = new CD_NProducto();
            Obj.ID_NPRODUCTO = idNProducto;

            return Obj.Eliminar(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_NProducto().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto)
        {
            CD_NProducto obj = new CD_NProducto();
            obj.TEXTOBUSCAR = texto;

            return obj.Buscar(obj);
        }
    }
}
