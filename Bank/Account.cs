namespace BankWork
{
    public class Account
    {
        public string Number { get; set; }
        public Client ClientInfo { get; set; }
        public string Password { get; set; }

        private double _money;

        public Account()
        {
            ClientInfo = new Client();
        }

        public Account(string number, Client clientInfo, string password)
        {
            Number = number;
            ClientInfo = clientInfo;
            Password = password;
        }

        public bool IsCheckPassword(string password)
        {
            return Password == password;
        }

        public double GetMoney()
        {
            return _money;
        }

        public bool InputMoney(double money)
        {
            if (money < 0) return false;

            _money += money;
            return true;
        }

        public bool OutputMoney(double money)
        {
            if (money < 0) return false;
            if (money > _money) return false;

            _money -= money;
            return true;
        }
    }
}