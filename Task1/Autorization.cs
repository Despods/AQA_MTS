using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal class Autorithation
    {
        public void AutorithationRun()
        {
            try
            {
                Console.Write("Введите логин: ");
                string? login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string? password = Console.ReadLine();

                Console.Write("Введите повторно пароль: ");
                string? passwordConfirm = Console.ReadLine();

                if (CorrectAutorithation(login, password, passwordConfirm))
                    Console.WriteLine("Логин прошел успешно");
            }
            catch (WrongLoginException exLogin)
            {
                Console.WriteLine($"Ошибка ввода логина: {exLogin.Message}");
            }
            catch (WrongPasswordException exPassword)
            {
                Console.WriteLine($"Ошибка ввода пароля: {exPassword.Message}");
            }
        }
    

        private static bool CorrectAutorithation(string? login, string? password, string? passwordConfirm)
        {
            bool flag = true;
            if (String.IsNullOrWhiteSpace(login))
            {
                flag = false;
                throw new WrongLoginException("В логине пустая строка");
            }
            if (login.Length >= 20)
            {
                flag = false;
                throw new WrongLoginException("Логин должен содержать менее 20 символов");
            }
            if (login.IndexOf(' ') > -1)
            {
                flag = false;
                throw new WrongLoginException("Логин содержит пробелы");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                flag = false;
                throw new WrongPasswordException("В логине пустая строка");
            }
            if (password != passwordConfirm)
            {
                flag = false;
                throw new WrongPasswordException("Пароли не совпадают");
            }
            if (password.Length >= 20)
            {
                flag = false;
                throw new WrongPasswordException("Пароль должен содержать менее 20 символов");
            }
            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                flag = false;
                throw new WrongPasswordException("Пароль должен содержать цифру");
            }
            if (password.IndexOf(' ') > -1)
            {
                flag = false;
                throw new WrongPasswordException("Пароль содержит пробелы");
            }
            return flag;
        }
    }
}
