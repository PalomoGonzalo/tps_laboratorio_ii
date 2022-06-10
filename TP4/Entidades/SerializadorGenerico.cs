using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;


namespace Entidades
{
    public class SerializadorGenerico<T>
    {


        static string ruta;
        static SerializadorGenerico()
        {
            ruta = AppContext.BaseDirectory;
        }
        public static void EscribirJson(T datos, string archivo)
        {
            string completa = ruta + @"\" + archivo + ".json";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string objetoJson = JsonSerializer.Serialize(datos);
                File.WriteAllText(completa, objetoJson);
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static T LeerJson(string nombreArchivo)
        {
            T datos = default;
            string completa = ruta + @"\" + nombreArchivo + ".json";
            try
            {
                if (Directory.Exists(ruta))
                {
                    string archivoJson = File.ReadAllText(completa);
                    datos = JsonSerializer.Deserialize<T>(archivoJson);
                }
                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static void EscribirXml(T datos, string archivo)
        {
            string completa = ruta + @"\" + archivo + ".xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(sw, datos);
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static T LeerXml(string nombreArchivo)
        {

            T datos = default;
            string completa = ruta + @"\" + nombreArchivo + ".xml";

            try
            {
                if (Directory.Exists(ruta))
                {
                    using (StreamReader sr = new StreamReader(completa))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        datos = (T)xmlSerializer.Deserialize(sr);
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
