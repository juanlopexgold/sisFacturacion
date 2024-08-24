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
    public class CD_Producto
    {
        //Declaracion y encapsulacion de los atributos y constructuctores de la clase
        private int _ID_PRODUCTO;
        private int _ID_NPRODUCTO;
        private int _ID_CATEGORIAS;
        private int _ID_U_MEDIDA;
        private int _ID_MARCA;
        private string _DESCRIPCION;
        private bool _Estado;
        private string _TextoBuscar;

        //Propiedades
        public int ID_PRODUCTOS
        {
            get { return _ID_PRODUCTO; }
            set { _ID_PRODUCTO = value; }
        }
        public int ID_NPRODUCTO
        {
            get { return _ID_NPRODUCTO; }
            set { _ID_NPRODUCTO = value; }
        }
        public int ID_CATEGORIAS
        {
            get { return _ID_CATEGORIAS; }
            set { _ID_CATEGORIAS = value; }
        }
        public int ID_U_MEDIDA
        {
            get { return _ID_U_MEDIDA; }
            set { _ID_U_MEDIDA = value; }
        }
        public int ID_MARCA
        {
            get { return _ID_MARCA; }
            set { _ID_MARCA = value; }
        }
        public string DESCRIPCION
        {
            get { return _DESCRIPCION; }
            set { _DESCRIPCION = value; }
        }
        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public CD_Producto()
        {

        }

        public CD_Producto(int idProducto, int idNProducto, int idCategoria, int idMarca, string descripcion, int idUMedida, bool estado, string textoBuscar)
        {
            this.ID_PRODUCTOS = idProducto;
            this.ID_NPRODUCTO = idNProducto;
            this.ID_CATEGORIAS = idCategoria;
            this.ID_MARCA = idMarca;
            this.DESCRIPCION = descripcion;
            this.ID_U_MEDIDA = idUMedida;
            this.Estado = estado;
            this.TextoBuscar = textoBuscar;
        }

        //Declaracion de los meodos CRUD
        //Insertar
        public string Insertar(CD_Producto Productos)
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
                cmd.CommandText = "spAgregar_Ariculo";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@ID_PRODUCTO";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parIdProducto);

                SqlParameter parIdNProducto = new SqlParameter();
                parIdNProducto.ParameterName = "@ID_NPRODUCTO";
                parIdNProducto.SqlDbType = SqlDbType.Int;
                parIdNProducto.Value = Productos.ID_NPRODUCTO;
                cmd.Parameters.Add(parIdNProducto);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@ID_CATEGORIA";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Productos.ID_CATEGORIAS;
                cmd.Parameters.Add(parIdCategoria);

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@ID_MARCA";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Value = Productos.ID_MARCA;
                cmd.Parameters.Add(parIdMarca);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@DESCRIPCION";
                parDescripcion.SqlDbType = SqlDbType.NVarChar;
                parDescripcion.Size = 100;
                parDescripcion.Value = Productos.ID_PRODUCTOS;
                cmd.Parameters.Add(parDescripcion);

                SqlParameter parIdUMedida = new SqlParameter();
                parIdUMedida.ParameterName = "@ID_UMEDIDA";
                parIdUMedida.SqlDbType = SqlDbType.Int;
                parIdUMedida.Value = Productos.ID_U_MEDIDA;
                cmd.Parameters.Add(parIdUMedida);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = Productos.Estado;
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
        public string Actualizar(CD_Producto Productos)
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
                cmd.CommandText = "spActualizar_Ariculo";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@ID_PRODUCTO";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Value = Productos.ID_PRODUCTOS;
                cmd.Parameters.Add(parIdProducto);

                SqlParameter parIdNProducto = new SqlParameter();
                parIdNProducto.ParameterName = "@ID_NPRODUCTO";
                parIdNProducto.SqlDbType = SqlDbType.Int;
                parIdNProducto.Value = Productos.ID_NPRODUCTO;
                cmd.Parameters.Add(parIdNProducto);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@ID_CATEGORIA";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Productos.ID_CATEGORIAS;
                cmd.Parameters.Add(parIdCategoria);

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@ID_MARCA";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Value = Productos.ID_MARCA;
                cmd.Parameters.Add(parIdMarca);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@DESCRIPCION";
                parDescripcion.SqlDbType = SqlDbType.NVarChar;
                parDescripcion.Size = 100;
                parDescripcion.Value = Productos.ID_PRODUCTOS;
                cmd.Parameters.Add(parDescripcion);

                SqlParameter parIdUMedida = new SqlParameter();
                parIdUMedida.ParameterName = "@ID_UMEDIDA";
                parIdUMedida.SqlDbType = SqlDbType.Int;
                parIdUMedida.Value = Productos.ID_U_MEDIDA;
                cmd.Parameters.Add(parIdUMedida);

                SqlParameter parEstado = new SqlParameter();
                parEstado.ParameterName = "@ESTADO";
                parEstado.SqlDbType = SqlDbType.Bit;
                parEstado.Value = Productos.Estado;
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
        public string Eliminar(CD_Producto Productos)
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
                cmd.CommandText = "spEliminar_Ariculo";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdProducto = new SqlParameter();
                parIdProducto.ParameterName = "@ID_PRODUCTO";
                parIdProducto.SqlDbType = SqlDbType.Int;
                parIdProducto.Value = Productos.ID_NPRODUCTO;
                cmd.Parameters.Add(parIdProducto);

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
            DataTable dt = new DataTable("PRODUCTO");
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
                cmd.CommandText = "spMostrar_Ariculo";
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
        public DataTable Buscar(CD_Producto Productos)
        {
            DataTable dt = new DataTable("PRODUCTO");
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
                cmd.CommandText = "spBuscar_Ariculo_Nombre";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = Productos.TextoBuscar;
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
