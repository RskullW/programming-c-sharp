namespace ConsoleApplication1
{
    public interface IMammal
    {
        int Age { get; set; }
        int Weight { get; set; }
        string Name { get; set; }

        void Display();
        void Display(string message);
        void StartAction(string message = null);
        void SetElements(string name = "", int age = -1, int weight = -1);
    }
}