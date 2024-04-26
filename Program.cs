namespace Home1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задача 1. Прямоугольник и квадрат
            Console.WriteLine("Задача 1.");
            Console.WriteLine("Введите три числа->");
            int a, b, c;

            // получаем от пользователя три введенных числа
            // и сохраняем в объявленных переменных
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            // проверяем больше ли сторона квадрата,
            // одной из сторон прямоугольника
            if((c > b) || (c > a))
            {
                Console.WriteLine("Ни один квадрат не может быть помещен в прямоугольник");
            }
            else
            {
                // переменная содержащая количество квадратов
                // в прямоугольнике
                int numb_squears = (a / c) * (b / c);

                Console.WriteLine("Количество квадратов в прямоугольнике: " + Convert.ToString(numb_squears));
                Console.WriteLine("Площадь не занятая квадратами: " + Convert.ToString(a * b - numb_squears * c * c));
            }

            // задача 2. Количество месяцев после которого вклад 
            // превысит заданную сумму
            Console.WriteLine("\nЗадача 2.");
            Console.WriteLine("Введите месячный процент вклада от 0 до 25 ->");

            // переменная представляющая начальный вклад
            double B = 10000;

            // переменная предстваляющая требуемую сумму вклада
            double E = 11000;

            double P = Convert.ToDouble(Console.ReadLine());

            // количество месяцев
            int K = 0;

            // итоговая сумма вклада через К месяцев
            double S = B;

            // с помощью цикла определяем 
            // количество месяцев и сумму конечного
            // вклада
            while(S < E)
            {
                S += S * (P/100);
                K++;
            }

            Console.WriteLine("Сумма вклада: " + Convert.ToString(S));
            Console.WriteLine("Количество месяцев: " + Convert.ToString(K));


            // задача 3 Вывод диапазона чисел 
            // в соответствии с их значениями
            Console.WriteLine("\nЗадача 3");

            // значения диапазона чисел
            int num1, num2;

            Console.WriteLine("Введите два числа->");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            // если первое число больше второго
            if (num2 < num1)
            {
                int tmp = num2;
                num2 = num1;
                num1 = tmp;
            }

            // выполняем необходимый вывод в цикле
            for(int i = num1; i <= num2; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            // задача 4. вывод введенного числа в 
            // обратном порядке
            Console.WriteLine("\nЗадача4");

            // переменная для пользовательского числа
            int N;

            Console.WriteLine("Введите число (>0) ->");

            N = Convert.ToInt32(Console.ReadLine());

            if (N < 10)
            {
                Console.WriteLine(N);
            }
            else
            {
                
                while (N/10 != 0)
                {
                    Console.Write(N % 10);
                    N /= 10;
                }
                Console.WriteLine(N);
            }


        }
    }
}
