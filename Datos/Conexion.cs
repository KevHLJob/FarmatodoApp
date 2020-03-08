using System.Data;
using System.Data.SqlClient;
namespace Datos
{


    public class Conexion
    {

        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-T7KQ9T54\\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True");


        public SqlConnection Conectar()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }


            return con;
        }

        public SqlConnection Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            return con;
        }
    }




}

