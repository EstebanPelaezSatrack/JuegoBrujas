using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoBrujas.BL
{
    public class Pueblo
    {

        public Pueblo()
        {

        }
        public Pueblo(int puebloId)
        {
            PuebloId = puebloId;
            VecinosDirectos = new List<Pueblo>();
        }

        public int PuebloId
        {
            get;
            private set;
        }

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public List<Pueblo> VecinosDirectos
        {
            get => default;
            set
            {
            }
        }

        public int InsumosDisponibles
        {
            get => default;
            set
            {
            }
        }

        public double PosicionEnX
        {
            get => default;
            set
            {
            }
        }

        public double PosicionEnY
        {
            get => default;
            set
            {
            }
        }

        public void Vender(Trayecto trayecto)
        {
            int insumosDisponibles = InsumosDisponibles - trayecto.Compra;

            this.InsumosDisponibles = insumosDisponibles;
        }

        public bool ValidarDatos()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(Nombre.Trim())) isValid = false;
            if (InsumosDisponibles == 0) isValid = false;
            
            return isValid;
        }
    }
}