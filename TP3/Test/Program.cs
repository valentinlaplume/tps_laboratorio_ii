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
                Console.WriteLine(">>>>>>>>> Leo Autos por archivo JSON");
                List<Auto> autos = Json<List<Auto>>.LeerDatos("Autos_JSON");

                Console.WriteLine(">>>>>>>>> Leo Camionetas por archivo JSON");
                List<Camioneta> camionetas = Json<List<Camioneta>>.LeerDatos("Camionetas_JSON");

                Console.WriteLine(">>>>>>>>> Leo Motocicletas por archivo XML");
                List<Motocicleta> motocicletas = Xml<Motocicleta>.LeerDatos("Motocicletas_XML");

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


            }
            catch(AtributoInvalidoException ex)
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
