using Retriever;


namespace DataHandler.Search
{
    public class TotalDataHandler : DataHandler, ISpecialDataHandler
    {
        public TotalDataHandler(IContext context) : base(context) { }

        public override IEnumerable<string> Search(string word)
        {
            IEnumerable<Item> items = _context.GetAll();
            foreach (var item in items)
            {
                if (item.Name.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                    yield return $"{word} trovata: in profilo {item.Name} {item.Surname}. E' il suo Nome";
                if (item.Surname.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                    yield return $"{word} trovata: in profilo {item.Name} {item.Surname}. E' il suo Cognome";
                if (item.Address.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                    yield return $"{word} trovata: in profilo {item.Name} {item.Surname}. E' il suo Indirizzo";
                if (item.City.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                    yield return $"{word} trovata: in profilo {item.Name} {item.Surname}. E' la sua Città";
                if (item.Mobile.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                    yield return $"{word} trovata: in profilo {item.Name} {item.Surname}. E' il suo Numero di telefono";
                if (item.Email.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                    yield return $"{word} trovata: in profilo {item.Name} {item.Surname}. E' la sua Email";
            }
        }

        public IEnumerable<Item> SpecialSearch(string word)
        {
            return _context
                .GetAll()
                .Where
                (i =>
                    i.Name.Contains(word, StringComparison.CurrentCultureIgnoreCase) ||
                    i.Surname.Contains(word, StringComparison.CurrentCultureIgnoreCase) ||
                    i.Address.Contains(word, StringComparison.CurrentCultureIgnoreCase) ||
                    i.City.Contains(word, StringComparison.CurrentCultureIgnoreCase) ||
                    i.Mobile.Contains(word, StringComparison.CurrentCultureIgnoreCase) ||
                    i.Email.Contains(word, StringComparison.CurrentCultureIgnoreCase)
                );
        }
    }
}
