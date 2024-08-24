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
    public class CD_Marcas
    {
        //Declaracion y encapsulacion de los atributos y constructuctores de la clase
        private int _ID_MARCA;
        private string _NOMBRE_MARCA;
        private bool _ESTADO;
        private string _TEXTOBUSCAR;

        public int ID_MARCA
        {
            get { return _ID_MARCA; }
            set { _ID_MARCA = value; }
        }
        public string NOMBRE_MARCA
        {
            get { return _NOMBRE_MARCA; }
            set { _NOMBRE_MARCA = value; }
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

        public CD_Marcas()
        {

        }

        public CD_Marcas(int idMarca, string nombreMarca, bool estado, string textoBuscar)
        {
            this.ID_MARCA = idMarca;
            this.NOMBRE_MARCA = nombreMarca;
            this.ESTADO = estado;
            this.TEXTOBUSCAR = textoBuscar;
        }

        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_Marcas marcas)
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
                cmd.CommandText = "spAgregar_Marca";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@ID_MARCA";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdMarca);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@NOMBRE_MARCA";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = marcas.NOMBRE_MARCA;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = marcas.ESTADO;
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
        public string Actualizar(CD_Marcas marcas)
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
                cmd.CommandText = "spActualizar_Marca";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@ID_MARCA";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Value = marcas.ID_MARCA;
                cmd.Parameters.Add(parIdMarca);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@NOMBRE_MARCA";
                parNombre.SqlDbType = SqlDbType.NVarChar;
                parNombre.Size = 50;
                parNombre.Value = marcas.NOMBRE_MARCA;
                cmd.Parameters.Add(parNombre);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = marcas.ESTADO;
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
        public string Eliminar(CD_Marcas marcas)
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
                cmd.CommandText = "spEliminar_Marca";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@ID_MARCA";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Value = marcas.ID_MARCA;
                cmd.Parameters.Add(parIdMarca);

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
            DataTable dt = new DataTable("MARCA");
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
                cmd.CommandText = "spMostrar_Marca";
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
        public DataTable Buscar(CD_Marcas marcas)
        {
            DataTable dt = new DataTable("MARCA");
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
                cmd.CommandText = "spBuscar_Marca";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = marcas.TEXTOBUSCAR;
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
