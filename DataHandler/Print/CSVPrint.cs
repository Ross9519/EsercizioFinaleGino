namespace DataHandler.Print
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
            words.ToList().ForEach(i => Print(i));
        }

        //così hai più flessibilità, puoi stampare da 1 a n stringhe
        public void Print(string words)
        {
            using var writer = File.AppendText(_path);
            writer.WriteLine(words);
        }
    }
}
