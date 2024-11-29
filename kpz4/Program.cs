using kpz4.Builders;
using kpz4.Directors;
using kpz4.Models;


class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        // Ігровий ноутбук
        NotebookBuilder gamingBuilder = new GamingNotebookBuilder();
        var gamingNotebook = director.ConstructGamingNotebook(gamingBuilder);
        gamingNotebook.ShowConfiguration();

        // Клонування ігрового ноутбука
        var clonedGamingNotebook = (Notebook)gamingNotebook.Clone();
        Console.WriteLine("\nCloned Gaming Notebook Configuration:");
        clonedGamingNotebook.ShowConfiguration();

        Console.WriteLine();

        // Офісний ноутбук
        NotebookBuilder officeBuilder = new OfficeNotebookBuilder();
        var officeNotebook = director.ConstructOfficeNotebook(officeBuilder);
        officeNotebook.ShowConfiguration();

        // Клонування офісного ноутбука
        var clonedOfficeNotebook = (Notebook)officeNotebook.Clone();
        Console.WriteLine("\nCloned Office Notebook Configuration:");
        clonedOfficeNotebook.ShowConfiguration();
    }
}
