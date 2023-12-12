namespace Task2
{
    public class CreditCard
    {
        public string accountNumber;
        public int currentBalance;

        public CreditCard()//конструктор по умолчанию
        {

        }
        public CreditCard(string accountNumber, int currentBalance)//конструктор, который принимает на вход 2 параметра
        {
            this.accountNumber = accountNumber;
            this.currentBalance = currentBalance;
        }
        public void AddMoney(int money)//метод для пополнения карты
        {
            Console.WriteLine($"Лицевой счет: {this.accountNumber}");
            this.currentBalance += money;
            Console.WriteLine($"На ваш счет было зачислено: {money} рублей.");
            Console.WriteLine($"Текущий остаток {currentBalance} рублей.\n");
        }
        public void DelMoney(int money)//метод для списания средств, с проверкой на достаточность
        {
            Console.WriteLine($"Лицевой счет: {this.accountNumber}");
            if(money > this.currentBalance)
                Console.WriteLine("На счете недостаточно средств\n");
            else
            {
                this.currentBalance -= money;
                Console.WriteLine($"С вашего счета было списано: {money} рублей.");
                Console.WriteLine($"Текущий остаток {currentBalance} рублей.\n");
            }
        }
        public void CreditCardInformation()//метод для вывода информации о карточке
        {
            Console.WriteLine($"Номер лицевого счета: {this.accountNumber}") ;
            Console.WriteLine($"Текущий баланс: {this.currentBalance}\n") ;
            
        }
    }
}