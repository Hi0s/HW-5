public class UnitConversion{
    public static int FeetToInches(int value) {
        return value * 12;
    }
    public static int YardsToInches(int value)
    {
        return value * 3 * 12;
    }
}
delegate int ConversionDelegate(int value);
class Program
{
    static void Main(string[] args)
    {
        int choice,value;
        Console.WriteLine("Enter a value: ");
        while(!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input, please enter an integer number.");
        }
        Console.WriteLine("Choose a conversion: 1. Feet to Inches 2. Yards to Inches");
        while(!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input, please choose 1. Feet to Inches 2. Yards to Inches");
        }
        while (choice != 1 && choice != 2)
        {
            Console.WriteLine("Invalid choice, please choose 1. Feet to Inches 2. Yards to Inches");
            _ = int.TryParse(Console.ReadLine(), out choice);
        }
        if (choice == 1)
        {
            ConversionDelegate conversion = new ConversionDelegate(UnitConversion.FeetToInches);
            Console.WriteLine($"{value} feet is {conversion(value)} inches.");
        }
        else if (choice == 2)
        {
            ConversionDelegate conversion = new ConversionDelegate(UnitConversion.YardsToInches);
            Console.WriteLine($"{value} yards is {conversion(value)} inches.");
        }
    }
}