using System;
namespace CalculadoraApp.Modelo
{
    /// <summary>
    /// Clase base abstracta para operaciones matemáticas.
    /// </summary>
    public abstract class Operacion
    {
        public abstract double Calcular(double a, double b);
    }
    public class Suma : Operacion
    {
        public override double Calcular(double a, double b) => a + b;
    }
    public class Resta : Operacion
    {
        public override double Calcular(double a, double b) => a - b;
    }
    public class Multiplicacion : Operacion
    {
        public override double Calcular(double a, double b) => a * b;
    }
    public class Division : Operacion
    {
        public override double Calcular(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }
    }
}