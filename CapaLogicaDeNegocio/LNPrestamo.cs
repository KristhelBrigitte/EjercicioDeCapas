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

    }
}
