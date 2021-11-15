using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class AdPrestamo
    {
        #region Atributos
        private string cadConexion;
        #endregion

        #region Constructores

        public AdPrestamo()
        {
            cadConexion = string.Empty;
        }

        public AdPrestamo(string cad)
        {
            cadConexion = cad;
        }
        #endregion

        public int insertar(EPrestamo pre)
        {
            int result = -1;
            string sentencia = "insert into Prestamo(clavePrestamo,claveEjemplar," +
            "claveUsuario,fechaPrestamo,fechaDevolucion)" +
            " values (@clavePrestamo,@clavEjemplar,@claveUsuario,@fechaPre,@fechaDev)" //Con arrobas, al no interpolar
            ;

            SqlConnection conexion = new SqlConnection(cadConexion);
            SqlCommand comando = new SqlCommand(sentencia, conexion);

            comando.Parameters.AddWithValue("@clavePrestamo", pre.ClavePrestamo);
            comando.Parameters.AddWithValue("@claveEjemplar", pre.Ejemplar.ClaveEjemplar);
            comando.Parameters.AddWithValue("@claveUsuario", pre.Usuario.ClaveUsuario);
            comando.Parameters.AddWithValue("@fechaPre", pre.FechaPrestamo);
            comando.Parameters.AddWithValue("@fechaDev", pre.FechaDevolucion);


            try
            {
                conexion.Open();
                result = comando.ExecuteNonQuery();//ERROR AQUI
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
                throw new Exception("Error!");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return result;
        }

        public bool clavePrestamoExiste(string clave)
        {
            bool result = false; object ObEscalar;

            SqlConnection conexion = new SqlConnection(cadConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "select 1 from Prestamo Where clavePrestamo=@clavePres";
            comando.Parameters.AddWithValue("@clavePres", clave);
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                ObEscalar = comando.ExecuteScalar();
                if (ObEscalar != null)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception)
            {
                throw new Exception("Error de conexión");
            }
            finally
            {
                comando.Dispose();
                conexion.Dispose();
            }
            return result;

        }

        public DataSet listarTodos(string condicion)
        {
            DataSet setPrestamos = new DataSet();
            string sentencia = "Select clavePrestamo,claveEjemplar,claveUsuario,fechaPrestamo,fechaDevolucion from Prestamo";

            if (!string.IsNullOrEmpty(condicion))
                sentencia = string.Format("{0} where {1}", sentencia, condicion);

            SqlConnection conexion = new SqlConnection(cadConexion);// adapter para llenar dataset y dataview, y llevarlos a la base
            SqlDataAdapter adaptador;// no se instancia de una vez, solo donde se usa  PARA EL DATASET NO SE USA COMANDO

            try
            {
                adaptador = new SqlDataAdapter(sentencia, conexion);
                adaptador.Fill(setPrestamos);
                adaptador.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("");
            }
            finally
            {
                conexion.Dispose();
            }
            return setPrestamos;
        }
    }
}    

