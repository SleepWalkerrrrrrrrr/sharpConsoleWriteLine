using System;
using System.Diagnostics;

public class Dolg
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Типы перегрузок:");
        Console.WriteLine("1. Строка.");
        Console.WriteLine("2. Форматирование.");
        Console.WriteLine("3. Указать символ из массива.");
        Console.WriteLine("4. Строка с массивом объектов.");
        Console.WriteLine("5. Строка с объектом.");
        Console.WriteLine("6. Строки с UInt32 & Uint64.");
        Console.WriteLine("7. Строка с числом с плавающей точкой одиночной точности.");
        Console.WriteLine("8. Строки с одиночными дробными числами.");
        Console.WriteLine("9. Строки с Int и объяснением разницы между 32 и 64.");
        Console.WriteLine("10. Строка с числом двойной точности с плавающей запятой.");
        Console.WriteLine("11. Строка с массивом символов юникода.");
        Console.WriteLine("12. Строка с символами юникода.");
        Console.WriteLine("13. Строка со значением Boolean.");
        Console.WriteLine("0. Закрыть приложение.");
        Console.WriteLine("Введите номер желаемого пунка.");

        string a = Console.ReadLine();

        static void Primitive()
        {
            // Самое простое и банальное использование Console.WriteLine()(Далее - cw);
            Console.WriteLine("hello world!");
            Console.ReadKey();
        }

        static void cwFormat()
        {
            // Форматирование выводимого текста в cw;
            string name;
            int age;
            try
            {
                // Числа в фигурных скобках - порядок встраивания значений в выводимую строку;
                Console.WriteLine("Как Вас зовут?");
                name = Console.ReadLine();
                Console.WriteLine("Сколько Вам лет?");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Ваше имя: {0}. Ваш возраст: {1}.", name, age);
            }

            catch (Exception)
            {
                Console.WriteLine("Ошибка! Попробуйте ещё раз.");
                Console.ReadKey();
                Console.Clear();
                cwFormat();
            }
            try
            {
                // 0 - порядковой номер указанного объекта, C - превращает число в валюту;
                Console.WriteLine("Введите случайное число.");
                UInt64 money = UInt64.Parse(Console.ReadLine());
                Console.WriteLine("Эта программа стоит: {0:C} ", money);
                Console.ReadKey();
                Console.Clear();
                Main();
            }

            catch (Exception)
            {
                Console.WriteLine("Ошибка! Попробуйте ещё раз.");
                Console.ReadKey();
                Console.Clear();
                cwFormat();
            }
        }

        static void cwCharInt32()
        {
            // Указывает символ из массива char[] по заранее указанным параметрам;
            char[] ch = { 'f', 'b' };
            Console.WriteLine("Символ из массива ch под индексом 0:");
            Console.WriteLine(ch, 0, 1);
            Console.ReadKey();
        }

        static void cwObjectMassive()
        {
            // Объявление массива;
            string[] mass;
            // Присваивание массиву 3 строки;
            mass = new string[3];
            // Присваивание строкам значения; 
            mass[0] = "hello";
            mass[1] = "world";
            mass[2] = "!";
            // Вызов всех строк из массива в cw; 
            Console.WriteLine("Сообщение, собранное из массива строк: " + mass[0]+", "+mass[1]+mass[2]);
            Console.ReadKey();
        }

        static void cwObject()
        {
            // Присваивание переменной pi значения числа пи;
            double pi = Math.PI;
            // Вывод строки с переменной пи;
            Console.WriteLine("Число пи: "+pi);
            Console.ReadKey();
        }

        static void cw_uInt()
        {
            Console.WriteLine("максимальное значение UInt32: " + UInt32.MaxValue);
            Console.WriteLine("максимальное значение UInt64: " + UInt64.MaxValue);
            Console.WriteLine("Различие в максимальном значении числа. \nUInt отличается Int тем, что это число без знака \nто бишь, оно может быть только положительным \n(или нулём)");
            Console.ReadKey();
        }

        static void cwSingle()
        {
            // Single - число с плавающей точкой одиночной точности;
            // Одиночная точность 6-9 цифр;
            Single s = .2f;
            Console.WriteLine("Число с плавающей точкой одиночной точности: " + s);
            Console.ReadKey();
        }

        static void cwDecimal()
        {
            // Decimal хранит одиночное дробное число;
            // Точность у Decimal - 28-29 цифр;
            Console.WriteLine("Минимальное значение decimal: " + decimal.MinValue);
            Console.WriteLine("Максимальное значение decimal: " + decimal.MaxValue);
            Console.ReadKey();
        }

        static void cwInt()
        {
            Console.WriteLine("Минимальное значение Int32: " + Int32.MinValue);
            Console.WriteLine("Максимальное значение Int32: " + Int32.MaxValue);
            Console.WriteLine("************************************************");
            Console.WriteLine("Минимальное значение Int64: " + Int64.MinValue);
            Console.WriteLine("Максимальное значение Int64: " + Int64.MaxValue);
            Console.WriteLine("Как говорилось в пункте 7, различие в максимальном значении \nНо в данном случе - Int может принимать и отрицательное значение.");
            Console.ReadKey();
        }

        static void cwDouble()
        {
            // Double - число с двойной точностью с плавающей запятой;
            // Двойная точность - 15-17 цифр;
            double value = 1234567890.123;
            Console.WriteLine("Число двойной точности с плавающей точкой: " + value); ;
            Console.ReadKey();
        }

        static void cwCharMass ()
        {
            // Объявление массива символов и придание ему значений;
            char[] mass = { 'h', 'n', 'y', ' ', '2', '0', '2', '3', '!' };
            // Вывод всех значений массива в строку;
            Console.WriteLine("Сообщение, собранное из массивов символов:");
            Console.WriteLine(mass);
            Console.ReadKey();
        }

        static void cwChar ()
        {
            // Попытка выполнить вложенный код;
            try
            {
                Console.WriteLine("Введите любой символ и нажмите Enter.");
                // Считывается введенный пользователем символ и конвентируется в тип Char, потому что c# ругается :(;
                char a = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                // Выводится строка с указанным пользователем символом;
                Console.WriteLine("Ваш символ: {0}", a);
                Console.ReadKey();
                Main();
        }
            // Отлавливание ошибок;
            catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Ошибка! Скорее всего, Вы ввели больше одного символа.");
            Console.ReadKey();
            Console.Clear();
            cwChar();
        }
    }

        static void cwBoolean ()
        {
            Console.WriteLine("2x2 = 5?");
            // Boolean = Двоичное значение, которое может быть только True или False;
            // Присваивание Boolean переменной значения false;
            Boolean a = false;
            Console.WriteLine(a);
            Console.ReadKey();

        }
        
        switch (a)
        {
            case "1":
                Console.Clear();
                Primitive();
                Console.Clear();
                Main();
                break;
            case "2":
                Console.Clear();
                cwFormat();
                Console.Clear();
                Main();
                break;
            case "3":
                Console.Clear();
                cwCharInt32();
                Console.Clear();
                Main();
                break;
            case "4":
                Console.Clear();
                cwObjectMassive();
                Console.Clear();
                Main();
                break;
            case "5":
                Console.Clear();
                cwObject();
                Console.Clear();
                Main();
                break;
            case "6":
                Console.Clear();
                cw_uInt();
                Console.Clear();
                Main();
                break;
            case "7":
                Console.Clear();
                cwSingle();
                Console.Clear();
                Main();
                break;
            case "8":
                Console.Clear();
                cwDecimal();
                Console.Clear();
                Main();
                break;
            case "9":
                Console.Clear();
                cwInt();
                Console.Clear();
                Main();
                break;
            case "10":
                Console.Clear();
                cwDouble();
                Console.Clear();
                Main();
                break;
            case "11":
                Console.Clear();
                cwCharMass();
                Console.Clear();
                Main();
                break;
            case "12":
                Console.Clear();
                cwChar();
                Console.Clear();
                Main();
                break;
            case "13":
                Console.Clear();
                Console.WriteLine("Несчастливое число :(");
                cwBoolean();
                Console.Clear();
                Main();
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Приложение будет закрыто. Вы уверены? Y - да, N - нет.");
                System.ConsoleKeyInfo b = Console.ReadKey();
                if (b.Key == ConsoleKey.Y)
                {
                    Process.GetCurrentProcess().Kill();
                }
                if (b.Key == ConsoleKey.N)
                {
                    Main();
                }
                else
                {
                    Console.Clear();
                    Main();
                }
                break;
            default:
                Console.Clear();
                Console.WriteLine("Ошибка. Нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
                Main();
                break;
        }
    }
}