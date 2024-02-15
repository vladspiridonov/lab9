using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;            
            Console.WriteLine("Это простой калькулятор. Введите два числа, а затем выберите действие");
            Console.Write("Введите первое число:");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите опреацию:\n 1 - сложение;\n 2 - вычитание; \n 3 - умножение; \n 4 - деление.");
                byte operNum = 0;
                operNum = Convert.ToByte(Console.ReadLine());
                if (operNum != 1 && operNum != 2 && operNum != 3 && operNum != 4)
                    Console.WriteLine("нет операции с указанным номером");
                double result = 0;
                switch (operNum)
                {
                    case (1):
                        {
                            result = a + b;
                            Console.Write("ответ: ");
                            Console.WriteLine(result);
                            break;
                        }
                    case (2):
                        {
                            result = a - b;
                            Console.Write("ответ: ");
                            Console.WriteLine(result);
                            break;
                        }
                    case (3):
                        {
                            result = a * b;
                            Console.Write("ответ: ");
                            Console.WriteLine(result);
                            break;

                        }
                    case (4):
                        {                            
                        result = a / b;
                            if (result == double.PositiveInfinity)
                            {
                                Console.WriteLine("Это слишком простой калькулятор для деления на 0");                               
                            }
                            else
                            {
                                Console.Write("ответ: ");
                                Console.WriteLine(result);
                            }
                            break;
                        }
                        
                }
                
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.ReadKey();

        }
    }
}
