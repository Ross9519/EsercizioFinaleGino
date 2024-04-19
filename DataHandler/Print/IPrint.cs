namespace DataHandler.Print
{
    public interface IPrint
    {
        void Print(IEnumerable<string> words);
        void Print(string words);
    }
}
