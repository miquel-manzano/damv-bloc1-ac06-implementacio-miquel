public class Program
{
    public static void Main(string[] args)
    {
        const string MsgInput = "Enter temperature in Celsius: ";
        const string MsgResult = "Temperature in Kelvin: ";

        double celsius, kelvin;

        Console.Write(MsgInput);
        celsius = Convert.ToDouble(Console.ReadLine());
        kelvin = celsius + 273.15;
        Console.WriteLine(MsgResult + kelvin);
    }
}