using System.Threading.Channels;

namespace FirstTask
{
    public abstract class Document : IInit, IComparable<Document>, IComparer<Document>
    {
        public abstract string Type { get; }
        public abstract string Number { get; set; }
        public abstract string From { get; set; }
        public abstract string To { get; set; }
        public abstract string Sign { get; set; }
        public abstract DateTime Date { get; set; }

        public void ShowBaseInfo()
        {
            Console.WriteLine("\nИнформация о документе: ");
            Console.WriteLine("Тип документа: " + Type);
            Console.WriteLine("Номер документа: " + Number);
            Console.WriteLine("Отправитель: " + From);
            Console.WriteLine("Получатель: " + To);
            Console.WriteLine("Подписано: " + Sign);
            Console.WriteLine("Дата: " + Date);
        }

        public void BaseInit()
        {
            Console.WriteLine("Введите номер документа: ");
            Number = Console.ReadLine();

            Console.WriteLine("Введите от кого отправляется документ: ");
            From = Console.ReadLine();

            Console.WriteLine("Введите кому отправляется документ: ");
            To = Console.ReadLine();

            Console.WriteLine("Введите подпись: ");
            Sign = Console.ReadLine();

            Date = DateTime.Today;
        }

        public void RandomBaseInit()
        {
            Random rnd = new Random();

            Number = $"№{rnd.Next(0, 100)}";

            string[] cities = { "Пермь", "Москва", "Санкт-Петербург", "Новосибирск" };
            From = cities[rnd.Next(cities.Length)];
            
            To = cities[rnd.Next(cities.Length)];

            string[] signs = { "Иванов", "Петров", "Смирнов", "Орлов" };
            Sign = signs[rnd.Next(signs.Length)];

            Date = DateTime.Today;
        }

        // Абстрактный метод для сравнения документов
        public abstract int CompareTo(Document other);
        public abstract int Compare(Document? x, Document? y);
        public abstract void Init();
        public abstract void Show();
        public abstract void RandomInit();
    }
}