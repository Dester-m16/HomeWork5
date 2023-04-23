using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



interface IDeveloper
{
    string Tool { get; set; }
    void Create();
    void Destroy();
}

class Programmer : IDeveloper, IComparable<Programmer>
{
    public string Language { get; set; }
    public string Tool { get; set; }

    public Programmer(string language, string tool)
    {
        Language = language;
        Tool = tool;
    }

    public void Create()
    {
        Console.WriteLine($"Programmer creates {Language} program using {Tool}.");
    }

    public void Destroy()
    {
        Console.WriteLine($"Programmer destroys {Language} program using {Tool}.");
    }

    public int CompareTo(Programmer other)
    {
        return String.Compare(Language, other.Language);
    }
}

class Builder : IDeveloper, IComparable<Builder>
{
    public string Tool { get; set; }

    public Builder(string tool)
    {
        Tool = tool;
    }

    public void Create()
    {
        Console.WriteLine($"Builder creates building using {Tool}.");
    }

    public void Destroy()
    {
        Console.WriteLine($"Builder destroys building using {Tool}.");
    }

    public int CompareTo(Builder other)
    {
        return String.Compare(Tool, other.Tool);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IDeveloper> developers = new List<IDeveloper>();
        developers.Add(new Programmer("C#", "Visual Studio"));
        developers.Add(new Programmer("Java", "Eclipse"));
        developers.Add(new Builder("Hammer"));
        developers.Add(new Builder("Saw"));

        foreach (var developer in developers)
        {
            developer.Create();
            developer.Destroy();
        }

        Console.WriteLine("\nDevelopers sorted by language/tool:\n");

        foreach (var developer in developers)
        {
            Console.WriteLine(developer.GetType().Name + " using " + developer.Tool);
        }

        Dictionary<uint, string> dictionary = new Dictionary<uint, string>();

        dictionary.Add(1, "John");
        dictionary.Add(2, "Emily");
        dictionary.Add(3, "David");
        dictionary.Add(4, "Sarah");
        dictionary.Add(5, "Michael");
        dictionary.Add(6, "Olivia");
        dictionary.Add(7, "William");

        Console.WriteLine("Enter ID to search:");
        uint id = Convert.ToUInt32(Console.ReadLine());

        string name;
        if (dictionary.TryGetValue(id, out name))
        {
            Console.WriteLine("Name for ID {0} is {1}", id, name);
        }
        else
        {
            Console.WriteLine("ID {0} not found in dictionary", id);
        }

        Console.ReadLine();
    }
}