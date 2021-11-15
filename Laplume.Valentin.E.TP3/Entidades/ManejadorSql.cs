using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

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
        }


        public static void Insertar(Func<string, string> queryInsert,
                                    int id,
                                    int marca,
                                    string nombre,
                                    int año,
                                    int km,
                                    int tipoCombustible,
                                    int tipoTransmision,
                                    int color,
                                    float precio,
                                    int cantidadPuertas)
        {

            //Comando.CommandText = queryInsert.Invoke("auto");
            Comando.CommandText = $"INSERT INTO Autos VALUES (@id,@marca,@nombre,@año,@km,@tipoCombustible,@tipoTransmision,@color,@precio,@cantidadPuertas)";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@id", id);
            Comando.Parameters.AddWithValue("@marca", marca);
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@año", año);
            Comando.Parameters.AddWithValue("@km", km);
            Comando.Parameters.AddWithValue("@tipoCombustible", tipoCombustible);
            Comando.Parameters.AddWithValue("@color", color);
            Comando.Parameters.AddWithValue("@precio", precio);
            Comando.Parameters.AddWithValue("@cantidadPuertas", cantidadPuertas);


        }

        public static bool InsertarAutos(List<Auto> autos)
        {
            try
            {
                // (id,marca,nombre,año,km,tipoCombustible,tipoTransmision,color,precio,cantidadPuertas)
                Comando.CommandText = $"INSERT INTO Autos VALUES (@id,@marca,@nombre,@año,@km,@tipoCombustible,@tipoTransmision,@color,@precio,@cantidadPuertas)";
                foreach (Auto item in autos)
                {
                    Comando.Parameters.AddWithValue("@id", item.Id);
                    Comando.Parameters.AddWithValue("@marca", (int)item.Marca);
                    Comando.Parameters.AddWithValue("@nombre", item.Nombre);
                    Comando.Parameters.AddWithValue("@año", item.Año);
                    Comando.Parameters.AddWithValue("@km", item.Km);
                    Comando.Parameters.AddWithValue("@tipoCombustible", (int)item.TipoCombustible);
                    Comando.Parameters.AddWithValue("@tipoTransmision", (int)item.TipoTransmision);
                    Comando.Parameters.AddWithValue("@color", (int)item.Color);
                    Comando.Parameters.AddWithValue("@precio", item.Precio);
                    Comando.Parameters.AddWithValue("@precio", item.Precio);
                    Comando.Parameters.AddWithValue("@cantidadPuertas", item.CantidadPuertas);
                    Comando.Parameters.Clear();
                    Conexion.Open();
                    Comando.ExecuteNonQuery();
                    //Comando.CommandText += $"Insert into Pacientes values ({item.Dni},'{item.Nombre}',{(int)item.Dolencia},0); ";
                }


                //if (Conexion.State != ConnectionState.Open)
                //{
                //}

                return true;
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

        public static void Insertar2(
                                    int marca,
                                    string nombre,
                                    int año,
                                    int km,
                                    int tipoCombustible,
                                    int tipoTransmision,
                                    int color,
                                    float precio,
                                    int estado)
        {
            try
            {
                Comando.CommandText = $"INSERT INTO motocicletas VALUES (@marca,@nombre,@año,@km,@tipoCombustible,@tipoTransmision,@color,@precio,@estado)";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@marca", marca);
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@año", año);
                Comando.Parameters.AddWithValue("@km", km);
                Comando.Parameters.AddWithValue("@tipoCombustible", tipoCombustible);
                Comando.Parameters.AddWithValue("@tipoTransmision", tipoTransmision);
                Comando.Parameters.AddWithValue("@color", color);
                Comando.Parameters.AddWithValue("@precio", precio);
                Comando.Parameters.AddWithValue("@estado", estado);

                if (Conexion.State != ConnectionState.Open)
                {
                    Conexion.Open();
                }

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrio un error al insertar datos en la Base de Datos. {ex.Message}");
            }
            finally
            {
                Conexion.Close();
            }
        }


        public static void Consulta(string consulta)
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

        public static List<Auto> GetDatosDBAutos(string query)
        {
            try
            {
                List<Auto> autos = new List<Auto>(); // aca instancio la lista de lo que quiero leer
                Comando.CommandText = query;

                if (Conexion.State != ConnectionState.Open) { Conexion.Open(); }

                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    //autos.Add(new Auto((int)Lector["marca"],
                    //    Lector["nombre"].ToString()));
                                    //marca,
                                    //nombre,
                                    //año,
                                    //km,
                                    //tipoCombustible,
                                    //tipoTransmision,
                                    //color,
                                    //precio,
                                    //cantidadPuertas)
                }

                return new List<Auto>();

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
