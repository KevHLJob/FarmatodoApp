using Datos;

namespace Negocio
{
    public class FarmaceuticoN
    {


        private FarmaceuticoD farmaceutico = new Datos.FarmaceuticoD();
        public void Guardarprofesional(string codigo, string nombre, string apellido, string cedula,
           string fechanacimiento, string edad, string sexo,
           string telefono, string correo)
        {
            farmaceutico.InsertarProfesional(codigo, nombre, apellido, cedula, fechanacimiento, edad, sexo, telefono, correo);
        }



    }
}
