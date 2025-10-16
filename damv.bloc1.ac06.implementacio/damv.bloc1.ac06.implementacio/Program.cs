public class Program
{
    public static void Main(string[] args)
    {
        const string MsgInput = "Enter temperature in Celsius: ";
        const string MsgResult = "Temperature in Kelvin: ";

        float celsius, kelvin;

        Console.Write(MsgInput);
        celsius = (float)Convert.ToDouble(Console.ReadLine());
        kelvin = celsius + 273.15f;
        Console.WriteLine(MsgResult + kelvin);
    }
}