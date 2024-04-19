namespace DataHandler.Print
{
    public class ConsolePrint : IPrint
    {
        public void Print(IEnumerable<string> words)
        {
            words.ToList().ForEach(i => Print(i));
        }

        public void Print(string words)
        {
            Console.WriteLine(words);
        }
    }
}
