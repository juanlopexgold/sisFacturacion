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
    public class CD_Proveedor
    {
        //Variables
        private int _Idproveedor;
        private string _Nombresproveedor;
        private string _DetalleProveedor;
        private string _NombreContacto;
        private string _Apellido1Contacto;
        private string _Apellido2Contacto;
        private string _Telefono;
        private string _Email;

        //Propiedades
        public int Idproveedor
        {
            get { return _Idproveedor; }
            set { _Idproveedor = value; }
        }
        public string Nombresproveedor
        {
            get { return _Nombresproveedor; }
            set { _Nombresproveedor = value; }
        }
        public string DetalleProveedor
        {
            get { return _DetalleProveedor; }
            set { _DetalleProveedor = value; }
        }
        public string NombreContacto
        {
            get { return _NombreContacto; }
            set { _NombreContacto = value; }
        }
        public string Apellido1Contacto
        {
            get { return _Apellido1Contacto; }
            set { _Apellido1Contacto = value; }
        }
        public string Apellido2Contacto
        {
            get { return _Apellido2Contacto; }
            set { _Apellido2Contacto = value; }
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

        //Constructores
        public CD_Proveedor()
        {

        }
        public CD_Proveedor(int idproveedor, string nombresproveedor, string detalleProveedor,
            string nombreContacto, string apellido1Contacto, string apellido2Contacto, string telefono, string email)
        {
            this.Idproveedor = idproveedor;
            this.Nombresproveedor = nombresproveedor;
            this.DetalleProveedor = detalleProveedor;
            this.NombreContacto = nombreContacto;
            this.Apellido1Contacto = apellido1Contacto;
            this.Apellido1Contacto = apellido2Contacto;
            this.Telefono = telefono;
            this.Email = email;

        }
        //Métodos
        //public string Insertar(CD_Proveedor Proveedor)
        //{
        //    string rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        //Código
        //        SqlCon.ConnectionString = ClaseConexion.conexion;
        //        SqlCon.Open();
        //        //Establecer el Comando
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "sp_GuardarPROVEEDOR";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParIdproveedor = new SqlParameter();
        //        ParIdproveedor.ParameterName = "@ID_PROVEEDOR";
        //        ParIdproveedor.SqlDbType = SqlDbType.Int;
        //        ParIdproveedor.Direction = ParameterDirection.Output;
        //        SqlCmd.Parameters.Add(ParIdproveedor);

        //        SqlParameter ParNombresEmpresa = new SqlParameter();
        //        ParNombresEmpresa.ParameterName = "@NombresEmpresa";
        //        ParNombresEmpresa.SqlDbType = SqlDbType.NVarChar;
        //        ParNombresEmpresa.Size = 100;
        //        ParNombresEmpresa.Value = Proveedor.NombresEmpresa;
        //        SqlCmd.Parameters.Add(ParNombresEmpresa);

        //        SqlParameter ParNombresContacto = new SqlParameter();
        //        ParNombresContacto.ParameterName = "@NombresContacto";
        //        ParNombresContacto.SqlDbType = SqlDbType.NVarChar;
        //        ParNombresContacto.Size = 100;
        //        ParNombresContacto.Value = Proveedor.NombresContacto;
        //        SqlCmd.Parameters.Add(ParNombresContacto);

        //        SqlParameter ParPuestoContacto = new SqlParameter();
        //        ParPuestoContacto.ParameterName = "@PuestoContacto";
        //        ParPuestoContacto.SqlDbType = SqlDbType.VarChar;
        //        ParPuestoContacto.Size = 50;
        //        ParPuestoContacto.Value = Proveedor.PuestoContacto;
        //        SqlCmd.Parameters.Add(ParPuestoContacto);

        //        SqlParameter ParDireccion = new SqlParameter();
        //        ParDireccion.ParameterName = "@Direccion";
        //        ParDireccion.SqlDbType = SqlDbType.VarChar;
        //        ParDireccion.Size = 50;
        //        ParDireccion.Value = Proveedor.Direccion;
        //        SqlCmd.Parameters.Add(ParDireccion);

        //        SqlParameter ParCiudad = new SqlParameter();
        //        ParCiudad.ParameterName = "@Ciudad";
        //        ParCiudad.SqlDbType = SqlDbType.VarChar;
        //        ParCiudad.Size = 50;
        //        ParCiudad.Value = Proveedor.Ciudad;
        //        SqlCmd.Parameters.Add(ParCiudad);

        //        SqlParameter ParNum_Documento = new SqlParameter();
        //        ParNum_Documento.ParameterName = "@Num_Identificacion";
        //        ParNum_Documento.SqlDbType = SqlDbType.NVarChar;
        //        ParNum_Documento.Size = 12;
        //        ParNum_Documento.Value = Proveedor.Num_Documento;
        //        SqlCmd.Parameters.Add(ParNum_Documento);

        //        SqlParameter ParTelefono = new SqlParameter();
        //        ParTelefono.ParameterName = "@Telefono";
        //        ParTelefono.SqlDbType = SqlDbType.VarChar;
        //        ParTelefono.Size = 11;
        //        ParTelefono.Value = Proveedor.Telefono;
        //        SqlCmd.Parameters.Add(ParTelefono);

        //        SqlParameter ParEmail = new SqlParameter();
        //        ParEmail.ParameterName = "@Correo";
        //        ParEmail.SqlDbType = SqlDbType.VarChar;
        //        ParEmail.Size = 50;
        //        ParEmail.Value = Proveedor.Email;
        //        SqlCmd.Parameters.Add(ParEmail);


        //        SqlParameter ParUrl = new SqlParameter();
        //        ParUrl.ParameterName = "@Sitio_Web";
        //        ParUrl.SqlDbType = SqlDbType.VarChar;
        //        ParUrl.Size = 100;
        //        ParUrl.Value = Proveedor.Url;
        //        SqlCmd.Parameters.Add(ParUrl);

        //        //Ejecutamos nuestro comando

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;

        //}

        ////Método Editar
        //public string Editar(CD_Proveedor Proveedor)
        //{
        //    string rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        //Código
        //        SqlCon.ConnectionString = ClaseConexion.conexion;
        //        SqlCon.Open();
        //        //Establecer el Comando
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "sp_EditarPROVEEDOR";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParIdproveedor = new SqlParameter();
        //        ParIdproveedor.ParameterName = "@ID_PROVEEDOR";
        //        ParIdproveedor.SqlDbType = SqlDbType.Int;
        //        ParIdproveedor.Value = Proveedor.Idproveedor;
        //        SqlCmd.Parameters.Add(ParIdproveedor);

        //        SqlParameter ParNombresEmpresa = new SqlParameter();
        //        ParNombresEmpresa.ParameterName = "@NombresEmpresa";
        //        ParNombresEmpresa.SqlDbType = SqlDbType.NVarChar;
        //        ParNombresEmpresa.Size = 100;
        //        ParNombresEmpresa.Value = Proveedor.NombresEmpresa;
        //        SqlCmd.Parameters.Add(ParNombresEmpresa);

        //        SqlParameter ParNombresContacto = new SqlParameter();
        //        ParNombresContacto.ParameterName = "@NombresContacto";
        //        ParNombresContacto.SqlDbType = SqlDbType.NVarChar;
        //        ParNombresContacto.Size = 100;
        //        ParNombresContacto.Value = Proveedor.NombresContacto;
        //        SqlCmd.Parameters.Add(ParNombresContacto);

        //        SqlParameter ParPuestoContacto = new SqlParameter();
        //        ParPuestoContacto.ParameterName = "@PuestoContacto";
        //        ParPuestoContacto.SqlDbType = SqlDbType.VarChar;
        //        ParPuestoContacto.Size = 50;
        //        ParPuestoContacto.Value = Proveedor.PuestoContacto;
        //        SqlCmd.Parameters.Add(ParPuestoContacto);

        //        SqlParameter ParDireccion = new SqlParameter();
        //        ParDireccion.ParameterName = "@Direccion";
        //        ParDireccion.SqlDbType = SqlDbType.VarChar;
        //        ParDireccion.Size = 50;
        //        ParDireccion.Value = Proveedor.Direccion;
        //        SqlCmd.Parameters.Add(ParDireccion);

        //        SqlParameter ParCiudad = new SqlParameter();
        //        ParCiudad.ParameterName = "@Ciudad";
        //        ParCiudad.SqlDbType = SqlDbType.VarChar;
        //        ParCiudad.Size = 50;
        //        ParCiudad.Value = Proveedor.Ciudad;
        //        SqlCmd.Parameters.Add(ParCiudad);

        //        SqlParameter ParNum_Documento = new SqlParameter();
        //        ParNum_Documento.ParameterName = "@Num_Identificacion";
        //        ParNum_Documento.SqlDbType = SqlDbType.NVarChar;
        //        ParNum_Documento.Size = 12;
        //        ParNum_Documento.Value = Proveedor.Num_Documento;
        //        SqlCmd.Parameters.Add(ParNum_Documento);

        //        SqlParameter ParTelefono = new SqlParameter();
        //        ParTelefono.ParameterName = "@Telefono";
        //        ParTelefono.SqlDbType = SqlDbType.VarChar;
        //        ParTelefono.Size = 11;
        //        ParTelefono.Value = Proveedor.Telefono;
        //        SqlCmd.Parameters.Add(ParTelefono);

        //        SqlParameter ParEmail = new SqlParameter();
        //        ParEmail.ParameterName = "@Correo";
        //        ParEmail.SqlDbType = SqlDbType.VarChar;
        //        ParEmail.Size = 50;
        //        ParEmail.Value = Proveedor.Email;
        //        SqlCmd.Parameters.Add(ParEmail);


        //        SqlParameter ParUrl = new SqlParameter();
        //        ParUrl.ParameterName = "@Sitio_Web";
        //        ParUrl.SqlDbType = SqlDbType.VarChar;
        //        ParUrl.Size = 100;
        //        ParUrl.Value = Proveedor.Url;
        //        SqlCmd.Parameters.Add(ParUrl);

        //        //Ejecutamos nuestro comando

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}

        //Método Eliminar
        //public string Eliminar(CD_Proveedor Proveedor)
        //{
        //    string rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        //Código
        //        SqlCon.ConnectionString = ClaseConexion.conexion;
        //        SqlCon.Open();
        //        //Establecer el Comando
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "sp_EliminarPROVEEDOR";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParIdproveedor = new SqlParameter();
        //        ParIdproveedor.ParameterName = "@ID_PROVEEDOR ";
        //        ParIdproveedor.SqlDbType = SqlDbType.Int;
        //        ParIdproveedor.Value = Proveedor.Idproveedor;
        //        SqlCmd.Parameters.Add(ParIdproveedor);


        //        //Ejecutamos nuestro comando

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_MostrarProveedor";
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
    }
}
