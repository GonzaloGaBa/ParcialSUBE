using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;
using System.Globalization;
using Newtonsoft.Json;

namespace ParcialSUBE.Personas
{

    [Serializable]
    public class Usuario : Persona
    {
        #region Atributos
        private List<Viaje> viajes = new List<Viaje>();
        string nombreUsuario;
        string contraseña;
        double saldo = 0;
        public static double compraDiara = 20000;
        #endregion

        #region Constructores
        public Usuario()
        {
            
        }

        public Usuario(string nombreUsuario,string contraseña ,string nombre, string apellido, Enumerados.TipoUsuario tipoUsuario, Enumerados.Sexo sexo) : base(nombre, apellido, tipoUsuario, sexo)
        {
            
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
        #endregion

        #region GettersAndSetters
        public double Saldo { get => saldo; set => saldo = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        #endregion

        #region Métodos
        public void CargarSube(double monto)
        {
            this.saldo += monto;

        }
        public string comprarViaje(double cantidad)
        {
            // Se Verifica si el saldo actual es insuficiente para realizar la compra
            if (cantidad > this.saldo)
            {
                return "Fondos insuficientes";
            }     
            else
            {
                if (cantidad > 600000)
                    return "Atención. La cantidad maxima de compra por dia son $600.000";
                else
                {
                    // Se Crea una instancia de la clase Viaje para realizar algunas validaciones adicionales
                    Viaje vaijeAux = new Viaje();
                    if (vaijeAux.topeMaximoCompra(viajes, cantidad))
                    {
                        // Se Realiza la compra y actualiza el saldo y la lista de viajes
                        this.saldo -= cantidad;
                        Viaje viaje = new Viaje(DateTime.Now, cantidad);
                        viajes.Add(viaje);
                        return $"Compra existosa de $ {darFormato(cantidad)} pesos.";
                    }
                    else
                        return $"Atención. Ya superaste el tope diario de viajes. ({darFormato(compraDiara)})";
                }
            }
            
        }

        public string consultarSaldo()
        {
            return $"$ {darFormato(this.saldo)}";
        }

     

        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }
        #endregion

    }
}
