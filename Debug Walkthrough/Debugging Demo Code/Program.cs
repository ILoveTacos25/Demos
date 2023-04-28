using Debugging_Demo_Code;

public class Program
{
    public static void Main()
    {
        int a, b, c, d;

        for (int i = 1; i < 1000; i++)
        {
            Console.WriteLine(VerdiantComputer.ComputeVerdiance(i));
        }
    }
}
