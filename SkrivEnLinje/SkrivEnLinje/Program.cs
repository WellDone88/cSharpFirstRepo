namespace SkrivEnLinje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei hva heter du?");
            var input = Console.ReadLine();
            Console.WriteLine($"Hygglig å møte deg {input}, hva kan jeg hjelpe deg med i dag?");
            var answer = Console.ReadLine();
            Console.WriteLine($"Oki!Da må du bruke google og søke etter: {answer}. Er det noe annet jeg kan hjelpe deg med?"!);
            Console.ReadLine();
            Console.WriteLine("Dette gidder jeg ikke, ha en fin dag!");

            return;
        }
    }
}
