using Debugging_Demo_Code;

public class Program
{
    public static void Main()
    {
        int a, b, c, d;
        // should be true at 14, 30, 44 only
        for (int i = 3; i < 1000; i++)
        {
            Console.WriteLine(VerdiantComputer.ComputeVerdiance(i));
        }
    }
}
