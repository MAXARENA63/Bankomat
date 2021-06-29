namespace BankWork
{
    public class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        
        public Client() {}

        public Client(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}