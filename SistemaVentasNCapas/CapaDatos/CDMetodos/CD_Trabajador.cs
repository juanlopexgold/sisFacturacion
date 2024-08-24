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
    public class CD_Trabajador
    {
        //Variables
        private int _IdTrabajador;
        private string _Nombres;
        private string _ApellidoM;
        private string _ApellidoP;
        private string _Genero;
        private DateTime _FechaNac;
        private string _Num_Documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Acceso;
        private string _Usuario;
        private string _Password;
        private string _TextoBuscar;

        //Propiedades
        public int IdTrabajador
        {
            get { return _IdTrabajador; }
            set { _IdTrabajador = value; }
        }
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        public string ApellidoM
        {
            get { return _ApellidoM; }
            set { _ApellidoM = value; }
        }
        public string ApellidoP
        {
            get { return _ApellidoP; }
            set { _ApellidoP = value; }
        }
        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
        public DateTime FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
        }
        public string Num_Documento
        {
            get { return _Num_Documento; }
            set { _Num_Documento = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
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
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string Acceso
        {
            get { return _Acceso; }
            set { _Acceso = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public CD_Trabajador()
        {

        }
        public CD_Trabajador(int idTrabajador, string nombres, string apellidoM, string apellidoP, string genero, DateTime fechaNac, 
            string num_documento, string direccion , string telefono, string email, string acceso, string usuario, 
            string password, string textobuscar)
        {
            this._IdTrabajador = idTrabajador;
            this.Nombres = nombres;
            this.ApellidoM = apellidoM;
            this.ApellidoP = apellidoP;
            this.Genero = genero;
            this.FechaNac = fechaNac;
            this.Num_Documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Acceso = acceso;
            this.Usuario = usuario;
            this.Password = password;
            this.TextoBuscar = textobuscar;

        }
        //Métodos
        public string Insertar(CD_Trabajador trabajador)
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
                SqlCmd.CommandText = "spAgregar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "ID_EMPLEADO";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRES";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 100;
                ParNombre.Value = trabajador.Nombres;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidoM = new SqlParameter();
                ParApellidoM.ParameterName = "@APELLIDOPATERNO";
                ParApellidoM.SqlDbType = SqlDbType.NVarChar;
                ParApellidoM.Size = 50;
                ParApellidoM.Value = trabajador.ApellidoM;
                SqlCmd.Parameters.Add(ParApellidoM);

                SqlParameter ParApellidoP = new SqlParameter();
                ParApellidoP.ParameterName = "@APELLIDOMATERNO";
                ParApellidoP.SqlDbType = SqlDbType.NVarChar;
                ParApellidoP.Size = 50;
                ParApellidoP.Value = trabajador.ApellidoP;
                SqlCmd.Parameters.Add(ParApellidoP);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@GENERO";
                ParGenero.SqlDbType = SqlDbType.NVarChar;
                ParGenero.Size = 1;
                ParGenero.Value = trabajador.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@FECHA_NAC";
                ParFechaNac.SqlDbType = SqlDbType.Date;
                ParFechaNac.Value = trabajador.FechaNac;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@N_IDENTIFICACION";
                ParNum_Documento.SqlDbType = SqlDbType.NVarChar;
                ParNum_Documento.Size = 20;
                ParNum_Documento.Value = trabajador.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@DIRECCION";
                ParDireccion.SqlDbType = SqlDbType.NVarChar;
                ParDireccion.Size = 250;
                ParDireccion.Value = trabajador.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.NVarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = trabajador.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@EMAIL";
                ParEmail.SqlDbType = SqlDbType.NVarChar;
                ParEmail.Size = 50;
                ParEmail.Value = trabajador.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@ACCESO";
                ParAcceso.SqlDbType = SqlDbType.NVarChar;
                ParAcceso.Size = 20;
                ParAcceso.Value = trabajador.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@USUARIO";
                ParUsuario.SqlDbType = SqlDbType.NVarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@CLAVE";
                ParPassword.SqlDbType = SqlDbType.NVarChar;
                ParPassword.Size = 20;
                ParPassword.Value = trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

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
        public string Editar(CD_Trabajador trabajador)
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
                SqlCmd.CommandText = "spActualizar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@ID_EMPLEADO";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = trabajador.IdTrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@NOMBRES";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 100;
                ParNombre.Value = trabajador.Nombres;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidoM = new SqlParameter();
                ParApellidoM.ParameterName = "@APELLIDOPATERNO";
                ParApellidoM.SqlDbType = SqlDbType.NVarChar;
                ParApellidoM.Size = 50;
                ParApellidoM.Value = trabajador.ApellidoM;
                SqlCmd.Parameters.Add(ParApellidoM);

                SqlParameter ParApellidoP = new SqlParameter();
                ParApellidoP.ParameterName = "@APELLIDOMATERNO";
                ParApellidoP.SqlDbType = SqlDbType.NVarChar;
                ParApellidoP.Size = 50;
                ParApellidoP.Value = trabajador.ApellidoP;
                SqlCmd.Parameters.Add(ParApellidoP);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@GENERO";
                ParGenero.SqlDbType = SqlDbType.NVarChar;
                ParGenero.Size = 1;
                ParGenero.Value = trabajador.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@FECHA_NAC";
                ParFechaNac.SqlDbType = SqlDbType.Date;
                ParFechaNac.Value = trabajador.FechaNac;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@N_IDENTIFICACION";
                ParNum_Documento.SqlDbType = SqlDbType.NVarChar;
                ParNum_Documento.Size = 20;
                ParNum_Documento.Value = trabajador.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@DIRECCION";
                ParDireccion.SqlDbType = SqlDbType.NVarChar;
                ParDireccion.Size = 250;
                ParDireccion.Value = trabajador.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@TELEFONO";
                ParTelefono.SqlDbType = SqlDbType.NVarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = trabajador.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@EMAIL";
                ParEmail.SqlDbType = SqlDbType.NVarChar;
                ParEmail.Size = 50;
                ParEmail.Value = trabajador.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@ACCESO";
                ParAcceso.SqlDbType = SqlDbType.NVarChar;
                ParAcceso.Size = 20;
                ParAcceso.Value = trabajador.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@USUARIO";
                ParUsuario.SqlDbType = SqlDbType.NVarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@CLAVE";
                ParPassword.SqlDbType = SqlDbType.NVarChar;
                ParPassword.Size = 20;
                ParPassword.Value = trabajador.Password;
                SqlCmd.Parameters.Add(ParPassword);

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
        public string Eliminar(CD_Trabajador trabajador)
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
                SqlCmd.CommandText = "spEliminar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@ID_EMPLEADO";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = trabajador.IdTrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);


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
            DataTable DtResultado = new DataTable("EMPLEADOS");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ClassConexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_Empleado";
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

        //Buscar1
        public DataTable BuscarNombres(CD_Trabajador trabajador)
        {
            DataTable dt = new DataTable("EMPLEADOS");
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
                cmd.CommandText = "spBuscar_Empleado_Nombres";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = trabajador.TextoBuscar;
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

        //Buscar2
        public DataTable BuscarApellidoP(CD_Trabajador trabajador)
        {
            DataTable dt = new DataTable("EMPLEADOS");
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
                cmd.CommandText = "spBuscar_Empleado_ApellioPeterno";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = trabajador.TextoBuscar;
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

        //Buscar3
        public DataTable BuscarApellidoM(CD_Trabajador trabajador)
        {
            DataTable dt = new DataTable("EMPLEADOS");
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
                cmd.CommandText = "spBuscar_Empleado_ApellioMaterno";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parTextBuscar = new SqlParameter();
                parTextBuscar.ParameterName = "@textoBuscar";
                parTextBuscar.SqlDbType = SqlDbType.VarChar;
                parTextBuscar.Size = 50;
                parTextBuscar.Value = trabajador.TextoBuscar;
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

        //Login
        public DataTable Login(CD_Trabajador trabajador)
        {
            DataTable dt = new DataTable("EMPLEADOS");
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
                cmd.CommandText = "spLogin";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@USUARIO";
                parUsuario.SqlDbType = SqlDbType.NVarChar;
                parUsuario.Size = 20;
                parUsuario.Value = trabajador.Usuario;
                cmd.Parameters.Add(parUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@CLAVE";
                ParPassword.SqlDbType = SqlDbType.NVarChar;
                ParPassword.Size = 20;
                ParPassword.Value = trabajador.Password;
                cmd.Parameters.Add(ParPassword);

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
