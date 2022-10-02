internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("----------");
        Console.WriteLine("Please Enter First Number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose Operator: +,-,*,/");
        string operator1 = (Console.ReadLine());

        if (operator1 == "+")
        {
            Console.WriteLine($"Answer is : {firstNumber + secondNumber}");
        }
        else if (operator1 == "-")
        {
            Console.WriteLine($"Answer is : {firstNumber - secondNumber}");
        }
        else if (operator1 == "*")
        {
            Console.WriteLine($"Answer is : {firstNumber * secondNumber}");
        }
        else if (operator1 == "/")
        {
            Console.WriteLine($"Answer is : {firstNumber / secondNumber}");
        }
        else
        {
            Console.WriteLine("ERROR");
        }


    }
}