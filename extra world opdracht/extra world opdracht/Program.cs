namespace extra_world_opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";
            
            foreach (char letter in text)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(letter);
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }
    }
}