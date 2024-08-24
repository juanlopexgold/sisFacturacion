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
    public class CN_UMedida
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(string nombre, bool estado)
        {
            CD_UMedida Obj = new CD_UMedida();
            Obj.UNIDAD_MEDIDA = nombre;
            Obj.ESTADO = estado;

            return Obj.Insertar(Obj);
        }

        // Metodo editar que llama el metodo editar de la capa datos
        public static string Actualizar(int idNMedida, string nombre, bool estado)
        {
            CD_UMedida Obj = new CD_UMedida();
            Obj.ID_UMEDIDA = idNMedida;
            Obj.UNIDAD_MEDIDA = nombre;
            Obj.ESTADO = estado;

            return Obj.Actualizar(Obj);
        }

        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Eliminar(int idNMedida)
        {
            CD_UMedida Obj = new CD_UMedida();
            Obj.ID_UMEDIDA = idNMedida;

            return Obj.Eliminar(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_UMedida().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto)
        {
            CD_UMedida obj = new CD_UMedida();
            obj.TEXTOBUSCAR = texto;

            return obj.Buscar(obj);
        }
    }
}
