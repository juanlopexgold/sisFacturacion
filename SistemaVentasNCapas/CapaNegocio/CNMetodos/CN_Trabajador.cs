using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importarlibrerias
using CapaDatos.CDMetodos;
using System.Data;

namespace CapaNegocio.CNMetodos
{
    public class CN_Trabajador
    {
        // Metodo insertar que llama el metodo insertar de la capa datos
        public static string Insertar(string nombres, string apellidoM, string apellidoP, string genero, DateTime fechaNac,
            string num_documento, string direccion, string telefono, string email, string acceso, string usuario,
            string password)
        {
            CD_Trabajador Obj = new CD_Trabajador();
            Obj.Nombres = nombres;
            Obj.ApellidoP = apellidoP;
            Obj.ApellidoM = apellidoM;
            Obj.Genero = genero;
            Obj.FechaNac = fechaNac;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Insertar(Obj);
        }

        // Metodo editar que llama el metodo editar de la capa datos
        public static string Actualizar(int idTrabajador, string nombres, string apellidoM, string apellidoP, string genero, DateTime fechaNac,
            string num_documento, string direccion, string telefono, string email, string acceso, string usuario,
            string password)
        {
            CD_Trabajador Obj = new CD_Trabajador();
            Obj.IdTrabajador = idTrabajador;
            Obj.Nombres = nombres;
            Obj.ApellidoP = apellidoP;
            Obj.ApellidoM = apellidoM;
            Obj.Genero = genero;
            Obj.FechaNac = fechaNac;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Insertar(Obj);
        }

        // Metodo eliminar que llama el metodo eliminar de la capa datos
        public static string Eliminar(int idNMedida)
        {
            CD_Trabajador Obj = new CD_Trabajador();
            Obj.IdTrabajador = idNMedida;

            return Obj.Eliminar(Obj);
        }

        // Metodo mostrar que llama el metodo mostrar de la capa datos
        public static DataTable Mostrar()
        {
            return new CD_Trabajador().Mostrar();
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_nombre(string texto)
        {
            CD_Trabajador obj = new CD_Trabajador();
            obj.TextoBuscar = texto;

            return obj.BuscarNombres(obj);
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_ApellidoP(string texto)
        {
            CD_Trabajador obj = new CD_Trabajador();
            obj.TextoBuscar = texto;

            return obj.BuscarApellidoP(obj);
        }

        // Metodo buscar que llama el metodo buscar de la capa datos
        public static DataTable Buscar_ApellidoM(string texto)
        {
            CD_Trabajador obj = new CD_Trabajador();
            obj.TextoBuscar = texto;

            return obj.BuscarApellidoM(obj);
        }

        // Metodo login que llama el metodo buscar de la capa datos
        public static DataTable Login(string usuario, string clave)
        {
            CD_Trabajador obj = new CD_Trabajador();
            obj.Usuario = usuario;
            obj.Password = clave;

            return obj.Login(obj);
        }
    }
}
