using kpz4.Builders;
using kpz4.Directors;


class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        NotebookBuilder gamingBuilder = new GamingNotebookBuilder();
        var gamingNotebook = director.ConstructGamingNotebook(gamingBuilder);
        gamingNotebook.ShowConfiguration();

        Console.WriteLine();
    
        NotebookBuilder officeBuilder = new OfficeNotebookBuilder();
        var officeNotebook = director.ConstructOfficeNotebook(officeBuilder);
        officeNotebook.ShowConfiguration();
    }
}
