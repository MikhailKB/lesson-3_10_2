using NPOI.SS.Formula.Functions;
using System;
using static System.Console;

namespace lesson_3_10_2
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {
            Write("\n Здравствуйте! Введите число карт у вас на руках и нажмите \"Enter\": ");
            int number = int.Parse(ReadLine());
            int sum = 0;
            int i = 0;
            while (i < number)

                for (int a = 0; i < number; i++)
                {
                    WriteLine("\nВведите номинал карты от 1-10, где Валет - J, Дама - Q, Король - K, Туз - T и нажмите \"Enter\": ");
                    string card = ReadLine();
                
                    switch (card)
                    {
                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            sum += 10;
                            break;
                        case "1":
                            sum += 1;
                            break;
                        case "2":
                            sum += 2;
                            break;
                        case "3":
                            sum += 3;
                            break;
                        case "4":
                            sum += 4;
                            break;
                        case "5":
                            sum += 5;
                            break;
                        case "6":
                            sum += 6;
                            break;
                        case "7":
                            sum += 7;
                            break;
                        case "8":
                            sum += 8;
                            break;
                        case "9":
                            sum += 9;
                            break;
                        case "10":
                            sum += 10;
                            break;
                        default:
                            WriteLine("Ввели не карту");
                            break;
                    }
                    WriteLine($"Сумма всех карт: {sum} ");
                    ReadKey();
                    break;
                }
        }
    }
}
                 