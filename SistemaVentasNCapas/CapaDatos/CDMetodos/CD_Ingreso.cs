using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.CDMetodos
{
    public class CD_Ingreso
    {
        private int _ID_Ingreso;
        private int _IdTrabajador;
        private int _Idproveedor;
        private DateTime _Fecha;
        private string _Estado;

        public int ID_Ingreso
        {
            get { return _ID_Ingreso; }
            set { _ID_Ingreso = value; }
        }

        public int IdTrabajador
        {
            get { return _IdTrabajador; }
            set { _IdTrabajador = value; }
        }

        public int Idproveedor
        {
            get { return _Idproveedor; }
            set { _Idproveedor = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        //Constructores
        public CD_Ingreso()
        {

        }
        public CD_Ingreso(int idingreso, int idTrabajador, int idProveedor, DateTime fecha, string estado)
        {
            this.ID_Ingreso = idingreso;
            this.IdTrabajador = idTrabajador;
            this.Idproveedor = idProveedor;
            this.Fecha = fecha;
            this.Estado = estado;
        }

        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_Ingreso ingreso, List<CD_DetalleIngreso> Detalle)
        {
            string respu = "";
            SqlConnection conn = new SqlConnection();

            // Utilizar un capturador der errores
            try
            {
                // Codigo
                conn.ConnectionString = ClassConexion.Cn;
                conn.Open();

                // Transaccion
                SqlTransaction sqlTrans = conn.BeginTransaction();

                // Establecer comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = sqlTrans; 
                cmd.CommandText = "spInsertarIngreso";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdIngreso = new SqlParameter();
                parIdIngreso.ParameterName = "@ID_INGRESO";
                parIdIngreso.SqlDbType = SqlDbType.Int;
                parIdIngreso.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdIngreso);

                SqlParameter parIdEmpleado = new SqlParameter();
                parIdEmpleado.ParameterName = "@ID_EMPLEADO";
                parIdEmpleado.SqlDbType = SqlDbType.Int;
                parIdEmpleado.Value = ingreso.IdTrabajador;
                cmd.Parameters.Add(parIdEmpleado);

                SqlParameter parIdProveedor = new SqlParameter();
                parIdProveedor.ParameterName = "@ID_PROVEEDOR";
                parIdProveedor.SqlDbType = SqlDbType.Int;
                parIdProveedor.Value = ingreso.Idproveedor;
                cmd.Parameters.Add(parIdProveedor);

                SqlParameter parFecha = new SqlParameter();
                parFecha.ParameterName = "@FECHA";
                parFecha.SqlDbType = SqlDbType.Date;
                parFecha.Value = ingreso.Fecha;
                cmd.Parameters.Add(parFecha);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@Estado";
                parEstado.SqlDbType = SqlDbType.VarChar;
                parEstado.Size = 7;
                parEstado.Value = ingreso.Estado;
                cmd.Parameters.Add(parEstado);

                // Ejecutar comando
                respu = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingrreso la descripcion";
                if (respu.Equals("OK"))
                {
                    this.ID_Ingreso = Convert.ToInt32(cmd.Parameters["@ID_INGRESO"].Value);

                    foreach (CD_DetalleIngreso detll in Detalle)
                    {
                        detll.ID_Ingreso = this.ID_Ingreso;
                        //llamar metodo insertar
                        respu = detll.Insertar(detll, ref conn, ref sqlTrans);
                        if (!respu.Equals("OK"))
                        {
                            break;
                        }
                    }
                }

                if (respu.Equals("OK"))
                {
                    sqlTrans.Commit();
                }
                else
                {
                    sqlTrans.Rollback();
                }
            }
            catch (Exception ex)
            {
                respu = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respu;
        }

        //Anular
        public string Anular(CD_Ingreso ingreso)
        {
            string respu = "";
            SqlConnection conn = new SqlConnection();

            // Utilizar un capturador der errores
            try
            {
                // Codigo
                conn.ConnectionString = ClassConexion.Cn;
                conn.Open();

                // Establecer comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spAnularIngreso";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdIngreso = new SqlParameter();
                parIdIngreso.ParameterName = "@ID_INGRESO";
                parIdIngreso.SqlDbType = SqlDbType.Int;
                parIdIngreso.Value = ingreso.ID_Ingreso;
                cmd.Parameters.Add(parIdIngreso);

                // Ejecutar comando
                respu = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino la descripcion";
            }
            catch (Exception ex)
            {
                respu = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respu;
        }

        //Mostrar
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable("INGRESO");
            SqlConnection conn = new SqlConnection();
            // Utilizar un capturador der errores
            try
            {
                // Codigo
                conn.ConnectionString = ClassConexion.Cn;
                conn.Open();

                // Establecer comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spMpstrarIngreso";
                cmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar comando
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return dt;
        }

        //Buscar
        public DataTable Buscar(string textoBuscar, string textoBuscar2)
        {
            DataTable dt = new DataTable("INGRESO");
            SqlConnection conn = new SqlConnection();
            // Utilizar un capturador der errores
            try
            {
                // Codigo
                conn.ConnectionString = ClassConexion.Cn;
                conn.Open();

                // Establecer comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spBuscarIngreso";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 20;
                parTextBuscar.Value = textoBuscar;
                cmd.Parameters.Add(parTextBuscar);

                SqlParameter parTextBuscar2 = new SqlParameter();
                parTextBuscar2.ParameterName = "@textoBuscar2";
                parTextBuscar2.SqlDbType = SqlDbType.VarChar;
                parTextBuscar2.Size = 20;
                parTextBuscar2.Value = textoBuscar2;
                cmd.Parameters.Add(parTextBuscar2);

                // Ejecutar comando
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return dt;
        }

        public DataTable MostrarDetalle(string textoBuscar)
        {
            DataTable dt = new DataTable("DETALLE_INGRESO");
            SqlConnection conn = new SqlConnection();
            // Utilizar un capturador der errores
            try
            {
                // Codigo
                conn.ConnectionString = ClassConexion.Cn;
                conn.Open();

                // Establecer comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "spMostrarDetelleIngreso";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 20;
                parTextBuscar.Value = textoBuscar;
                cmd.Parameters.Add(parTextBuscar);

                // Ejecutar comando
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return dt;
        }
    }
}
