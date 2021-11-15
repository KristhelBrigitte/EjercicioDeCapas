using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;

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
            comando.Parameters.AddWithValue("@claveEjemplar",pre.Ejemplar.ClaveEjemplar);
            comando.Parameters.AddWithValue("@claveUsuario",pre.Usuario.ClaveUsuario);
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



    }
}
