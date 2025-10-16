using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
        const string MsgInputWidth = "Enter the width of the rectangle: ";
        const string MsgInputHeight = "Enter the height of the rectangle: ";
        const string MsgResult = "The area of the rectangle is: ";

        double width, height, area;

        Console.Write(MsgInputWidth);
        width = Convert.ToDouble(Console.ReadLine());
        Console.Write(MsgInputHeight);
        height = Convert.ToDouble(Console.ReadLine());
        area = width * height;
        Console.WriteLine(MsgResult + area);
    }
}