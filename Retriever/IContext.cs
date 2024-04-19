namespace Retriever
{
    public interface IContext : IDisposable
    {
        public IEnumerable<Item> GetAll();

        public Item? GetOne(int id);

        public void Save(Item item);

        public void Delete(Item item);
    }
}
