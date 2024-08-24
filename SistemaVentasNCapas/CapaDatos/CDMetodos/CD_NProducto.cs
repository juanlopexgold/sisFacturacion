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
    public class CD_NProducto
    {
        //Declaracion y encapsulacion de los atributos y constructuctores de la clase
        private int _ID_NPRODUCTO;
        private string _NOMBRE_PRODUCTO;
        private bool _ESTADO;
        private string _TEXTOBUSCAR;

        public int ID_NPRODUCTO 
        {
            get { return _ID_NPRODUCTO; }
            set { _ID_NPRODUCTO = value; }
        }
        public string NOMBRE_PRODUCTO
        {
            get { return _NOMBRE_PRODUCTO; }
            set { _NOMBRE_PRODUCTO = value; }
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

        public CD_NProducto()
        {

        }

        public CD_NProducto(int idProducto, string nombreProducto, bool estado, string textoBuscar)
        {
            this.ID_NPRODUCTO = idProducto;
            this.NOMBRE_PRODUCTO = nombreProducto;
            this.ESTADO = estado;
            this.TEXTOBUSCAR = textoBuscar;
        }
        
        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_NProducto Productos)
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
                cmd.CommandText = "spAgregar_Nproducto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNProducto = new SqlParameter();
                parIdNProducto.ParameterName = "@ID_NPRODUCTO";
                parIdNProducto.SqlDbType = SqlDbType.Int;
                parIdNProducto.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdNProducto);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@NOMBRE_PRODUCTO";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = Productos.NOMBRE_PRODUCTO;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = Productos.ESTADO;
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
        public string Actualizar(CD_NProducto Productos)
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
                cmd.CommandText = "spActualizar_Nproducto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNProducto = new SqlParameter();
                parIdNProducto.ParameterName = "@ID_NPRODUCTO";
                parIdNProducto.SqlDbType = SqlDbType.Int;
                parIdNProducto.Value = Productos.ID_NPRODUCTO;
                cmd.Parameters.Add(parIdNProducto);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@NOMBRE_PRODUCTO";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = Productos.NOMBRE_PRODUCTO;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = Productos.ESTADO;
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
        public string Eliminar(CD_NProducto Productos)
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
                cmd.CommandText = "spEliminar_Nproducto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNProducto = new SqlParameter();
                parIdNProducto.ParameterName = "@ID_NPRODUCTO";
                parIdNProducto.SqlDbType = SqlDbType.Int;
                parIdNProducto.Value = Productos.ID_NPRODUCTO;
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
            DataTable dt = new DataTable("NPRODUCTO");
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
                cmd.CommandText = "spMostrar_Nproducto";
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
        public DataTable Buscar(CD_NProducto Productos)
        {
            DataTable dt = new DataTable("NPRODUCTO");
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
                cmd.CommandText = "spBuscar_Nproducto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = Productos.TEXTOBUSCAR;
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
