using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialSUBE.Personas;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;


namespace ParcialSUBE
{
    
    public static class CoreDelSistema
    {
        //static string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //static string nombre = @"\MisUsuarios.xml";
        //static string path = ruta + nombre;

        #region Atributos

        static List<Usuario> usuariosRegistrados;

        #endregion

        #region Constructores
        static CoreDelSistema()
        {

            usuariosRegistrados = new List<Usuario>();

            CargarUsuarios();

        }
        #endregion

        #region GettersAndSetters
            public static List<Usuario> UsuariosRegistrados { get => usuariosRegistrados; set => usuariosRegistrados = value; }
        #endregion

        #region Métodos
        private static void CargarUsuarios()
        {
            usuariosRegistrados.Add(new Usuario("GonzaMusic", "hiao1816", "Gonzalo", "Barrientos", Enumerados.TipoUsuario.Administrador, Enumerados.Sexo.Masculino));
            usuariosRegistrados.Add(new Usuario("KatyRea", "jigazus", "Katherine", "Rea", Enumerados.TipoUsuario.Usuario, Enumerados.Sexo.Femenino));
        }


        public static Usuario LogearUsuario(string user, string contra, Enumerados.TipoUsuario tipoUsuario)
        {
            // Verifica si el nombre de usuario o la contraseña son nulos o vacíos
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(contra))
                return null;

            foreach (Usuario item in usuariosRegistrados)
            {
                // Compara el nombre de usuario (ignorando mayúsculas y minúsculas), la contraseña y el tipo de usuario
                if (item.NombreUsuario.ToLower() == user.ToLower() && item.Contraseña == contra && item.TipoUsuario == tipoUsuario)
                {
                    // Si se encuentra un usuario que coincide, devuelve ese usuario
                    return item;
                }
            }
            return null;
        }

        public static string MostrarUsuarios()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuario item in usuariosRegistrados)
            {
                sb.AppendLine(item.Nombre);
            }

            return sb.ToString();

        }

        public static void ActualizarUsuarios()
        {
            Serializadora.EscribirJson(@"C:\Users\Claudia\Desktop\ParcialSUBE.json", CoreDelSistema.UsuariosRegistrados);
            Serializadora.EscribirXML(@"C:\\Users\\Claudia\\Desktop\\ParcialSUBE.xml", CoreDelSistema.UsuariosRegistrados);
        }
        #endregion

    }
}
