using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaAccesoDatos;//
using System.Data;//

namespace CapaLogicaDeNegocio
{
    public class LNUsuario
    {
        private string cadConexion;

        #region Constructores
        public LNUsuario()
        {
            cadConexion = string.Empty;
        }
        public LNUsuario(string cadena)
        {
            cadConexion = cadena;
        }
        #endregion

        public EUsuario buscar(string condicion)
        {
            EUsuario us;
            ADUsuario adUs = new ADUsuario(cadConexion);

            try
            {
                us = adUs.buscar(condicion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return us;
        }
    }
}
