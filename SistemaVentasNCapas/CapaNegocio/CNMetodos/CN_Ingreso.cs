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
    class CN_Ingreso
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(int idTrabajador, int idProveedor, DateTime fecha, string estado, DataTable dtDetalles)
        {
            CD_Ingreso Obj = new CD_Ingreso();
            Obj.IdTrabajador = idTrabajador;
            Obj.Idproveedor = idProveedor;
            Obj.Fecha = fecha;
            Obj.Estado = estado;

            List<CD_DetalleIngreso> Detalle = new List<CD_DetalleIngreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                CD_DetalleIngreso detalle = new CD_DetalleIngreso();
                detalle.ID_Producto = Convert.ToInt32(row["ID_PRODUCTO"].ToString());
                detalle.PrecioCompra = Convert.ToDecimal(row["PRECIO_COMPRA"].ToString());
                detalle.PrecioVenta = Convert.ToDecimal(row["PRECIO_VENTA"].ToString());
                detalle.StockInicial = Convert.ToInt32(row["STOCK_INICAL"].ToString());
                detalle.StockActual = Convert.ToInt32(row["STOCK_ACTUAL"].ToString());
                detalle.FechaProduccion = Convert.ToDateTime(row["FECHA_PRODUCCION"].ToString());
                detalle.FechaVencimiento = Convert.ToDateTime(row["FECHA_VENVIMIENTO"].ToString());
                Detalle.Add(detalle);
            }

            return Obj.Insertar(Obj,Detalle);
        }


        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Anular(int idIngreso)
        {
            CD_Ingreso Obj = new CD_Ingreso();
            Obj.ID_Ingreso = idIngreso;

            return Obj.Anular(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_Ingreso().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto1, string texto2)
        {
            CD_Ingreso obj = new CD_Ingreso();

            return obj.Buscar(texto1,texto2);
        }

        public static DataTable MostrarDetalle(string texto1)
        {
            CD_Ingreso obj = new CD_Ingreso();
            return obj.MostrarDetalle(texto1);
        }
    }
}
