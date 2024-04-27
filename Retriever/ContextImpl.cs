
namespace Retriever
{
    public abstract class ContextImpl : IContext
    {
        protected readonly string _info;

        protected ContextImpl(string info)
        {
            _info = info;
        }

        public abstract void Delete(Item item);
        public abstract void Dispose();
        public abstract IEnumerable<Item> GetAll();
        public abstract Item? GetOne(int id);
        public abstract void Save(Item item);
    }
}
