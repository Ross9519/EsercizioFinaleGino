using Retriever;

namespace DataHandler.Search
{
    public interface IDataHandler
    {
        IEnumerable<string> Search(string word);
        
        bool Add(Item item);
        bool Remove(Item item);
        bool SecureRemove(Item item);
    }
}
