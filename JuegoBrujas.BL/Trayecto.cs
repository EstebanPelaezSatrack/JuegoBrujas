using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoBrujas.BL
{
    public class Trayecto
    {
        public Trayecto()
        {

        }
        public Trayecto(int trayectoId)
        {
            TrayectoId = trayectoId;
        }
        public int TrayectoId
        {
            get;
            private set;
        }

        public Pueblo PuebloActual
        {
            get => default;
            set
            {
            }
        }

        public Pueblo PuebloDestino
        {
            get => default;
            set
            {
            }
        }

        public double Distancia
        {
            get=> default;
            set
            {
            }
        }

        public double Duracion
        {
            get => default;
            set
            {
            }
        }

        public int Compra
        {
            get => default;
            set
            {
            }
        }

        public bool ValidarReservaPueblo(Pueblo pueblo)
        {
            var iDisponible = true;

            if (pueblo.InsumosDisponibles<4) iDisponible =false;
            
            return iDisponible;
            
        }

     
        public void Comprar(Pueblo pueblo,Viaje viaje)
        {
            int DisponibleCompraPueblo = pueblo.InsumosDisponibles - 3;

            if (DisponibleCompraPueblo > viaje.ObjetivoCompra)
            {
                Compra = viaje.ObjetivoCompra;
            }
            else
            {
                Compra = DisponibleCompraPueblo;
            }               
        }

        //La distancia se da en Kilometros
        public void CalcularDistancia()
        {
            double distancia = Math.Sqrt((Math.Pow(PuebloActual.PosicionEnX - PuebloDestino.PosicionEnX,2)+Math.Pow(PuebloActual.PosicionEnY-PuebloDestino.PosicionEnY,2)));
            this.Distancia=distancia;
                                                    
        }

        /*La duración se da en Horas*/
        public void ValidarDuracion(Escoba escoba)
        {
            double duracion = Distancia / escoba.Velocidad;
            this.Duracion = duracion;                                  
        }   
        
    }
}