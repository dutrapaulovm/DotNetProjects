public class Program
{
    public static void Main(string[] args)
    {
        List<string> nomes = [];

        for (int i = 0; i < 5; i++)
        {

            Console.Write("Digite seu nome: ");
            string? nome = Console.ReadLine();
            nomes.Add(nome!);
        }

        Console.WriteLine();
        Console.WriteLine("Total de elementos: " + nomes.Count);

        IEnumerable<string> query = nomes.Where<string>(item => item.ToLower() == "paulo".ToLower());

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

    }

}



