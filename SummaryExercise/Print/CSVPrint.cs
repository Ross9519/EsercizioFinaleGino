namespace SummaryExercise.Print
{
    public class CSVPrint : IPrint
    {
        private readonly string _path;

        public CSVPrint(string path)
        {
            _path = path;
        }

        public void Print(IEnumerable<string> words)
        {
            using var writer = File.AppendText(_path);
            words.ToList().ForEach(i => writer.WriteLine(i));
        }
    }
}
