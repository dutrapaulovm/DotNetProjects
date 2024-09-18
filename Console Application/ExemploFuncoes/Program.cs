public class Program
{

    public static int Fatorial(int n)
    {
        if ((n == 0) || (n == 1))
            return 1;

        int result = n;
        for (int i = n - 1; i > 1; i--)
        {
            result = i * result;
        }

        return result;

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Fatorial(5));
    }

}