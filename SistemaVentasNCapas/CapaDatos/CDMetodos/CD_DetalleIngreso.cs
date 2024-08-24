using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.CDMetodos
{
    public class CD_DetalleIngreso
    {
        //Atributos
        private int _ID_DetalleIngreso;
        private int _ID_Ingreso;
        private int _ID_Producto;
        private decimal _PrecioCompra;
        private decimal _PrecioVenta;
        private int _StockInicial;
        private int _StockActual;
        private DateTime _FechaProduccion;
        private DateTime _FechaVencimiento;

        public int ID_DetalleIngreso 
        {
            get { return _ID_DetalleIngreso; }
            set { _ID_DetalleIngreso = value; }
        }

        public int ID_Ingreso
        {
            get { return _ID_Ingreso; }
            set { _ID_Ingreso = value; }
        }

        public int ID_Producto
        {
            get { return _ID_Producto; }
            set { _ID_Producto = value; }
        }

        public decimal PrecioCompra
        {
            get { return _PrecioCompra; }
            set { _PrecioCompra = value; }
        }
        public decimal PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        public int StockInicial
        {
            get { return _StockInicial; }
            set { _StockInicial = value; }
        }

        public int StockActual
        {
            get { return _StockActual; }
            set { _StockActual = value; }
        }

        public DateTime FechaProduccion
        {
            get { return _FechaProduccion; }
            set { _FechaProduccion = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = value; }
        }

        //Constructores
        public CD_DetalleIngreso()
        {

        }

        public CD_DetalleIngreso(int idDetalleIngreso, int idIngreso, int idProducto, decimal precioCompra, decimal precioVenta,
            int stockInicial, int stosckActual, DateTime fechaProduccion, DateTime fechaVencimiento)
        {
            this.ID_DetalleIngreso = idDetalleIngreso;
            this.ID_Ingreso = idIngreso;
            this.ID_Producto = idProducto;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
            this.StockInicial = stockInicial;
            this.StockActual = stosckActual;
            this.FechaProduccion = fechaProduccion;
            this.FechaVencimiento = fechaVencimiento;
        }

        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_DetalleIngreso detalleIngreso, 
            ref SqlConnection sqlConn, ref SqlTransaction sqlTrans)
        {
            string respu = "";

            // Utilizar un capturador der errores
            try
            {
                // Establecer comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.Transaction = sqlTrans;
                cmd.CommandText = "spInsertarDetalleIngreso";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdDetalleIngreso = new SqlParameter();
                parIdDetalleIngreso.ParameterName = "@ID_DETALLE_INGRESO";
                parIdDetalleIngreso.SqlDbType = SqlDbType.Int;
                parIdDetalleIngreso.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdDetalleIngreso);

                SqlParameter parIdIngreso = new SqlParameter();
                parIdIngreso.ParameterName = "@ID_INGRESO";
                parIdIngreso.SqlDbType = SqlDbType.Int;
                parIdIngreso.Value = detalleIngreso.ID_Ingreso;
                cmd.Parameters.Add(parIdIngreso);

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@ID_PRODUCTO";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Value = detalleIngreso.ID_Producto;
                cmd.Parameters.Add(parIdProducto);

                SqlParameter parPrecioCompra = new SqlParameter();
                parPrecioCompra.ParameterName = "@PRECIO_COMPRA";
                parPrecioCompra.SqlDbType = SqlDbType.Money;
                parPrecioCompra.Value = detalleIngreso.PrecioCompra;
                cmd.Parameters.Add(parPrecioCompra);

                SqlParameter parPrecioVenta = new SqlParameter();
                parPrecioVenta.ParameterName = "@PRECIO_VENTA";
                parPrecioVenta.SqlDbType = SqlDbType.Money;
                parPrecioVenta.Value = detalleIngreso.PrecioVenta;
                cmd.Parameters.Add(parPrecioVenta);

                SqlParameter parStockActual = new SqlParameter();
                parStockActual.ParameterName = "@STOCK_ACTUAL";
                parStockActual.SqlDbType = SqlDbType.Int;
                parStockActual.Value = detalleIngreso.StockActual;
                cmd.Parameters.Add(parStockActual);

                SqlParameter parStockInicial = new SqlParameter();
                parStockInicial.ParameterName = "@STOCK_INICAL";
                parStockInicial.SqlDbType = SqlDbType.Int;
                parStockInicial.Value = detalleIngreso.StockInicial;
                cmd.Parameters.Add(parStockInicial);

                SqlParameter parFechaPro = new SqlParameter();
                parFechaPro.ParameterName = "@FECHA_PRODUCCION";
                parFechaPro.SqlDbType = SqlDbType.Date;
                parFechaPro.Value = detalleIngreso.FechaProduccion;
                cmd.Parameters.Add(parFechaPro);

                SqlParameter parFechaVenc = new SqlParameter();
                parFechaVenc.ParameterName = "@FECHA_VENVIMIENTO";
                parFechaVenc.SqlDbType = SqlDbType.Date;
                parFechaVenc.Value = detalleIngreso.FechaVencimiento;
                cmd.Parameters.Add(parFechaVenc);

                // Ejecutar comando
                respu = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingrreso la descripcion";
            }
            catch (Exception ex)
            {
                respu = ex.Message;
            }
            return respu;
        }
    }
}
