using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importarlibrerias
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.CDMetodos
{
    public class CD_UMedida
    {
        //Declaracion y encapsulacion de los atributos y constructuctores de la clase
        private int _ID_UMEDIDA;
        private string _UNIDAD_MEDIDA;
        private bool _ESTADO;
        private string _TEXTOBUSCAR;

        public int ID_UMEDIDA
        {
            get { return _ID_UMEDIDA; }
            set { _ID_UMEDIDA = value; }
        }
        public string UNIDAD_MEDIDA
        {
            get { return _UNIDAD_MEDIDA; }
            set { _UNIDAD_MEDIDA = value; }
        }
        public bool ESTADO
        {
            get { return _ESTADO; }
            set { _ESTADO = value; }
        }
        public string TEXTOBUSCAR
        {
            get { return _TEXTOBUSCAR; }
            set { _TEXTOBUSCAR = value; }
        }

        public CD_UMedida()
        {

        }

        public CD_UMedida(int idUMedida, string unidadMedida, bool estado, string textoBuscar)
        {
            this.ID_UMEDIDA = idUMedida;
            this.UNIDAD_MEDIDA = unidadMedida;
            this.ESTADO = estado;
            this.TEXTOBUSCAR = textoBuscar;
        }

        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_UMedida NMedida)
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
                cmd.CommandText = "spAgregar_Umedida";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdUMedida = new SqlParameter();
                parIdUMedida.ParameterName = "@ID_UMEDIDA";
                parIdUMedida.SqlDbType = SqlDbType.Int;
                parIdUMedida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdUMedida);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@UNIDAD_MEDIDA";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = NMedida.UNIDAD_MEDIDA;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = NMedida.ESTADO;
                cmd.Parameters.Add(parEstado);

                // Ejecutar comando
                respu = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingrreso la descripcion";
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

        //Actualizar
        public string Actualizar(CD_UMedida NMedida)
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
                cmd.CommandText = "spActualizar_Umedida";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdUMedida = new SqlParameter();
                parIdUMedida.ParameterName = "@ID_UMEDIDA";
                parIdUMedida.SqlDbType = SqlDbType.Int;
                parIdUMedida.Value = NMedida.ID_UMEDIDA;
                cmd.Parameters.Add(parIdUMedida);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@UNIDAD_MEDIDA";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = NMedida.UNIDAD_MEDIDA;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = NMedida.ESTADO;
                cmd.Parameters.Add(parEstado);

                // Ejecutar comando
                respu = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se edito la descripcion";
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

        //Eliminar
        public string Eliminar(CD_UMedida NMedida)
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
                cmd.CommandText = "spEliminar_Umedida";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNProducto = new SqlParameter();
                parIdNProducto.ParameterName = "@ID_UMEDIDA";
                parIdNProducto.SqlDbType = SqlDbType.Int;
                parIdNProducto.Value = NMedida.ID_UMEDIDA;
                cmd.Parameters.Add(parIdNProducto);

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
            DataTable dt = new DataTable("UMEDIDA");
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
                cmd.CommandText = "spMostrar_Umedida";
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
        public DataTable Buscar(CD_UMedida NMedida)
        {
            DataTable dt = new DataTable("UMEDIDA");
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
                cmd.CommandText = "spBuscar_Umedida";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = NMedida.TEXTOBUSCAR;
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
