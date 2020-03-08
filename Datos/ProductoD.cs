using System;
using System.Data.SqlClient;
namespace Datos
{
    class ProductoD
    {

        private Conexion con = new Conexion();



        SqlCommand coman = new SqlCommand();



        public void InsertarProducto(string nombre)

        {

            try
            {
                coman.Connection = con.Conectar();
                coman.CommandText = "Insert into Prod Values ('" + nombre + "')";
                coman.ExecuteNonQuery();
                coman.Parameters.Clear();
            }
            catch (Exception)
            {

            }




        }

        public void InsertarPrecio(int venta, int compra)
        {
            try
            {
                coman.Connection = con.Conectar();
                coman.CommandText = "Insert into ProPrecio Values ('" + venta + "','" + compra + "')";
                coman.ExecuteNonQuery();
                coman.Parameters.Clear();
            }
            catch (Exception)
            {

            }
        }


    }
}
