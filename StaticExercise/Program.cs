namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 98.6;
            double celsius = 37;

            Console.WriteLine($"{fahrenheit}F = {TempConverter.CelsiusToFahrenheit(fahrenheit)}C");
            Console.WriteLine($"{celsius}C = {TempConverter.CelsiusToFahrenheit(celsius)}F");
        }
    }
}
