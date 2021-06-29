using System;

namespace BankWork
{
    public class Bankomat
    {
        public static void Welcome()
        {
            CLI.PrintInfo("Приветствуем Вас и ждём ваши деньги");
        }

        public static void Goodbye()
        {
            CLI.PrintInfo("До свидания...");
        }

        public static void Menu()
        {
            CLI.PrintInfo("Выберите один из пунков");
            CLI.PrintInfo("1. Внести деньги на счёт");
            CLI.PrintInfo("2. Снять деньги со счёта");
            CLI.PrintInfo("3. Показать остаток на счёте");
            CLI.PrintInfo("0. Выход");
        }
        public Account Account { get; set; }
        private int _numberOfTry;

        public Bankomat()
        {
            Account = new Account();
            _numberOfTry = 3;
        }

        public Bankomat(Account account)
        {
            Account = account;
            _numberOfTry = 3;
        }

        public bool InputPassword()
        {
            do
            {
                var password = CLI.Input($"{Account.ClientInfo.Name} введите свой пароль: ");

                if (Account.IsCheckPassword(password))
                {
                    CLI.PrintSuccess("Верный пароль");
                    return true;
                }
                else
                {
                    _numberOfTry -= 1;
                    CLI.PrintWarning($"Неверный пароль. Осталось {_numberOfTry} попыток");
                }
            } while (_numberOfTry > 0);
            
            CLI.PrintError("Вы исчерпали все попытки!");
            return false;
        }

        public void InputMoney()
        {
            var money = Convert.ToDouble(CLI.Input("Введите кол-во денег для пополнения: "));
            var res = Account.InputMoney(money);
            while (!res)
            {
                CLI.PrintWarning("Вы ввели неверную сумму. Повторите ввод");
                money = Convert.ToDouble(CLI.Input("Введите кол-во денег для пополнения: "));
                res = Account.InputMoney(money);
            }
            CLI.PrintSuccess($"На вашем счёте стало {Account.GetMoney()}");
        }

        public void OutputMoney()
        {
            var money = Convert.ToDouble(CLI.Input("Введите кол-во денег для снятия: "));
            var res = Account.OutputMoney(money);
            while (!res)
            {
                CLI.PrintWarning("Вы ввели неверную сумму. Повторите ввод");
                money = Convert.ToDouble(CLI.Input("Введите кол-во денег для снятия: "));
                res = Account.OutputMoney(money);
            }
            CLI.PrintSuccess($"На вашем счёте стало {Account.GetMoney()}");
        }
    }
}