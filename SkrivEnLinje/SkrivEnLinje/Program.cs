namespace SkrivEnLinje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei hva heter du?");
            var input = Console.ReadLine();
            Console.WriteLine($"Kenneth {input}");
            var answer = Console.ReadLine();
            Console.WriteLine($"Kult navn! {answer}");
        }
    }
}
