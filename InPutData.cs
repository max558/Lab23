using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPutDataSpace
{
    static public class InPutData
    {

        /* 
         * Ввод строки. 
         * str - Строковый параметр запроса
         */
        static public string EnterDataStr(string str)
        {
            string res = "";
            Console.Write(str);
            res = Console.ReadLine();
            return res;
        }

        /* 
         * Ввод целого числа. 
         * str - Строковый параметр запроса, 
         * positive - true только числа больше 0 
         */
        static public int EnterDataInt(string str, bool positive)
        {
            int res = 0;
            Console.Write(str);
            try
            {
                res = Convert.ToInt32(Console.ReadLine());
                if ((positive) && (res < 0))
                {
                    res = EnterDataInt("Число меньше 0 попробуйте ввсти еще раз: ", positive);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                res = EnterDataInt("Попробуйте ввсти еще раз: ",positive);
            }
            return res;
        }

        /* 
         * Ввод числа с дробной частью. 
         * str - Строковый параметр запроса, 
         * positive - true только числа больше 0 
         */
        static public double EnterDataDouble(string str, bool positive)
        {
            double res = 0;
            Console.Write(str);
            try
            {
                res = Convert.ToDouble(Console.ReadLine());
                if ((positive) && (res < 0))
                {
                    res = EnterDataDouble("Число меньше 0 попробуйте ввсти еще раз: ", positive);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                res = EnterDataDouble("Попробуйте ввсти еще раз: ", positive);
            }
            return res;
        }
    }
}
