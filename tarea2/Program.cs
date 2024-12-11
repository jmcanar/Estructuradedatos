using System;

// Clase para representar un Círculo
public class Circulo
{
    // Campo privado para el radio (tipo de dato primitivo double)
    private double radio;

    // Constructor
    public Circulo(double radio)
    {
        // Validación para evitar radios negativos
        if (radio <= 0)
        {
            throw new ArgumentException("El radio debe ser un valor positivo.");
        }
        this.radio = radio;
    }

    // Propiedad para acceder al radio de manera controlada
    public double Radio 
    { 
        get { return radio; }
        private set { radio = value; }
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // Método para calcular el perímetro (circunferencia) del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para representar un Cuadrado
public class Cuadrado
{
    // Campo privado para el lado (tipo de dato primitivo double)
    private double lado;

    // Constructor
    public Cuadrado(double lado)
    {
        // Validación para evitar lados negativos
        if (lado <= 0)
        {
            throw new ArgumentException("El lado debe ser un valor positivo.");
        }
        this.lado = lado;
    }

    // Propiedad para acceder al lado de manera controlada
    public double Lado 
    { 
        get { return lado; }
        private set { lado = value; }
    }

    // Método para calcular el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

// Clase de ejemplo para demostrar el uso
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("Universidad Estatal Amazonica");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("Nombre: Marcelo Canar Juncal");
        Console.WriteLine("Parelo A ");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        // Ejemplo de uso de la clase Círculo
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("Círculo:");
        Console.WriteLine($"Radio: {miCirculo.Radio}");
        Console.WriteLine($"Área: {miCirculo.CalcularArea():F2}");
        Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro():F2}");
        // Ejemplo de uso de la clase Cuadrado
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Cuadrado miCuadrado = new Cuadrado(4);
        Console.WriteLine("Cuadrado:");
        Console.WriteLine($"Lado: {miCuadrado.Lado}");
        Console.WriteLine($"Área: {miCuadrado.CalcularArea()}");
        Console.WriteLine($"Perímetro: {miCuadrado.CalcularPerimetro()}");
    }
}