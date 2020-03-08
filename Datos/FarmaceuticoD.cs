using System;
using System.Data.SqlClient;
namespace Datos
{
    public class FarmaceuticoD
    {

        private Conexion con = new Conexion();



        SqlCommand coman = new SqlCommand();



        public void InsertarProfesional(string codigo, string nombre, string apellido, string cedula,
            string fechanacimiento, string edad, string sexo, string telefono, string correo)

        {

            try
            {
                coman.Connection = con.Conectar();
                coman.CommandText = "Insert into Farmaceutico Values ('" + codigo + "','" + nombre + "','" + apellido +
                    "','" + cedula + "','" + fechanacimiento +
                    "','" + edad + "','" + sexo + "','" + telefono + "','" + correo + "')";
                coman.ExecuteNonQuery();
                coman.Parameters.Clear();
            }
            catch (Exception)
            {

            }




        }


    }

}

