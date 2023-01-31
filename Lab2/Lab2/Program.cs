using System; // Включает в себя такие стандартные классы, как: Console(Методы: Console.Write, Console.WriteLine) и тд
using MyLib;

namespace Lab2
{
    class Program
    {
        static int Fact(int x) // Задаём метод расчёта факториала
        {
            int answer;
            answer = 1; // Факториал начинает высчитываться с 1, поэтому задаём result = 1 
            for (int i = 1; i <= x; i++)
                answer *= i;

            return answer;
        }
        
        static void Main(string[] args)
        {
            Lib.Write();

            Console.Write("Введите число: ");
            
            int n = Convert.ToUInt16(Console.ReadLine());

            if(n == 0) // Задаём условие, если введена цифра 0, то программа не будет показывать, как происходил расчёт факториала
            {
                Console.WriteLine("Факториал числа {0} = {1}", n, Fact(n));
            }
            else
            {
                Console.Write("Факториал числа {0} = ", n);

                for (int i = 1; i < n; i++)
                    Console.Write("{0} * ", i); // Используем цикл для отображения подсчёт факториала

                Console.WriteLine("{0} = {1}", n, Fact(n)); // Закрываем подсчёт и выводим ответ
            }
            Lib.ExitWord("\nДля завершения работы улыбнитесь и нажмите любую кнопку...");
            Lib.Pause();
        }
    }
}
