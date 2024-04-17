namespace SummaryExercise.Search
{
    public interface IDataHandler
    {
        IEnumerable<string> Search(string word);

        bool Add(Item item);
    }
}
