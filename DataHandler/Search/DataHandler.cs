using Retriever;

namespace DataHandler.Search
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

        public bool Remove(Item item)
        {
            try
            {
                _context.Delete(item);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SecureRemove(Item item)
        {
            var itemToRemove = _context
                .GetAll().SingleOrDefault(it => it.Address.Equals(item.Address)
                                                && it.City.Equals(item.City)
                                                && it.Email.Equals(item.Email)
                                                && it.Mobile.Equals(item.Mobile)
                                                && it.Name.Equals(item.Name)
                                                && it.Surname.Equals(item.Surname));
            
            if (itemToRemove == null) throw new KeyNotFoundException("Element to delete not found");
            _context.Delete(itemToRemove);
            return true;
        }

        public abstract IEnumerable<string> Search(string word);
    }
}
