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


        // aggiunto l'override di Equals, adesso il metodo remove elimina effettivamente
        // l'istanza anche se creata al momento
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is Item tmp)
                return  Name.Equals(tmp.Name)       &&
                        Surname.Equals(tmp.Surname) &&
                        Address.Equals(tmp.Address) &&
                        City.Equals(tmp.City)       &&
                        Mobile.Equals(tmp.Mobile)   &&
                        Email.Equals(tmp.Email);
            return false;
        }

        public override string ToString() => string.Join("|", Name, Surname, Address, City, Mobile, Email);

    }
}