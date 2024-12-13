public interface IVisual
{
    string Name { get; set; }
    void DrawObject();
}

public class Texting:IVisual
{
    public Texting(string pText)
    {
        Text = pText;
    }
    private string Text;

    public string Name 
    { 
        get
        {
            return Text;
        }
        set
        {
            Text = value;
        }
    }
    public void DrawObject()
    {
        Console.WriteLine
            (
                " _____         _             _          \n" +
                "/  ___|       | |           | |         \n" +
                "\\ `--.   ___  | |__    __ _ | | __ __ _ \n" +
                " `--. \\ / _ \\ | '_ \\  / _` || |/ // _` |\n" +
                "/\\__/ /| (_) || |_) || (_| ||   <| (_| |\n" +
                "\\____/  \\___/ |_.__/  \\__,_||_|\\_\\\\__,_|\n"
            );
        Console.WriteLine (Name);
    }
}
public class Picture: IVisual
{
    public Picture(string pFranchise, string pThis)
    {
        Franchise = pFranchise;
        This = pThis;
    }

    private string Franchise;
    private string This;

    public string Name 
    { 
        get
        {
            return Franchise + " - " + This;
        }
        set
        {
            This = value;
        }
    }

    public void DrawObject()
    {
        Console.WriteLine
            (
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⡴⠒⣙⠓⠲⢦⣀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣀⣀⣰⠋⣰⣿⠿⠿⢷⣦⡈⢻⡀⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⡎⢠⣦⠄⣴⣿⠇⠄⣶⣤⣤⣁⠄⣇⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⢀⡾⢀⣿⠃⢰⣿⣿⠄⠄⠙⠿⠿⣿⡧⢘⡇⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⢸⠄⣼⡏⢀⣿⣿⣿⣷⣤⣀⣀⡀⠄⢀⡼⠃⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⢿⠐⠿⠄⣼⣿⣿⣿⣿⣿⣿⣿⡿⠄⡾⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⢈⡷⠄⣴⣿⣿⠟⠿⣿⣿⣿⣿⠃⣸⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⢸⡅⠸⢿⡿⢃⡄⢠⣤⣬⡿⢃⣼⠃⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠉⠓⠤⠴⠿⣄⠻⠿⢋⣠⠋⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠉⠳⠖⠋⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n" +
                "⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n"
            );
        Console.WriteLine(Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.Title = "Лабораторная работа 9";

        Texting h = new Texting("Маркус Станислав Витальевич");
        h.DrawObject();

        Console.WriteLine("\n\n\n");

        Picture p = new Picture("Among Us", "Imposter in the Space");
        p.DrawObject();

        Console.ReadKey();
    }
}