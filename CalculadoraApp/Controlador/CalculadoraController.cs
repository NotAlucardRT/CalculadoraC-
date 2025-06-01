using CalculadoraApp.Modelo;
namespace CalculadoraApp.Controlador
{
    /// <summary>
    /// Controlador que maneja la lógica de las operaciones.
    /// </summary>
    public class CalculadoraControlador
    {
        public double EjecutarOperacion(Operacion operacion, double a, double b)
        {
            return operacion.Calcular(a, b);
        }
    }
}