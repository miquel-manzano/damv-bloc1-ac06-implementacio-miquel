public class Program
{
    public static void Main(string[] args)
    {
        const double ExchangeRate = 1.12;
        const string MsgInput = "Enter amount in euros: ";
        const string MsgResult = "Amount in dollars: ";

        double euros, dollars;

        Console.Write(MsgInput);
        euros = Convert.ToDouble(Console.ReadLine());
        dollars = euros * ExchangeRate;
        Console.WriteLine(MsgResult + dollars);
    }
}