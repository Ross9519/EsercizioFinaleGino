namespace SummaryExercise.Print
{
    public class ConsolePrint : IPrint
    {
        public void Print(IEnumerable<string> words)
        {
            words.ToList().ForEach(i => Console.WriteLine(i));
        }
    }
}
