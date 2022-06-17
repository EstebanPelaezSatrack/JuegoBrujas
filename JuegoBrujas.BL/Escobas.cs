using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoBrujas.BL
{
    public class Escoba
    {
        public Escoba()
        {

        }
        public Escoba(int escobaId)
        {
            EscobaId = escobaId;
        }

        public int EscobaId
        {
            get;
            private set;
        }
        public int CapacidadCarga
        {
            get => default;
            set
            {
            }
        }

        //La velocidad se da en Kilometros/Hora
        public int Velocidad
        {
            get => default;
            set
            {
            }
        }

       
        public bool ValidarDatos()
        {
            var isValid = true;
            if (CapacidadCarga == 0) isValid = false;
            if (Velocidad == 0) isValid = false;

            return isValid;
        }
    }
}