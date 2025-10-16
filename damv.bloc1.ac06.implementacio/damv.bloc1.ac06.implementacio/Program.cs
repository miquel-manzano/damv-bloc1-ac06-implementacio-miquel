public class Program
{
    public static void Main(string[] args)
    {
        const string MsgInput1 = "Enter the first number: ";
        const string MsgInput2 = "Enter the second number: ";
        const string MsgInput3 = "Enter the third number: ";
        const string MsgResult = "The average is: ";

        double num1, num2, num3, average;

        Console.Write(MsgInput1);
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write(MsgInput2);
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write(MsgInput3);
        num3 = Convert.ToDouble(Console.ReadLine());
        average = (num1 + num2 + num3) / 3;
        Console.Write(MsgResult + average);
    }
}