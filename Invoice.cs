namespace FirstTask;

public class Invoice : Document
{
    public override string Type => "Накладная";
    public override string Number { get; set; }
    public override string From { get; set; }
    public override string To { get; set; }
    public override string Sign { get; set; }
    public override DateTime Date { get; set; }
    public string Content { get; set; }

    public override void Show()
    {
        ShowBaseInfo();
        Console.WriteLine("Контент: " + Content);
    }

    public override int Compare(Document? x, Document? y)
    {
        return x.To.CompareTo(y.To);
    }

    public override void Init()
    {
        BaseInit();

        Console.WriteLine("Введите контент накладной: ");
        Content = Console.ReadLine();
    }

    public override void RandomInit()
    {
        Random rnd = new Random();

        RandomBaseInit();

        string[] content = { "Накладная на покупку дивана", "Накладная на покупку кровати", "Накладная на покупку стола", "Накладная на покупку матраса" };
        Content = content[rnd.Next(content.Length)];
    }

    public override int CompareTo(Document other)
    {
        if (other == null) return 1;
        return string.Compare(this.Number[0].ToString(), other.Number[0].ToString());
    }
}