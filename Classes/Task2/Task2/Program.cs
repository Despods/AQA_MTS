/*
Создать класс CreditCard c полями 
    номер счета, 
    текущая сумма на счету.
Добавьте методы: 
    который позволяет зачислять сумму на кредитную карту;
    который позволяет снимать некоторую сумму с карты;
    который выводит текущую информацию о карточке.
Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма.

Тестовый сценарий для проверки:
    Положите деньги на первые две карточки и снимите с третьей.
    Выведите на экран текущее состояние всех трех карточек.
*/
namespace Task2
{
    class Program
    {
        static void Main()
        {
            //создали экзепляры классов
            CreditCard visa = new CreditCard("1234",100);
            CreditCard mir = new CreditCard("4321", 10);
            CreditCard mastercard = new CreditCard("1223", 1000);

            //произведем манипуляции с балансами карт
            visa.AddMoney(150);
            mir.AddMoney(50);
            mastercard.DelMoney(100);

            //вызываем информацию о картах
            visa.CreditCardInformation();
            mir.CreditCardInformation();
            mastercard.CreditCardInformation();
        }

    }
}
