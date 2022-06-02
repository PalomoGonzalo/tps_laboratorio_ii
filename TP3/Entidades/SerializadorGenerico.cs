using System;
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
            ruta = AppContext.BaseDirectory;//Cree 2 archivos configuracion xml y json y se guarda siempre aca.
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
    }
}
