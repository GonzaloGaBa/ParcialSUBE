using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParcialSUBE.Enumerados;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ParcialSUBE.Personas
{

    [Serializable]
    public class Administrador : Persona    
    {
        string nombreAdmin;
        string contraseña;

        public Administrador()
        {
            
        }

        public Administrador(string nombreAdmin, string contraseña, string nombre, string apellido, TipoUsuario tipoUsuario,Sexo sexo) : base(nombre, apellido, tipoUsuario, sexo)
        {
            this.nombreAdmin = nombreAdmin;
            this.contraseña = contraseña;
        }

        public class Sistema
        {
            private List<Persona> admin
                ;

            public Sistema()
            {
                admin = new List<Persona>();
            }

            //public void CrearUsuario(string nombreAdmin, string contraseña, TipoUsuario tipoUsuario,Sexo sexo)
            //{
            //    Persona nuevoUsuario = new()
            //    {
            //        NombreAdmin = nombreUsuario,
            //        Contraseña = contraseña,
            //        TipoUsuario = tipoUsuario,
            //        Sexo = sexo
            //    };

            //    usuarios.Add(nuevoUsuario);
            //}
            //public void EliminarUsuario(string nombreUsuario)
            //{
            //    Persona usuarioAEliminar = usuarios.Find(u => u.NombreUsuario == nombreUsuario);

            //    if (usuarioAEliminar != null)
            //    {
            //        usuarios.Remove(usuarioAEliminar);
            //    }
            //}

            //public void ModificarUsuario(string nombreUsuario, string nuevaContraseña)
            //{
            //    Persona usuarioAModificar = usuarios.Find(u => u.NombreUsuario == nombreUsuario);

            //    if (usuarioAModificar != null)
            //    {
            //        usuarioAModificar.Contraseña = nuevaContraseña;
            //    }
            //}
            //public void CargarSube(string nombreUsuario, double monto)
            //{
            //    Usuario usuario = usuarios.Find(u => u.NombreUsuario == nombreUsuario) as Usuario;

            //    if (usuario != null)
            //    {
            //        usuario.CargarSube(monto);
            //    }
            //}

            //public void ConsultarSaldo(string nombreUsuario)
            //{
            //    Usuario usuario = usuarios.Find(u => u.NombreUsuario == nombreUsuario) as Usuario;

            //    if (usuario != null)
            //    {
            //        usuario.ConsultarSaldo();
            //    }
            //}

            //public void ConsultarUltimosViajes(string nombreUsuario)
            //{
            //    Usuario usuario = usuarios.Find(u => u.NombreUsuario == nombreUsuario) as Usuario;

            //    if (usuario != null)
            //    {
            //        usuario.ConsultarUltimosViajes();
            //    }
            //}

            //public void AcreditarCarga(string nombreUsuario, double monto)
            //{
            //    Usuario usuario = usuarios.Find(u => u.NombreUsuario == nombreUsuario) as Usuario;

            //    if (usuario != null)
            //    {
            //        usuario.AcreditarCarga(monto);
            //    }
            //}
        }
    }

}
