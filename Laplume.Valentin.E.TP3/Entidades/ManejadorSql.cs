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

        static ManejadoraSql()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source= DESKTOP-SI4GNH1; Database= TP4_VALENTIN_LAPLUME ;Trusted_Connection=True;";

            Comando = new SqlCommand();
            Comando.CommandType = CommandType.Text; // que tipo de query vas a ejecutar
            Comando.Connection = Conexion; // se agrega a donde se conecta, podes cambiar la Conexion

        }

        public static string GetQueryInsert(string tipoVehiculo)
        {
            string query = "";
            switch (tipoVehiculo.ToLower().Trim())
            {
                case "auto":
                case "camioneta":
                    query = $"INSERT INTO {tipoVehiculo}s VALUES (@marca, @nombre, @año, @km, @tipoCombustible, @tipoTransmision, @color, @precio, @cantidadPuertas)";
                    break;
                case "motocicleta":
                    query = $"INSERT INTO {tipoVehiculo}s VALUES (@marca, @nombre, @año, @km, @tipoCombustible, @tipoTransmision, @color, @precio)";
                    break;
            }

            return query;
        } // ver si sacar !!!!!

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

        public static bool DeleteAuto(string tipoVehiculo, int id)
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
        }

        public static void Consulta(string query)
        {
            try
            {
                
            }
            catch(Exception)
            {
                throw new Exception("Fallo en la consulta con la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }

        public static List<Auto> GetAutos()
        {
            try
            {
                List<Auto> autosLeidos = new List<Auto>(); // aca instancio la lista de lo que quiero leer
                Comando.CommandText = "SELECT * FROM Autos WHERE estado = 1";

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
                throw new Exception("Fallo al leer datos desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }
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
                throw new Exception("Fallo al leer datos desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }
        public static List<Motocicleta> GetMotocicletas()
        {
            try
            {
                List<Motocicleta> camionetasLeidas = new List<Motocicleta>(); // aca instancio la lista de lo que quiero leer
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
                throw new Exception("Fallo al leer datos desde la base de datos.");
            }
            finally
            {
                Conexion.Close();
            }
        }

        //public static void LeerDatos(string query)
        //{
        //    try
        //    {
        //        // aca instancio la lista de lo que quiero leer
        //        List<string> nombresAutos = new List<string>();
        //        query = "SELECT Nombre FROM Autos";
        //        Comando.CommandText = query;

        //        if (Conexion.State != ConnectionState.Open)  { Conexion.Open(); }

        //        Lector = Comando.ExecuteReader();
        //        while (Lector.Read())
        //        {
        //            nombresAutos.Add(Lector["Nombre"].ToString());
        //            //    int id;
        //            //    string nombre;
        //            //    int año;
        //            //    int km;
        //            //    ETipoCombustible tipoCombustible;
        //            //    ETipoTransmision tipoTransmision;
        //            //    EColor color;
        //            //    float precio;
        //            //    int estado;
        //            //    EMarcaAutomovil marca;
        //            //    int cantidadPuertas;
        //            //}
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Fallo al leer datos desde la base de datos.");
        //    }
        //    finally
        //    {
        //        Conexion.Close();
        //    }
        //}


        //public static List<Personas> Consulta()
        //{
        //    List<Personas> lista = new List<Personas>();
        //    try
        //    {
        //        //Personas p = new Personas("", "");
        //        //Personas p2 = new Personas($"{p.Id}", "");
        //        Comando.CommandText = $"select * from personas";
        //        Comando.Parameters.Clear();

        //        if (Conexion.State != ConnectionState.Open)
        //            Conexion.Open();

        //        Lector = Comando.ExecuteReader();

        //        while (Lector.Read())
        //        {

        //            lista.Add(new Personas(
        //                               Lector["Dni"].ToString(),
        //                               Lector["Nombre"].ToString()
        //                                ));

        //        }

        //        return lista;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"fallo la base: {ex.Message}");
        //    }
        //    finally
        //    {
        //        Conexion.Close();
        //    }
        //}


    }
}
