using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ADUsuario
    {
        private string cadConexion;

        public ADUsuario()
        {
            cadConexion = string.Empty;
        }

        public ADUsuario(string cad)//Preguntar
        {
            cadConexion = cad;
        }
        public EUsuario buscar(string condicion)
        {
            EUsuario us = new EUsuario();
            string sentencia = "Select claveUsuario,CURP,nombre,apPaterno,apMaterno,fechaNacimiento,email,direccion from Usuario";

            sentencia = $"{sentencia} where {condicion}";

            SqlConnection conexion = new SqlConnection(cadConexion);
            SqlCommand comando = new SqlCommand(sentencia, conexion);

            SqlDataReader dato;

            try
            {
                conexion.Open();
                dato = comando.ExecuteReader();
                if (dato.HasRows)
                {
                    dato.Read();//cambia de registro es como el fetch
                    us.ClaveUsuario = dato.GetString(0);
                    us.Curp = dato.GetString(1);
                    us.Nombre= dato.GetString(2);
                    us.ApPaterno = dato.GetString(3);
                    us.ApMaterno = dato.GetString(4);
                    us.FechaNacimiento = dato.GetDateTime(5);
                    us.Email = dato.GetString(6);
                    us.Direccion = dato.GetString(7);
                }

                conexion.Close();
            }

            catch (Exception)
            {

                throw new Exception("El usuario no está registrado");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return us;
        }
    }
}
