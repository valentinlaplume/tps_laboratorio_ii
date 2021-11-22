using Archivos;
using Entidades;
using System;
using System.Collections.Generic;
using Excepciones;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(">>>>>>>>> Leo Autos desde Base de datos");
                List<Auto> autos = ManejadoraSql.GetAutos();
                //List<Auto> autos = Json<List<Auto>>.LeerDatos("Autos_JSON");

                Console.WriteLine(">>>>>>>>> Leo Camionetas desde Base de datos");
                List<Camioneta> camionetas = ManejadoraSql.GetCamionetas();
                //List<Camioneta> camionetas = Json<List<Camioneta>>.LeerDatos("Camionetas_JSON");

                Console.WriteLine(">>>>>>>>> Leo Motocicletas desde Base de datos");
                List<Motocicleta> motocicletas = ManejadoraSql.GetMotocicletas();
                //List<Motocicleta> motocicletas = Xml<Motocicleta>.LeerDatos("Motocicletas_XML");

                Console.WriteLine("///////////////////////////////////////////////////////////////");
                Console.WriteLine("");


                if (autos != null)
                {
                    Console.WriteLine(">>>>>>>>> Muestro Autos leidos");
                    autos.ForEach(x => Console.WriteLine(x.MostrarEnFormatoCSV()));
                    Console.WriteLine("");
                }

                if (camionetas != null)
                {
                    Console.WriteLine(">>>>>>>>> Muestro Camionetas");
                    camionetas.ForEach(x => Console.WriteLine(x.MostrarEnFormatoCSV()));
                    Console.WriteLine("");

                }

                if (motocicletas != null)
                {
                    Console.WriteLine(">>>>>>>>> Muestro Motocicletas");
                    motocicletas.ForEach(x => Console.WriteLine(x.MostrarEnFormatoCSV()));
                    Console.WriteLine("");

                }

                Console.WriteLine("///////////////////////////////////////////////////////////////");
                Console.WriteLine("");

                if (autos != null)
                {
                    Console.WriteLine(">>>>>>>>> Muestro Autos filtrados por color NEGRO");
                    List<Auto> autosColorNegro = Filtrar<Auto>.FiltrarListaPorColor(autos, Entidades.Enumerados.EColor.Negro);
                    autosColorNegro.ForEach(x => Console.WriteLine(x.MostrarEnFormatoCSV()));
                    Console.WriteLine("");
                }

                if (camionetas != null)
                {
                    Console.WriteLine(">>>>>>>>> Muestro Camionetas filtrados por color GRIS");
                    List<Camioneta> camionetasColorGris = Filtrar<Camioneta>.FiltrarListaPorColor(camionetas, Entidades.Enumerados.EColor.Gris);
                    camionetasColorGris.ForEach(x => Console.WriteLine(x.MostrarEnFormatoCSV()));
                    Console.WriteLine("");
                }

                if (motocicletas != null)
                {
                    Console.WriteLine(">>>>>>>>> Muestro Motocicletas filtrados por color ROJO");
                    List<Motocicleta> motocicletasColorRojo = Filtrar<Motocicleta>.FiltrarListaPorColor(motocicletas, Entidades.Enumerados.EColor.Rojo);
                    motocicletasColorRojo.ForEach(x => Console.WriteLine(x.MostrarEnFormatoCSV()));
                    Console.WriteLine("");
                }


                Console.WriteLine(">>>>>>>>> Muestro Algunas Estadísticas");
                Console.WriteLine("");
                Console.WriteLine("- COLOR QUE MAS ABUNDA:");
                Console.WriteLine("* Utilizacion de metodo de extensión MaxColor() *");
                Console.WriteLine($"AUTOS: {autos.MaxColor()}");
                Console.WriteLine($"CAMIONETAS: {camionetas.MaxColor()}");
                Console.WriteLine($"MOTOCICLETAS: {motocicletas.MaxColor()}");
                Console.WriteLine("");

                Console.WriteLine("- VEHÍCULOS QUE SUPERAN LOS 100.000 KILÓMETROS:");
                Console.WriteLine("AUTOS:");
                Console.WriteLine(Estadistica<Auto>.GetPorcentajesVehiculosPorKilometros(autos, true, 100000));
                Console.WriteLine("CAMIONETAS:");
                Console.WriteLine(Estadistica<Camioneta>.GetPorcentajesVehiculosPorKilometros(camionetas, true, 100000));
                Console.WriteLine("MOTOCICLETAS:");
                Console.WriteLine(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorKilometros(motocicletas, true, 100000));
                Console.WriteLine("");

                Console.WriteLine("- VEHÍCULOS SUPERIORES AL AÑO 2010");
                Console.WriteLine("AUTOS:");
                Console.WriteLine(Estadistica<Auto>.GetPorcentajesVehiculosPorAño(autos, true, 2010));
                Console.WriteLine("CAMIONETAS:");
                Console.WriteLine(Estadistica<Camioneta>.GetPorcentajesVehiculosPorAño(camionetas, true, 2010));
                Console.WriteLine("MOTOCICLETAS:");
                Console.WriteLine(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorAño(motocicletas, true, 2010));
                Console.WriteLine("");

            }
            catch (AtributoInvalidoException ex)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ocurrió un error.");
            }

        }
    }
}
