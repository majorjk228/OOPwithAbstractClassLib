using System.Reflection.Metadata;
using System.Xml.Linq;

namespace FirstTask;

public class Receipt : Document
{
    public override string Type => "Квитанция";
    public override string Number { get; set; }
    public override string From { get; set; }
    public override string To { get; set; }
    public override string Sign { get; set; }
    public override DateTime Date { get; set; }
    public decimal Amount { get; set; }

    public override void Show()
    {
        ShowBaseInfo();
        Console.WriteLine("Сумма: " + Amount);
    }

    public override int Compare(Document? x, Document? y)
    {
        return x.Type.CompareTo(y.Type);
    }

    public override void Init()
    {
        BaseInit();

        Console.WriteLine("Введите сумму квитанции: ");
        Amount = Convert.ToDecimal(Console.ReadLine());
    }

    public override void RandomInit()
    {
        Random rnd = new Random();

        RandomBaseInit();

        Amount = rnd.Next(0, 100);
    }

    // Реализация метода CompareTo для учета специфических свойств Receipt
    public override int CompareTo(Document other)
    {
        if (other == null) return 1;
        return string.Compare(this.Number.Length.ToString(), other.Number.Length.ToString());
    }
}