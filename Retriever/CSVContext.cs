namespace Retriever
{
    public class CsvContext : IContext
    {

        private List<Item> _items;
        private readonly string _path;

        public CsvContext(string path)
        {
            _path = path;
            _items = [];
        }

        public void RetrieveData()
        {
            using StreamReader reader = new(_path);
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var parts = reader.ReadLine()?.Split(';');
                if (parts is { Length: > 0 })
                {
                    _items.Add(new()
                        {
                            Name = parts[0],
                            Surname = parts[1],
                            Address = parts[2],
                            City = parts[3],
                            Mobile = parts[4],
                            Email = parts[5]
                        });
                }
            }
        }

        public IEnumerable<Item> GetAll()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        public Item? GetOne(int mobile)
        {
            return _items.SingleOrDefault(i => i.Mobile.Equals(mobile.ToString()));
        }

        public void Save(Item item)
        {
            _items.Add(item);
            var toInsert = $"{item.Name};{item.Surname};{item.Address};{item.City};{item.Mobile};{item.Email}";
            using var writer = File.AppendText(_path);
            writer.WriteLine(toInsert);
        }

        public void Delete(Item item)
        {
            _items.Remove(item);
            using var writer = File.CreateText(_path);
            writer.WriteLine("name;surname;adress;city;mobile;email");
            GetAll()
                .Where(i => !i.Mobile.Equals(item.Mobile))
                .Select(it => $"{it.Name};{it.Surname};{it.Address};{it.City};{it.Mobile};{it.Email}")
                .ToList()
                .ForEach(i => writer.WriteLine(i));
        }

        public void Dispose()
        {
            _items.Clear();
        }
    }
}
