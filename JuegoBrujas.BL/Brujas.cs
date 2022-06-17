using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoBrujas.BL
{
    public class Bruja
    {
        public Bruja()
        {

        }
        public Bruja (int brujaId)
        {
            BrujaId = brujaId;
        }

        public int BrujaId
        {
            get;
            private set;
        }

        public string NombreBruja
        {
            get => default;
            set
            {
            }
        }

        public int Edad
        {
            get => default;
            set
            {
            }
        }

        public int ReservaAlimento
        {
            get => default;
            set
            {
            }
        }

      
        public string Avatar
        {
            get => default;
            set
            {
            }
        }

        public Escoba Escoba
        {
            get => default;
            set
            {
            }
        }

        
        public void Almacenar(Viaje viaje)
        {
            int reservaAlimento = ReservaAlimento + viaje.Carga;
            this.ReservaAlimento = reservaAlimento;
        }

        public bool ValidarDatos()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(NombreBruja)) isValid = false;
            if (Edad == 0) isValid = false;
            if (ReservaAlimento == 0) isValid = false;
          
            return isValid;
        }
    }
}