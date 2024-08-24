using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lamar librerias
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.CDMetodos
{
    public class CD_Cliente
    {
        //Variables
        private int _IdCliente;
        private string _NombresEmpresa;
        private string _NombresCliente;
        private string _PuestoCliente;
        private string _Direccion;
        private string _Ciudad;
        private string _Num_Documento;
        private string _Telefono;
        private string _Email;
        private string _Url;
        private string _TextoBuscar;

        //Propiedades
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        public string NombresEmpresa
        {
            get { return _NombresEmpresa; }
            set { _NombresEmpresa = value; }
        }
        public string NombresCliente
        {
            get { return _NombresCliente; }
            set { _NombresCliente = value; }
        }
        public string PuestoCliente
        {
            get { return _PuestoCliente; }
            set { _PuestoCliente = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }
        public string Num_Documento
        {
            get { return _Num_Documento; }
            set { _Num_Documento = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public CD_Cliente()
        {

        }
        public CD_Cliente(int idCliente, string nombresEmpresa, string nombresCliente, string puestoCliente, string direccion, string num_documento, string ciudad, string telefono, string email, string url, string textobuscar)
        {
            this.IdCliente = idCliente;
            this.NombresEmpresa = nombresEmpresa;
            this.NombresCliente = nombresCliente;
            this.PuestoCliente = puestoCliente;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Num_Documento = num_documento;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;

        }
        //Métodos
        public string Insertar(CD_Cliente Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_GuardarCLIENTE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@ID_CLIENTE";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParNombresEmpresa = new SqlParameter();
                ParNombresEmpresa.ParameterName = "@NombresEmpresa";
                ParNombresEmpresa.SqlDbType = SqlDbType.NVarChar;
                ParNombresEmpresa.Size = 100;
                ParNombresEmpresa.Value = Proveedor.NombresEmpresa;
                SqlCmd.Parameters.Add(ParNombresEmpresa);

                SqlParameter ParNombresContacto = new SqlParameter();
                ParNombresContacto.ParameterName = "@NombresCliente";
                ParNombresContacto.SqlDbType = SqlDbType.NVarChar;
                ParNombresContacto.Size = 100;
                ParNombresContacto.Value = Proveedor.NombresCliente;
                SqlCmd.Parameters.Add(ParNombresContacto);

                SqlParameter ParPuestoContacto = new SqlParameter();
                ParPuestoContacto.ParameterName = "@PuestoCliente";
                ParPuestoContacto.SqlDbType = SqlDbType.VarChar;
                ParPuestoContacto.Size = 50;
                ParPuestoContacto.Value = Proveedor.PuestoCliente;
                SqlCmd.Parameters.Add(ParPuestoContacto);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 50;
                ParCiudad.Value = Proveedor.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@Num_Identificacion";
                ParNum_Documento.SqlDbType = SqlDbType.NVarChar;
                ParNum_Documento.Size = 12;
                ParNum_Documento.Value = Proveedor.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Correo";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);


                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@Sitio_Web";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Proveedor.Url;
                SqlCmd.Parameters.Add(ParUrl);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        //Método Editar
        public string Editar(CD_Cliente Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_EditarCLIENTE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@ID_CLIENTE";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Proveedor.IdCliente;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParNombresEmpresa = new SqlParameter();
                ParNombresEmpresa.ParameterName = "@NombresEmpresa";
                ParNombresEmpresa.SqlDbType = SqlDbType.NVarChar;
                ParNombresEmpresa.Size = 100;
                ParNombresEmpresa.Value = Proveedor.NombresEmpresa;
                SqlCmd.Parameters.Add(ParNombresEmpresa);

                SqlParameter ParNombresContacto = new SqlParameter();
                ParNombresContacto.ParameterName = "@NombresCliente";
                ParNombresContacto.SqlDbType = SqlDbType.NVarChar;
                ParNombresContacto.Size = 100;
                ParNombresContacto.Value = Proveedor.NombresCliente;
                SqlCmd.Parameters.Add(ParNombresContacto);

                SqlParameter ParPuestoContacto = new SqlParameter();
                ParPuestoContacto.ParameterName = "@PuestoCliente";
                ParPuestoContacto.SqlDbType = SqlDbType.VarChar;
                ParPuestoContacto.Size = 50;
                ParPuestoContacto.Value = Proveedor.PuestoCliente;
                SqlCmd.Parameters.Add(ParPuestoContacto);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 50;
                ParCiudad.Value = Proveedor.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@Num_Identificacion";
                ParNum_Documento.SqlDbType = SqlDbType.NVarChar;
                ParNum_Documento.Size = 12;
                ParNum_Documento.Value = Proveedor.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Correo";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);


                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@Sitio_Web";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Proveedor.Url;
                SqlCmd.Parameters.Add(ParUrl);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Eliminar(CD_Cliente Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_EliminarCLIENTE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@ID_CLIENTE";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = Proveedor.IdCliente;
                SqlCmd.Parameters.Add(ParIdproveedor);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("CLIENTE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_MostrarCLIENTE";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método BuscarNombre
        public DataTable BuscarNombreContacto(CD_Cliente Proveedor)
        {
            DataTable DtResultado = new DataTable("CLIENTE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_BuscarCLIENTER_NombreCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable BuscarNombreEmpresa(CD_Cliente Proveedor)
        {
            DataTable DtResultado = new DataTable("CLIENTE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_BuscarCLIENTE_NombreEmpresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable BuscarIdentificacion(CD_Cliente Proveedor)
        {
            DataTable DtResultado = new DataTable("CLIENTE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_BuscarCLIENTE_Identificacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
