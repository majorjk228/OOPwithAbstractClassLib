namespace FirstTask;

public class Person : IInit, ICloneable
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Init()
    {
        Random r = new Random();
        Id = r.Next(0);
        FirstName = Console.ReadLine();
        LastName = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine(Id.ToString());
        Console.WriteLine(FirstName);
        Console.WriteLine(LastName);
    }

    public void RandomInit()
    {
        Random r = new Random();
        Id = r.Next(0);
        FirstName = "Alexandr";
        LastName = "Ivanov";
    }

    public object Clone()
    {
        return new Person();
    }
}