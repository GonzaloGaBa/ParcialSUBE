using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ParcialSUBE.Personas
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]

    public class Persona
    {
        #region Atributos

        private string nombre;
        private string apellido;
        private Enumerados.TipoUsuario tipoUsuario;
        private Enumerados.Sexo sexo;

        #endregion

        #region Constructores
        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(string nombre, string apellido, Enumerados.TipoUsuario tipoUsuario, Enumerados.Sexo sexo) : this(nombre, apellido)
        {
            this.sexo = sexo;
            this.tipoUsuario = tipoUsuario;
        }
        #endregion

        #region GettersAndSetters

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Enumerados.TipoUsuario TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public Enumerados.Sexo Sexo { get => sexo; set => sexo = value; }

        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder sbPersona = new StringBuilder();

            sbPersona.AppendLine(nombre);
            sbPersona.AppendLine(apellido);
            sbPersona.AppendLine(sexo.ToString());

            return sbPersona.ToString();
        }
        #endregion
    }

}