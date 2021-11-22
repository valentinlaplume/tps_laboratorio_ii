using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public static class Xml<T> 
    {
        static string path;


        /// <summary>
        /// Constructor estatoco que inicializa el path donde se van a alojar los datos de formato xml
        /// </summary>
        static Xml()
        {
            //path = Directory.GetCurrentDirectory();
            path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\Datos_XML\";
        }
        /// <summary>
        /// Guarda en formato xml una lista del tipo que se asigne en T
        /// </summary>
        /// <param name="nombreArchivo"> nombre del archivo a guardar </param>
        /// <param name="datos"> datos</param>
        public static void GuardarDatos(string nombreArchivo, List<T> datos)
        {
            string pathArchivo = path + nombreArchivo + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(pathArchivo))
                {
                    //XmlSerializer xmlSerializer = new XmlSerializer(pj.GetType());
                    XmlSerializer xmlSerializer = new XmlSerializer(datos.GetType());
                    xmlSerializer.Serialize(streamWriter, datos);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrió un error al quere guardar Datos XML el archivo ubicado en {pathArchivo}.", e);
            }
        }

        /// <summary>
        /// Lee un archivo json y retorna el tipo especificado en lista T
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public static List<T> LeerDatos(string nombreArchivo)
        {
            string archivo = string.Empty;
            List<T> datosRecuperados = default;
            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombreArchivo))
                        {
                            archivo = path;
                            break; // Chequear !
                        }
                    }

                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                            datosRecuperados = (List<T>)xmlSerializer.Deserialize(sr);
                        }
                    }
                    else
                    {
                        throw new ArchivosException($"Archivo: {nombreArchivo}, no fue encontrado.", "Método LeerDatos, clase Json");
                    }
                }

                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}.", e);
            }

        }



    }
}
