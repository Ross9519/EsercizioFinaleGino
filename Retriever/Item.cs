namespace Retriever
{
    public class Item
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public override string ToString() => string.Join("|", Name, Surname, Address, City, Mobile, Email);

    }
}