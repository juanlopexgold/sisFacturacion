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
    public class CD_Categorias
    {
        //Declaracion y encapsulacion de los atributos y constructuctores de la clase
        private int _ID_CATEGORIA;
        private string _NOMBRE_CATEGORIA;
        private bool _ESTADO;
        private string _TEXTOBUSCAR;

        public int ID_CATEGORIA
        {
            get { return _ID_CATEGORIA; }
            set { _ID_CATEGORIA = value; }
        }
        public string NOMBRE_CATEGORIA
        {
            get { return _NOMBRE_CATEGORIA; }
            set { _NOMBRE_CATEGORIA = value; }
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

        public CD_Categorias()
        {

        }

        public CD_Categorias(int idCategoria, string nombreCategoria, bool estado, string textoBuscar)
        {
            this.ID_CATEGORIA = idCategoria;
            this.NOMBRE_CATEGORIA = nombreCategoria;
            this.ESTADO = estado;
            this.TEXTOBUSCAR = textoBuscar;
        }

        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_Categorias Categoria)
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
                cmd.CommandText = "spAgregar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNCategoria = new SqlParameter();
                parIdNCategoria.ParameterName = "@ID_CATEGORIA";
                parIdNCategoria.SqlDbType = SqlDbType.Int;
                parIdNCategoria.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdNCategoria);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@NOMBRE_CATEGORIA";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = Categoria.NOMBRE_CATEGORIA;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = Categoria.ESTADO;
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
        public string Actualizar(CD_Categorias Categoria)
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
                cmd.CommandText = "spActualizar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNCategoria = new SqlParameter();
                parIdNCategoria.ParameterName = "@ID_CATEGORIA";
                parIdNCategoria.SqlDbType = SqlDbType.Int;
                parIdNCategoria.Value = Categoria.ID_CATEGORIA;
                cmd.Parameters.Add(parIdNCategoria);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@NOMBRE_CATEGORIA";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = Categoria.NOMBRE_CATEGORIA;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = Categoria.ESTADO;
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
        public string Eliminar(CD_Categorias Categoria)
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
                cmd.CommandText = "spEliminar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdNCategoria = new SqlParameter();
                parIdNCategoria.ParameterName = "@ID_CATEGORIA";
                parIdNCategoria.SqlDbType = SqlDbType.Int;
                parIdNCategoria.Value = Categoria.ID_CATEGORIA;
                cmd.Parameters.Add(parIdNCategoria);

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
            DataTable dt = new DataTable("CATEGORIA");
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
                cmd.CommandText = "spMostrar_Categoria";
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
        public DataTable Buscar(CD_Categorias Categoria)
        {
            DataTable dt = new DataTable("CATEGORIA");
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
                cmd.CommandText = "spBuscar_Categoria";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = Categoria.TEXTOBUSCAR;
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
