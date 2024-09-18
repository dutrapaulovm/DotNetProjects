using System.Linq.Expressions;

public class ManagerTask
{
    List<ToDo> tasks = [];

    public void AddTask()
    {
        ToDo todo = new ToDo();
        Console.Write("Name: ");
        todo.Name = Console.ReadLine();
        Console.Write("Description: ");
        todo.Description = Console.ReadLine();
        tasks.Add(todo);
    }

    public void PrintTasks()
    {

        int sizeField = 30;
        Console.Write("Name" + string.Concat(Enumerable.Repeat(" ", 25)) + "\tDescription\n");
        foreach (var item in tasks)
        {
            PrintField(sizeField, item.Name);
            Console.Write("\t");
            PrintField(sizeField, item.Description);
            Console.WriteLine();
        }
        Console.Write("Pressione enter para continuar...");
        Console.ReadLine();

    }

    private void PrintField(int sizeField, string? value)
    {
        if (value?.Length >= sizeField)
            Console.Write(value?.Substring(0, sizeField - 1));
        else
            Console.Write(value?.PadRight(sizeField - value.Length));
    }

    public void CreateOptionsMenu()
    {
        Console.WriteLine("1 - Add Task");
        Console.WriteLine("2 - Print Tasks");
        Console.WriteLine("3 - Exit");
    }

    public void ShowMenu()
    {
        int op = 0;
        do
        {
            CreateOptionsMenu();
            Console.Write("Enter a option: ");
            op = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            ChoiceOptionsMenu(op);
            Console.Clear();

        } while (op != 3);

    }

    private void ChoiceOptionsMenu(int op)
    {
        switch (op)
        {
            case 1:
                AddTask();
                break;

            case 2:
                PrintTasks();
                break;

            default:
                break;
        }

    }
}