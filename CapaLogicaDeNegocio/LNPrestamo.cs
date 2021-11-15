using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAccesoDatos;
using System.Data;
namespace CapaLogicaDeNegocio
{
    public class LNPrestamo
    {
       
        private string cadConexion;

        public LNPrestamo()
        {
            cadConexion = string.Empty;
        }
        public LNPrestamo(string cadena)
        {
            cadConexion = cadena;
        }

        public int insertar(EPrestamo pre)
        {
            int result;
            AdPrestamo adPres = new AdPrestamo(cadConexion);
            try
            {
                result = adPres.insertar(pre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }

        public bool clavePrestamoExiste(string clave)
        {
            bool result = false;
            AdPrestamo adPres = new AdPrestamo(cadConexion);
            try
            {
                result = adPres.clavePrestamoExiste(clave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool claveEjemplarExiste(string clav)
        {
            bool result = false;
            ADEjemplar adEjem = new ADEjemplar(cadConexion);
            try
            {
                result = adEjem.claveEjemplarExiste(clav);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public DataSet listarTodos(string condicion)
        {
            DataSet setPrestamos;
            AdPrestamo adPres = new AdPrestamo(cadConexion);
            try
            {
                setPrestamos= adPres.listarTodos(condicion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return setPrestamos;
        }

    }
}
