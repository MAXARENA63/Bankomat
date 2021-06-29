using System;

namespace BankWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные для создания аккаунта");
            var account = Bank.InputAccount();
            
            Bankomat.Welcome();
            var bankomat = new Bankomat(account);

            if (!bankomat.InputPassword())
            { 
                Bankomat.Goodbye();
                return;
            }
            else
            {
                var exit = false;
                do
                {
                    Bankomat.Menu();
                    var select = CLI.Input("");

                    switch (select)
                    {
                        case "1": // 1. Внести деньги на счёт
                            bankomat.InputMoney();
                            break;
                        case "2": // 2. Снять деньги со счёта
                            bankomat.OutputMoney();
                            break;
                        case "3": // 3. Показать остаток на счёте
                            CLI.PrintInfo(bankomat.Account.GetMoney().ToString());
                            break;
                        case "0": // 0. Выход
                            exit = true;
                            break;
                    }
                } while (!exit);
                Bankomat.Goodbye();
            }
        }
    }
}