namespace FirstTask;

public class Cheque : Document
{
    public override string Type => "Чек";
    public override string Number { get; set; }
    public override string From { get; set; }
    public override string To { get; set; }
    public override string Sign { get; set; }
    public override DateTime Date { get; set; }
    public string Bank { get; set; }
    public string AccountNumber { get; set; }
    public decimal Amount { get; set; }

    public override void Show()
    {
        ShowBaseInfo();
        Console.WriteLine("Банк: " + Bank);
        Console.WriteLine("Аккаунт: " + AccountNumber);
        Console.WriteLine("Сумма: " + Amount);
    }

    public override int Compare(Document? x, Document? y)
    {
        return x.From.CompareTo(y.From);
    }

    public override void Init()
    {
        BaseInit();

        Console.WriteLine("Введите банк: ");
        Bank = Console.ReadLine();

        Console.WriteLine("Введите номер аккаунт: ");
        AccountNumber = Console.ReadLine();

        Console.WriteLine("Введите сумму чека: ");
        Amount = Convert.ToDecimal(Console.ReadLine());
    }

    public override void RandomInit()
    {
        Random rnd = new Random();

        RandomBaseInit();

        string[] content = { "Сбербанк", "Тинькофф", "Совкомбанк", "ВТБ" };
        Bank = content[rnd.Next(content.Length)];

        AccountNumber = rnd.Next(0, 100).ToString();
        Amount = rnd.Next(0, 100);
    }
    public override int CompareTo(Document other)
    {
        if (other == null) return 1;
        return string.Compare(this.Number, other.Number);
    }
}