using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InPutDataSpace;


namespace Lab_23
{
    /*
     * Разработать асинхронный метод для вычисления факториала числа. 
     * В методе Main выполнить проверку работы метода.
     */
    class Program
    {
        static double n;
        static void Factjrial(double x)
        {
            double res = 1;

            for (int i = 1; i <= x; i++)
            {
                res = res * i;
            }
            Console.WriteLine("Факториал числа: {0} != {1}", x, res);
        }
        static void Main(string[] args)
        {
            /*
             * "В методе Main выполнить проверку работы метода" - Не совсем понял о каком методе идет речь.
             * Если проверка вводимых чисел (для факториала), то это сделано в отдельном классе и оnдельном файле при вводе числа. Как следствие в методе Main.
             * Если проверять результат выполнения (переполнения памяти), то асинхронность теряет смысл, да и результат будет бесконечность (проверял на больших числах).
             * Поэтому try-catch закоментировал
             * 
             * Для понятия работы асинхронности ввел вывод об окончании работ методов.
             */

            //Реализовал связь разных файлов, ссылками (чисто ради эксперимента, и дальнейшего развития наработок и их использования)
            n = InPutData.EnterDataInt("Введите число факториала: ", true);
            //try
            //{
                FactjrialAsync();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Ошибка! {0}", ex);
            //}

            Console.WriteLine("Main закончил работу!");
            Console.ReadKey();
        }

        static async Task FactjrialAsync()
        {
            await Task.Run(() => Factjrial(n));
            Console.WriteLine("FactjrialAsync закончил работу!");
        }
    }
}
