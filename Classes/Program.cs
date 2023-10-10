namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Ford", "Escape", 2003);
            Console.WriteLine($"{c.Make} {c.Model} {c.Year} ");
        }
    }
}
