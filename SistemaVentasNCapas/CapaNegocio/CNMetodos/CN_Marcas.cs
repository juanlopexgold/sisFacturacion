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
    public class CN_Marcas
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(string nombre, bool estado)
        {
            CD_Marcas Obj = new CD_Marcas();
            Obj.NOMBRE_MARCA = nombre;
            Obj.ESTADO = estado;

            return Obj.Insertar(Obj);
        }

        // Metodo editar que llama el metodo editar de la capa datos
        public static string Actualizar(int idMarca, string nombre, bool estado)
        {
            CD_Marcas Obj = new CD_Marcas();
            Obj.ID_MARCA = idMarca;
            Obj.NOMBRE_MARCA = nombre;
            Obj.ESTADO = estado;

            return Obj.Actualizar(Obj);
        }

        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Eliminar(int idMarca)
        {
            CD_Marcas Obj = new CD_Marcas();
            Obj.ID_MARCA = idMarca;

            return Obj.Eliminar(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_Marcas().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto)
        {
            CD_Marcas obj = new CD_Marcas();
            obj.TEXTOBUSCAR = texto;

            return obj.Buscar(obj);
        }
    }
}
