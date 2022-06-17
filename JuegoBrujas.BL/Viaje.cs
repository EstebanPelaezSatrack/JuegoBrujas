using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoBrujas.BL
{
    public class Viaje
    {
        public Viaje()
        {

        }
        public Viaje(int viajeId)
        {
            ViajeId = viajeId;
            Trayecto = new List<Trayecto>();
        }

        public int ViajeId
        {
            get;
            private set;
        }
        public int ObjetivoCompra
        {
            get => default;
            set
            {
            }
        }

        public List<Trayecto> Trayecto
        {
            get => default;
            set
            {
            }
        }

        public double DuracionTotal
        {
            get => default;
            set
            {
            }
        }

        public int AcumuladoCompra
        {
            get => default;
            set
            {
            }
        }

        public Bruja Bruja
        {
            get => default;
            set
            {
            }
        }

        public int Carga
        {
            get => default;
            set
            {
            }
        }

        public int CapacidadCargaDisponible
        {
            get => default;
            set
            {
            }
        }

        public int ValidarEdadBruja(Bruja bruja)
        {
            var edad = 0;
            if (bruja.Edad> 19 && bruja.Edad < 153)
            {
                Console.WriteLine("Tienes una edad apta para viajar");
            }
            else
            {
                Console.WriteLine("No cumples con la edad para viajar");
            }
            return edad;

        }

        public void ValidarCargaDisponible(Escoba escoba)
        {
            int capacidadCargaDisponible = escoba.CapacidadCarga - Carga;
            this.CapacidadCargaDisponible = capacidadCargaDisponible;

        }

        public void AgregarCarga(Trayecto trayecto)
        {
            int carga = Carga + trayecto.Compra;
            this.Carga = carga;
        }

        public void AgregarDuracion(Trayecto trayecto)
        {
            double duraciontotal = DuracionTotal + trayecto.Duracion;
            this.DuracionTotal = duraciontotal;
        }

        public void AgregarTrayecto(Pueblo puebloActual, Pueblo puebloDestino)
        {
            Trayecto trayecto = new Trayecto();

            trayecto.ValidarDuracion(Bruja.Escoba);
            trayecto.ValidarReservaPueblo(puebloDestino);
            ValidarCargaDisponible(Bruja.Escoba);
            if (trayecto.Duracion < 7 && trayecto.PuebloDestino.InsumosDisponibles>3 && CapacidadCargaDisponible>trayecto.Compra)
            {
                this.Trayecto.Add(trayecto);
            }
        }
    }
}