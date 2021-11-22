using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Entidades.Enumerados;

namespace Entidades
{

    public static class ManejadoraSql
    { 
        static SqlConnection Conexion;
        static SqlCommand Comando; // lleva la consulta
        static SqlDataReader Lector;

        /// <summary>
        /// Constructor estático, iniciliza variables las cuales son utlizadas con la base de datos
        /// </summary>
        static ManejadoraSql()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source= DESKTOP-SI4GNH1; Database= TP4_VALENTIN_LAPLUME ;Trusted_Connection=True;";

            Comando = new SqlCommand();
            Comando.CommandType = CommandType.Text; // que tipo de query vas a ejecutar
            Comando.Connection = Conexion; // se agrega a donde se conecta, podes cambiar la Conexion
        }

        #region Metodos no usados

        public static bool InsertarAutos(List<Auto> autos)
        {
            try
            {
                foreach (Auto item in autos)
                {
                    InsertarAuto(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.Close();
            }

        }
        public static bool InsertarCamionetas(List<Camioneta> camionetas)
        {
            try
            {
                foreach (Camioneta item in camionetas)
                {
                    InsertarCamioneta(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.Close();
            }

        }
        public static bool InsertarMotocicletas(List<Motocicleta> motocicletas)
        {
            try
            {
                foreach (Motocicleta item in motocicletas)
                {
                    InsertarMotocicleta(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Conexion.Close();
            }

        }

        #endregion

        /// <summary>
        /// Agrega un Auto a la tabla Autos
        /// </summary>
        /// <param name="auto"></param>
        /// <returns> si la operacion fue correcta retorna true, de lo contrario false </returns>
        public static bool InsertarAuto(Auto auto)
        {
            try
            {
                // (id,marca,nombre,año,km,tipoCombustible,tipoTransmision,color,precio,cantidadPuertas)
                Comando.Parameters.Clear();
                Comando.CommandText = $"INSERT INTO Autos VALUES (@marca,@nombre,@año,@km,@tipoCombustible,@tipoTransmision,@color,@precio,@cantidadPuertas,@estado)";
                Comando.Parameters.AddWithValue("@marca", (int)auto.Marca);
                Comando.Parameters.AddWithValue("@nombre", auto.Nombre);
                Comando.Parameters.AddWithValue("@año", auto.Año);
                Comando.Parameters.AddWithValue("@km", auto.Km);
                Comando.Parameters.AddWithValue("@tipoCombustible", (int)auto.TipoCombustible);
                Comando.Parameters.AddWithValue("@tipoTransmision", (int)auto.TipoTransmision);
                Comando.Parameters.AddWithValue("@color", (int)auto.Color);
                Comando.Parameters.AddWithValue("@precio", auto.Precio);
                Comando.Parameters.AddWithValue("@cantidadPuertas", auto.CantidadPuertas);
                Comando.Parameters.AddWithValue("@estado", auto.Estado);


                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                if (Comando.ExecuteNonQuery() == 1) { return true; }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al insertar datos de Autos en la Base de Datos.");
            }
            finally
            {
                Conexion.Close();
            }

        }
        /// <summary>
        /// Agrega una Camioneta a la tabla Camionetas
        /// </summary>
        /// <param name="auto"></param>
        /// <returns> si la operacion fue correcta retorna true, de lo contrario false </returns>
        public static bool InsertarCamioneta(Camioneta camioneta)
        {
            try
            {
                // (id,marca,nombre,año,km,tipoCombustible,tipoTransmision,color,precio,cantidadPuertas)
                Comando.Parameters.Clear();
                Comando.CommandText = $"INSERT INTO Camionetas VALUES (@marca,@nombre,@año,@km,@tipoCombustible,@tipoTransmision,@color,@precio,@cantidadPuertas,@estado)";
                Comando.Parameters.AddWithValue("@marca", (int)camioneta.Marca);
                Comando.Parameters.AddWithValue("@nombre", camioneta.Nombre);
                Comando.Parameters.AddWithValue("@año", camioneta.Año);
                Comando.Parameters.AddWithValue("@km", camioneta.Km);
                Comando.Parameters.AddWithValue("@tipoCombustible", (int)camioneta.TipoCombustible);
                Comando.Parameters.AddWithValue("@tipoTransmision", (int)camioneta.TipoTransmision);
                Comando.Parameters.AddWithValue("@color", (int)camioneta.Color);
                Comando.Parameters.AddWithValue("@precio", camioneta.Precio);
                Comando.Parameters.AddWithValue("@cantidadPuertas", camioneta.CantidadPuertas);
                Comando.Parameters.AddWithValue("@estado", camioneta.Estado);

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                if (Comando.ExecuteNonQuery() == 1) { return true; }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al insertar datos de Camioneta en la Base de Datos.");
            }
            finally
            {
                Conexion.Close();
            }

        }
        /// <summary>
        /// Agrega una Motocicleta a la tabla Motocicletas
        /// </summary>
        /// <param name="auto"></param>
        /// <returns> si la operacion fue correcta retorna true, de lo contrario false </returns>
        public static bool InsertarMotocicleta(Motocicleta moto)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = $"INSERT INTO Motocicletas VALUES (@marca,@nombre,@año,@km,@tipoCombustible,@tipoTransmision,@color,@precio,@estado)";
                Comando.Parameters.AddWithValue("@marca", (int)moto.Marca);
                Comando.Parameters.AddWithValue("@nombre", moto.Nombre);
                Comando.Parameters.AddWithValue("@año", moto.Año);
                Comando.Parameters.AddWithValue("@km", moto.Km);
                Comando.Parameters.AddWithValue("@tipoCombustible", (int)moto.TipoCombustible);
                Comando.Parameters.AddWithValue("@tipoTransmision", (int)moto.TipoTransmision);
                Comando.Parameters.AddWithValue("@color", (int)moto.Color);
                Comando.Parameters.AddWithValue("@precio", moto.Precio);
                Comando.Parameters.AddWithValue("@estado", moto.Estado);

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                if (Comando.ExecuteNonQuery() == 1) { return true; }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al insertar datos de Motocicletas en la Base de Datos.");
            }
            finally
            {
                Conexion.Close();
            }

        }


        /// <summary>
        /// Baja logica de un vehiculo, deja campo estado en 0
        /// </summary>
        /// <returns></returns>
        public static bool DeleteVehiculo(string tipoVehiculo, int id)
        {
            try
            {
                Comando.Parameters.Clear();
                Comando.CommandText = $"UPDATE {tipoVehiculo}s SET estado = 0 WHERE id = {id}";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                if (Comando.ExecuteNonQuery() == 1) { return true; }

                return false;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al eliminar Vehículo en la Base de Datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }

        /// <summary>
        /// Modifica un vehiculo
        /// </summary>
        /// <returns></returns>
        public static bool ModificarVehiculo(string tipoVehiculo, Auto auto, Camioneta camioneta, Motocicleta moto)
        {
            try
            {
                Comando.Parameters.Clear();
                int id = 0;

                switch (tipoVehiculo)
                {
                    case "Auto":
                        Comando.Parameters.AddWithValue("@marca", (int)auto.Marca);
                        Comando.Parameters.AddWithValue("@nombre", auto.Nombre);
                        Comando.Parameters.AddWithValue("@año", auto.Año);
                        Comando.Parameters.AddWithValue("@km", auto.Km);
                        Comando.Parameters.AddWithValue("@tipoCombustible", (int)auto.TipoCombustible);
                        Comando.Parameters.AddWithValue("@tipoTransmision", (int)auto.TipoTransmision);
                        Comando.Parameters.AddWithValue("@color", (int)auto.Color);
                        Comando.Parameters.AddWithValue("@precio", auto.Precio);
                        Comando.Parameters.AddWithValue("@cantidadPuertas", auto.CantidadPuertas);
                        id = auto.Id;

                        Comando.CommandText = $"UPDATE {tipoVehiculo}s SET marca = @marca, nombre = @nombre, año = @año, km = @km, tipoCombustible = @tipoCombustible, tipoTransmision = @tipoTransmision, color = @color, precio = @precio, cantidadPuertas = @cantidadPuertas WHERE id = {id}";
                        break;
                    case "Camioneta":
                        Comando.Parameters.AddWithValue("@marca", (int)camioneta.Marca);
                        Comando.Parameters.AddWithValue("@nombre", camioneta.Nombre);
                        Comando.Parameters.AddWithValue("@año", camioneta.Año);
                        Comando.Parameters.AddWithValue("@km", camioneta.Km);
                        Comando.Parameters.AddWithValue("@tipoCombustible", (int)camioneta.TipoCombustible);
                        Comando.Parameters.AddWithValue("@tipoTransmision", (int)camioneta.TipoTransmision);
                        Comando.Parameters.AddWithValue("@color", (int)camioneta.Color);
                        Comando.Parameters.AddWithValue("@precio", camioneta.Precio);
                        Comando.Parameters.AddWithValue("@cantidadPuertas", camioneta.CantidadPuertas);
                        id = camioneta.Id;

                        Comando.CommandText = $"UPDATE {tipoVehiculo}s SET marca = @marca, nombre = @nombre, año = @año, km = @km, tipoCombustible = @tipoCombustible, tipoTransmision = @tipoTransmision, color = @color, precio = @precio, cantidadPuertas = @cantidadPuertas WHERE id = {id}";
                        break;
                    case "Motocicleta":
                        Comando.Parameters.AddWithValue("@marca", (int)moto.Marca);
                        Comando.Parameters.AddWithValue("@nombre", moto.Nombre);
                        Comando.Parameters.AddWithValue("@año", moto.Año);
                        Comando.Parameters.AddWithValue("@km", moto.Km);
                        Comando.Parameters.AddWithValue("@tipoCombustible", (int)moto.TipoCombustible);
                        Comando.Parameters.AddWithValue("@tipoTransmision", (int)moto.TipoTransmision);
                        Comando.Parameters.AddWithValue("@color", (int)moto.Color);
                        Comando.Parameters.AddWithValue("@precio", moto.Precio);
                        id = moto.Id;

                        Comando.CommandText = $"UPDATE {tipoVehiculo}s SET marca = @marca, nombre = @nombre, año = @año, km = @km, tipoCombustible = @tipoCombustible, tipoTransmision = @tipoTransmision, color = @color, precio = @precio WHERE id = {id}";
                        break;
                }

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                if (Comando.ExecuteNonQuery() == 1) { return true; }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al modificar Vehículo en la Base de Datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }

        /// <summary>
        /// Obtiene lista de Auto
        /// </summary>
        /// <returns>  lista de autos </returns>
        public static List<Auto> GetAutos()
        {
            try
            {
                List<Auto> autosLeidos = new List<Auto>(); 
                //Comando.CommandText = "SELECT * FROM Autos WHERE estado = 1";
                Comando.CommandText = "SELECT * FROM Autos WHERE nombre <> 'InsertarAuto_Test' AND estado = 1";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    autosLeidos.Add(new Auto((int)Lector["id"],
                                            (EMarcaAutomovil)Lector["marca"],
                                            Lector["nombre"].ToString(),
                                            int.Parse(Lector["año"].ToString()),
                                            int.Parse(Lector["km"].ToString()),
                                            (ETipoCombustible)Lector["tipoCombustible"],
                                            (ETipoTransmision)Lector["tipoTransmision"],
                                            (EColor)Lector["color"],
                                            float.Parse(Lector["precio"].ToString()),
                                            int.Parse(Lector["cantidadPuertas"].ToString())));
                }
                return autosLeidos;
            }
            catch (Exception)
            {
                throw new Exception("Fallo al leer datos de Autos desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }
        /// <summary>
        /// Obtiene lista de Camionetas
        /// </summary>
        /// <returns> lista de Camionetas </returns>
        public static List<Camioneta> GetCamionetas()
        {
            try
            {
                List<Camioneta> camionetasLeidas = new List<Camioneta>(); // aca instancio la lista de lo que quiero leer
                Comando.CommandText = "SELECT * FROM Camionetas WHERE estado = 1";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    camionetasLeidas.Add(new Camioneta((int)Lector["id"],
                                            (EMarcaAutomovil)Lector["marca"],
                                            Lector["nombre"].ToString(),
                                            int.Parse(Lector["año"].ToString()),
                                            int.Parse(Lector["km"].ToString()),
                                            (ETipoCombustible)Lector["tipoCombustible"],
                                            (ETipoTransmision)Lector["tipoTransmision"],
                                            (EColor)Lector["color"],
                                            float.Parse(Lector["precio"].ToString()),
                                            int.Parse(Lector["cantidadPuertas"].ToString())));
                }
                return camionetasLeidas;
            }
            catch (Exception)
            {
                throw new Exception("Fallo al leer datos de Camionetas desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }
        /// <summary>
        /// Obtiene lista de Motocicletas
        /// </summary>
        /// <returns> lista de Motocicletas </returns>
        public static List<Motocicleta> GetMotocicletas()
        {
            try
            {
                List<Motocicleta> camionetasLeidas = new List<Motocicleta>(); 
                Comando.CommandText = "SELECT * FROM Motocicletas WHERE estado = 1";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    camionetasLeidas.Add(new Motocicleta((int)Lector["id"],
                                            (EMarcaMotocicleta)Lector["marca"],
                                            Lector["nombre"].ToString(),
                                            int.Parse(Lector["año"].ToString()),
                                            int.Parse(Lector["km"].ToString()),
                                            (ETipoCombustible)Lector["tipoCombustible"],
                                            (ETipoTransmision)Lector["tipoTransmision"],
                                            (EColor)Lector["color"],
                                            float.Parse(Lector["precio"].ToString())));
                }
                return camionetasLeidas;
            }
            catch (Exception)
            {
                throw new Exception("Fallo al leer datos de Motocicletas desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }

        /// <summary>
        /// Obtiene ID Max del tipo de vehiculo pasado
        /// </summary>
        /// <returns> ID Max del tipo de vehiculo pasado </returns>
        public static int GetIdMaxVehiculo(string tipoVehiculo)
        {
            try
            {
                int idMax = 0;
                Comando.CommandText = $"SELECT MAX(id) idMax FROM {tipoVehiculo}s";

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    idMax = (int)Lector["idMax"];
                }
                return idMax;
            }
            catch (Exception ex)
            {
                throw new Exception($"Fallo al leer id Max de {tipoVehiculo}s desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }

    }
}
