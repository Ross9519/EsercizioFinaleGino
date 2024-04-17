namespace SummaryExercise.Search
{
    public interface ISpecialDataHandler
    {
        IEnumerable<Item> SpecialSearch(string word);

        bool Add(Item item);
    }
}
