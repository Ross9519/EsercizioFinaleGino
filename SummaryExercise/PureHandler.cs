using SummaryExercise.Print;
using SummaryExercise.Search;

namespace SummaryExercise
{
    public class PureHandler
    {
        private readonly IDataHandler _handler;
        private readonly IPrint _print;

        public PureHandler(IDataHandler dataHandler, IPrint print)
        {
            _handler = dataHandler;
            _print = print;
        }

        public IEnumerable<string> Search(string word)
        {
            return _handler.Search(word);
        }

        public bool Add(Item item)
        {
            return _handler.Add(item);
        }

        public void Print(IEnumerable<string> words)
        {
            _print.Print(words);
        }
    }
}
