namespace SummaryExercise.Context
{
    public class CSVContext : IContext
    {

        private List<Item> _items;
        private readonly string _path;

        public CSVContext(string path)
        {
            _path = path;
        }

        public void RetrieveData()
        {
            _items = [];
            using StreamReader reader = new(_path);
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var parts = reader.ReadLine().Split(';');
                if (parts.Length > 0)
                {
                    Item item = new()
                    {
                        Name = parts[0],
                        Surname = parts[1],
                        Address = parts[2],
                        City = parts[3],
                        Mobile = parts[4],
                        Email = parts[5]
                    };
                    _items.Add(item);
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

        public Item GetOne(int mobile)
        {
            return _items.Where(i => i.Mobile.Equals(mobile.ToString())).Single();
        }

        public void Save(Item item)
        {
            _items.Add(item);
            string toInsert = $"{item.Name};{item.Surname};{item.Address};{item.City};{item.Mobile};{item.Email}";
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
                .Select(item => $"{item.Name};{item.Surname};{item.Address};{item.City};{item.Mobile};{item.Email}")
                .ToList()
                .ForEach(i => writer.WriteLine(i));
        }

        public void Dispose()
        {
            _items.Clear();
        }
    }
}
