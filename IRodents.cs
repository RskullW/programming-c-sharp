namespace ConsoleApplication1
{
    public interface IRodents
    {
        int Age { get; set; }
        int Weight { get; set; }
        string Name { get; set; }
    }
}

/*
TODO: Класс для первой части – капибара.
Возможные классы иерархии: грызуны (базовый), хомяк, бобр, 
мышь.
Возможный интерфейс: IMammal, дополнительный класс – кошка.
*/