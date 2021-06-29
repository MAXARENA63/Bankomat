using System;

namespace BankWork
{
    public static class Bank
    {
        public static Client InputClient()
        {
            var name = CLI.Input("Введите имя: ");
            var phone = CLI.Input("Введите номер телефона: ");
            return new Client(name, phone);
        }

        public static string GetNumber(int size)
        {
            var number = string.Empty;
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                var digit = random.Next(0, 9);
                number += digit.ToString();
            }

            return number;
        }

        public static Account InputAccount()
        {
            var client = InputClient();
            var number = GetNumber(16);
            var password = CLI.Input("Введите пароль: ");
            return new Account(number: number, clientInfo: client, password: password);
        }
    }
}