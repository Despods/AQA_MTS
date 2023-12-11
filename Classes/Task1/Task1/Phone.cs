using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Phone
    {
        public string number, model;
        public int weight;

        public Phone()//конструктор по-умолчанию, без параметров
        {

        }

        public Phone(string number, string model)//конструктор с 2 переменными
        {
            this.number = number;
            this.model = model;
        }

        public Phone(string number, string model, int weight) : this(number, model)//конструктор с 3 переменными, для заполнения 2-ух из которых вызывается 2 конструктор
        {
            this.weight = weight;
        }

        //метод receiveCall, с одним параметром “имя звонящего”. 
        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит: {name}");
        }

        //Этот метод возвращает номер телефона
        public string getNumber()
        {
            return this.number;
        }

        //Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов 
        public void sendMessage(params string[] numbers)
        {
            Console.WriteLine("Отправлено сообщение следующим номерам: ");
            
            foreach(string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");
        }
        public void Print()
        {
            Console.WriteLine($"Номер телефона: {number}, Модель: {model}, Вес телефона: {weight}");
        }
    }

}
