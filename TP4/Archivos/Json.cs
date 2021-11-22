using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Archivos
{
    public static class Json<T> where T : class
    {
        static string path;

        /// <summary>
        /// Constructor estatoco que inicializa el path donde se van a alojar los datos de formato json
        /// </summary>
        static Json()
        {
            //C:\Users\valentin\source\repos\Laplume.Valentin.E.TP3
            //path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path = Directory.GetCurrentDirectory();
            path = AppDomain.CurrentDomain.BaseDirectory;
            path += @"\Datos_JSON\";
        }

        /// <summary>
        /// Guarda en formato json del tipo que se asigne en T
        /// </summary>
        /// <param name="nombreArchivo"> nombre del archivo a guardar </param>
        /// <param name="datos"> datos</param>
        public static void GuardarDatos(string nombreArchivo, T datoGuardar) 
        {
            string patchArchivo = path + nombreArchivo + /*+ "_" + DateTime.Now.ToString("HH_mm_ss_FF") +*/ ".js";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string miJson = JsonSerializer.Serialize(datoGuardar);
                File.WriteAllText(patchArchivo, miJson);

            }
            catch (ArchivosException e)
            {
                throw new ArchivosException($"Ocurrió un error en el archivo ubicado en {path}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"Ocurrió un error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Lee un archivo json y retorna el tipo especificado en T
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public static T LeerDatos(string nombreArchivo)
        {
            string archivo = string.Empty;
            T datosRecuperados = default;
            try
            {
                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombreArchivo))
                        {
                            archivo = path;
                            break; // ver
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
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
                throw new Exception($"Ocurrió un error en el archivo ubicado en {path}", e);
            }

        }
    }
}

// ------------------------------------ DE YOUTUBE
//namespace Archivos
//{
//    public class Json<T> : IArchivo<T> where T : class
//    {
//        static string path;
//        static Json()
//        {
//            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            path += @"\Archivos-Serializacion\";
//        }

//        public bool GuardarDatos(string pathArchivo, T datoGuardar)
//        {
//            try
//            {
//                if (!Directory.Exists(path))
//                {
//                    Directory.CreateDirectory(path);
//                }

//                string miJson = JsonSerializer.Serialize(datoGuardar);
//                pathArchivo += DateTime.Now.ToString("HH_mm_ss_FFF");

//                File.WriteAllText(pathArchivo, miJson);
//                return true;
//            }
//            catch (Exception e)
//            {
//                throw new Exception(e.Message);
//            }
//        }

//        public bool LeerDatos(string pathArchivo, out T datoLeer)
//        {
//            //string pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            //pathArchivo += @"\ProjectoJson\nombreArchivo.js";
//            try
//            {
//                string miJson = File.ReadAllText(pathArchivo);
//                datoLeer = JsonSerializer.Deserialize<T>(miJson);
//                return true;
//            }
//            catch
//            {
//                throw new Exception();
//            }
//        }

//    }
//}

