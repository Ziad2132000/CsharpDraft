namespace C_Draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userInput = Console.ReadLine();
            bool result = int.TryParse(userInput, out int number);
        }
    }
}
