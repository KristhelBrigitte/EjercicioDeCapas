using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EPrestamo
    {
        #region Atributos
        string clavePrestamo;
        EEjemplar ejemplar; //Clave
        EUsuario usuario;
        DateTime fechaPrestamo;
        DateTime fechaDevolucion;

        #endregion

        #region Propiedades
        public string ClavePrestamo { get; set; }
        public EEjemplar Ejemplar { get; set; }

        public EUsuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        #endregion

        #region Constructores
        public EPrestamo()
        {
            clavePrestamo = string.Empty;
            Ejemplar = new EEjemplar(); //Clave
            Usuario = new EUsuario();
            fechaPrestamo = DateTime.Today;
            FechaDevolucion = DateTime.Today;
        }
        public EPrestamo(string clav, EEjemplar ejem, EUsuario usua, DateTime feIngreso, DateTime feDevolucion)
        {
            clavePrestamo = clav;
            Ejemplar = ejem; //Clave
            Usuario = usua;
            fechaPrestamo = feIngreso;
            FechaDevolucion = feDevolucion;
        }

        #endregion


    }
}
