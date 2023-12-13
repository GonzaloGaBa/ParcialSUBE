using ParcialSUBE.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace ParcialSUBE
{
    public class Serializadora
    {
        #region Métodos
        public static void EscribirXML(string path, List<Usuario> lista)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Usuario>));
                ser.Serialize(sw, lista);

            }
        }
        public static List<Usuario> LeerXML(string path)
        {
            List<Usuario> lista;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Usuario>));

                lista = (List<Usuario>)des.Deserialize(sr);
            }

            return lista;
        }

        public static void EscribirJson(string ruta, List<Usuario> lista)
        {
            try
            {
                string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }

        public static List<Usuario> LeerJson(string path)
        {
            List<Usuario> lista = null;
            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            return lista;
        }
        #endregion
    }
}
