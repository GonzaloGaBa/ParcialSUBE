using ParcialSUBE.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSUBE
{ 
    public class Viaje
    {
        #region Atributos
        DateTime fecha;
        double valorViaje;
        double compraDiara;
        #endregion

        #region Constructores
        public Viaje()
        {

        }

        public Viaje(DateTime fecha, double valorViaje)
        {
            this.fecha = fecha;
            this.valorViaje = valorViaje;
        }

        #endregion

        #region GettersAndSetters
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double ValorViaje { get => valorViaje; set => valorViaje = value; }
        public double CompraDiara { get => compraDiara; set => compraDiara = value; }

        #endregion

        #region Métodos
        public bool topeMaximoCompra(List<Viaje> viajes, double cantidad)
        {
            foreach (var viaje in viajes)
            {
                if (DateTime.Now.Date == viaje.Fecha.Date)
                {
                    compraDiara += viaje.valorViaje;
                }
            }
            compraDiara += cantidad;
            if (compraDiara > Usuario.compraDiara)
            {
                return false;
            }
            compraDiara -= cantidad;
            return true;
        }
        #endregion

    }
    
}
