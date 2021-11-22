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
        [TestMethod]
        public void LeerAutosJson_Test()
        {
            // arrange
            List<Auto> listAutosPrueba = new List<Auto>();

            // act
            listAutosPrueba = Json<List<Auto>>.LeerDatos("Autos_JSON");

            //assert
            Assert.IsNotNull(listAutosPrueba);
        }

    }
}
