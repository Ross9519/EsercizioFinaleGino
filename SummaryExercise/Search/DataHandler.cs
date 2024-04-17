using SummaryExercise.Context;

namespace SummaryExercise.Search
{
    public abstract class DataHandler : IDataHandler
    {
        protected IContext _context;

        public DataHandler(IContext context)
        {
            _context = context;
        }

        public bool Add(Item item)
        {

            try
            {
                _context.Save(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public abstract IEnumerable<string> Search(string word);
    }
}
