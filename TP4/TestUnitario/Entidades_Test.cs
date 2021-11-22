using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;
using Entidades.Enumerados;
using Archivos;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class Entidades_Test
    {
        /// <summary>
        /// Creo un vehiculo del tipo auto y le asigno campos con errores,
        /// me devuelve una excepcion controlada personalizada llamada AtributoInvalidoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AtributoInvalidoException))]
        public void CrearAutoConErrores_Test()
        {
            // arrange
            Auto auto = new Auto(EMarcaAutomovil.Audi,
                                "",
                                90000,
                                19000,
                                ETipoCombustible.Nafta,
                                ETipoTransmision.Manual,
                                EColor.Amarillo,
                                9000,
                                3);

            // act

            //assert
            Assert.IsNull(auto);
        }

        /// <summary>
        /// Lee de un archivo json una lista de autos, y verifica que no sea nulla
        /// </summary>
        //[TestMethod]
        //public void LeerAutosJson_Test()
        //{
        //    // arrange
        //    List<Auto> listAutosPrueba = new List<Auto>();

        //    // act
        //    listAutosPrueba = Json<List<Auto>>.LeerDatos("Autos_JSON");

        //    //assert
        //    Assert.IsNotNull(listAutosPrueba);
        //}

        /// <summary>
        /// Lee desde la base de datos una lista de Motocicletas, y verifica que no sea nulla
        /// </summary>
        [TestMethod]
        public void LeerMotocicletasBaseDatos_Test()
        {
            // arrange
            List<Motocicleta> listMotocicletasPrueba = new List<Motocicleta>();

            // act
            listMotocicletasPrueba = ManejadoraSql.GetMotocicletas();

            //assert
            Assert.IsNotNull(listMotocicletasPrueba);
        }

        /// <summary>
        /// Verifico que el dato insertado se haya insertado en la tabla de la base de de datos correctamente.
        /// </summary>
        [TestMethod]
        public void InsertarAuto_Test()
        {
            // arrange
            bool datoInsertado = true;

            // act
            datoInsertado = ManejadoraSql.InsertarAuto(new Auto(EMarcaAutomovil.Toyota, "InsertarAuto_Test", 2021,0,ETipoCombustible.Nafta,ETipoTransmision.Manual,EColor.Naranja,250000,3));

            //assert
            Assert.IsTrue(datoInsertado);
        }

    }
}
