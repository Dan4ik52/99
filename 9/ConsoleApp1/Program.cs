using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1: 
                    double a = 0;
                    double b = 2* Math.PI / 3;
                    int M = 15;
                    double H = (b - a) / M;
                    double x;
                    Console.WriteLine("Таблица значений F ");
                    for (int i = 0; i <= M; i++)
                    {
                        x = a + i * H;
                        double F_x = Math.Tan(x / 2);
                        Console.WriteLine($"x={x:F4}  F(x)={F_x:F4}");
                    }
                    break;

                case 2:

                    double epsilon = 1e-3;

                    // Переменные для расчёта
                    double sum = 0.0; // Сумма ряда
                    double term = 1.0; // Первый член ряда
                    int n = 1; // Номер текущего члена ряда
                    int k = 0; // Количество итераций

                    double numerator = 1.0; // Числитель для факториала n!
                    double denominator = 1.0; // Знаменатель для факториала (2n)!

                    // Вычисление суммы ряда
                    do
                    {
                        k++;

                        // Обновляем числитель и знаменатель для текущего члена ряда
                        numerator *= n;
                        denominator *= 2 * n - 1;
                        denominator *= 2 * n;

                        // Вычисление текущего члена ряда
                        term = numerator / denominator;

                        // Добавляем текущий член к сумме
                        sum += term;

                        // Переход к следующему члену ряда
                        n++;
                    } while (Math.Abs(term) > epsilon);

                    // Вывод результата
                    Console.WriteLine($"Количество итераций: {k}\t Сумма ряда: {sum:f6}");
                    break;
            }


            Console.ReadKey();























        }
    }
}
