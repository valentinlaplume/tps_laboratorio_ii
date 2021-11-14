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
            Comando.Connection = Conexion; // se agrega a donde se conecta, podes cambiar la conexion

        }

        public static string GetQueryInsert(string tipoVehiculo, 
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
            string query = "";
            switch (tipoVehiculo)
            {
                case "Auto":
                case "Camioneta":
                    query = $"INSERT INTO {tipoVehiculo}s VALUES (@marca, @nombre, @año, @km, @tipoCombustible, @tipoTransmision, @color, @precio, @cantidadPuertas)";
                    //Comando.CommandText = $"INSERT INTO {tipoVehiculo}s VALUES (@marca, @nombre, @año, @km, @tipoCombustible, @tipoTransmision, @color, @precio, @cantidadPuertas)";
                    break;
                case "Motocicleta":
                    query = $"INSERT INTO {tipoVehiculo}s VALUES (@marca, @nombre, @año, @km, @tipoCombustible, @tipoTransmision, @color, @precio)";
                    break;
            }

            return query;
        }

        public static string Insert2()
        {
            return "";

        }


        public static void Insertar(Func<string> query, string nombre)
        {
            
            Comando.CommandText = $"INSERT INTO Autos VALUES (@nombre)";
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", nombre);


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
