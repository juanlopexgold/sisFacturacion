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
    public class CN_Categorias
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(string nombre, bool estado)
        {
            CD_Categorias Obj = new CD_Categorias();
            Obj.NOMBRE_CATEGORIA = nombre;
            Obj.ESTADO = estado;

            return Obj.Insertar(Obj);
        }

        // Metodo editar que llama el metodo editar de la capa datos
        public static string Actualizar(int idCategoria, string nombre, bool estado)
        {
            CD_Categorias Obj = new CD_Categorias();
            Obj.ID_CATEGORIA = idCategoria;
            Obj.NOMBRE_CATEGORIA = nombre;
            Obj.ESTADO = estado;

            return Obj.Actualizar(Obj);
        }

        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Eliminar(int idCategoria)
        {
            CD_Categorias Obj = new CD_Categorias();
            Obj.ID_CATEGORIA = idCategoria;

            return Obj.Eliminar(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_Categorias().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto)
        {
            CD_Categorias obj = new CD_Categorias();
            obj.TEXTOBUSCAR = texto;

            return obj.Buscar(obj);
        }
    }
}
