using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public static class Concesionaria
    {
        public static List<Auto> listAutos;
        public static List<Camioneta> listCamionetas;
        public static List<Motocicleta> listMotocicletas;

        static Concesionaria()
        {
            listAutos = new List<Auto>();
            listCamionetas = new List<Camioneta>();
            listMotocicletas = new List<Motocicleta>();

            #region Codigo Comentado harcodeo

            //listAutos = new List<Auto>()
            //{
            //    new Auto(EMarcaAutomovil.Audi, "A3", 2010, 50000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Negro, 2000000, 3),
            //    new Auto(EMarcaAutomovil.Fiat, "500", 2013, 50000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Blanco, 1500000, 3),
            //    new Auto(EMarcaAutomovil.Volkswagen, "Fox Msi", 2015, 30000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Rojo, 1400000, 5),
            //    new Auto(EMarcaAutomovil.Volkswagen, "Fox", 2010, 127000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Gris, 900000, 3),
            //    new Auto(EMarcaAutomovil.Mercedes_Benz, "Smart", 2011, 56000, ETipoCombustible.Electrico, ETipoTransmision.Automatica, EColor.Amarillo, 1650000, 3),
            //    new Auto(EMarcaAutomovil.Mercedes_Benz, "Smart", 2015, 26000, ETipoCombustible.Electrico, ETipoTransmision.Manual, EColor.Naranja, 1950000, 3),
            //    new Auto(EMarcaAutomovil.Fiat, "Palio", 2011, 126000, ETipoCombustible.GNC, ETipoTransmision.Manual, EColor.Azul, 850000, 5),
            //    new Auto(EMarcaAutomovil.Fiat, "147", 1990, 150000, ETipoCombustible.GNC, ETipoTransmision.Manual, EColor.Blanco, 150000, 3),
            //    new Auto(EMarcaAutomovil.Fiat, "Uno", 2001, 120000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Rojo, 500000, 3),
            //    new Auto(EMarcaAutomovil.Fiat, "Duna", 2004, 170000, ETipoCombustible.GNC, ETipoTransmision.Manual, EColor.Blanco, 350000, 5)
            //};


            ////listAutos = Json<List<Auto>>.LeerDatos("jasonListaAutos");

            //listCamionetas = new List<Camioneta>()
            //{
            //    new Camioneta(EMarcaAutomovil.Volkswagen, "Amarok", 2014, 50000, ETipoCombustible.Diesel, ETipoTransmision.Automatica, EColor.Gris, 2200000, 5),
            //    new Camioneta(EMarcaAutomovil.BMW, "X6", 2011, 30000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Azul, 3500000, 5),
            //    new Camioneta(EMarcaAutomovil.Ford, "Ranger", 2014, 80000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Blanco, 2700000, 5),
            //    new Camioneta(EMarcaAutomovil.Ford, "Ranger", 2017, 35000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Negro, 3000000, 5),
            //    new Camioneta(EMarcaAutomovil.Jeep, "Renegade", 2017, 12000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Gris, 2600000, 5),
            //    new Camioneta(EMarcaAutomovil.Fiat, "Toro", 2019, 5000, ETipoCombustible.GNC, ETipoTransmision.Automatica, EColor.Marron, 2300000, 5)
            //};

            //listMotocicletas = new List<Motocicleta>()
            //{
            //    new Motocicleta(EMarcaMotocicleta.Honda, "Cg Titan", 2019, 10000, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Negro, 360000),
            //    new Motocicleta(EMarcaMotocicleta.Honda, "Cb", 2019, 1300, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Rojo, 350000),
            //    new Motocicleta(EMarcaMotocicleta.Bajaj, "Dominar", 2021, 0, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Verde, 825000),
            //    new Motocicleta(EMarcaMotocicleta.Kawasaki, "Ninja", 2021, 0, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Violeta, 2400000),
            //    new Motocicleta(EMarcaMotocicleta.Kawasaki, "Z400", 2021, 0, ETipoCombustible.Nafta, ETipoTransmision.Manual, EColor.Gris, 2000000),
            //    new Motocicleta(EMarcaMotocicleta.Honda, "Biz", 2021, 0, ETipoCombustible.Nafta, ETipoTransmision.Automatica, EColor.Rojo, 250000)
            //};
            #endregion
        }

        #region Codigo comentado propiedades no usadas

        //public static List<Auto> ListAutos
        //{
        //    get { return listAutos.Where(auto => auto.Estado == 1).ToList(); }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value.ToString()))
        //            throw new Exception("Error al crear Lista de Autos.");
        //        else
        //            listAutos = value;
        //    }
        //}
        //public static List<Camioneta> ListCamionetas
        //{
        //    get { return listCamionetas.Where(l => l.Estado == 1).ToList(); }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value.ToString()))
        //            throw new Exception("Error al crear Lista de Camionetas.");
        //        else
        //            listCamionetas = value;
        //    }
        //}
        //public static List<Motocicleta> ListMotocicletas
        //{ 
        //    get { return listMotocicleta.Where(l => l.Estado == 1).ToList(); }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value.ToString()))
        //            throw new Exception("Error al crear Lista de Motocicletas.");
        //        else
        //            listMotocicleta = value;
        //    }
        //}
        #endregion

    }
}
