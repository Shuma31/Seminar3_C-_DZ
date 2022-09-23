using System;
namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            void Zadacha1()
            {
                Console.WriteLine("Введите пятизначное число");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 9999 | Number > 99999)
                Console.WriteLine("Нужно ввести пятизначное число!");
                else
                {
                    int numberOne = Number / 1000 % 100;
                    int numberTwo = Number % 100;
                    if (numberOne % 10 == numberTwo / 10 && numberTwo % 10 == numberOne / 10)
                    {
                        Console.WriteLine("Число " + Number + " является полиндромом");
                    } 
                    else 
                    {
                        Console.WriteLine("Число " + Number + " не является полиндромом");
                    }
                    Console.WriteLine(numberOne);
                    Console.WriteLine(numberTwo);
                }
            }

            void Zadacha2()
            {
               Random random_point = new Random();
               int Ax = random_point.Next(-10, 11);
               int Ay = random_point.Next(-10, 11);
               int Az = random_point.Next(-10, 11);
               int Bx = random_point.Next(-10, 11);
               int By = random_point.Next(-10, 11);
               int Bz = random_point.Next(-10, 11);
               Console.WriteLine($"Точки: A ({Ax}, {Ay}, {Az}), B ({Bx}, {By}, {Bz})");

               double degree = Math.Pow(Bx - Ax, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2);
               double result = Math.Sqrt(degree);
               Console.WriteLine("Расстояние между точками = " + result);
            }

            void Zadacha3()
            {
              Console.WriteLine("Введите число");
              int Number = Convert.ToInt32(Console.ReadLine());
              int count = 1;
              while (count <= Number)
              {
                double cube = Math.Pow(count, 3);
                Console.WriteLine($"{count} * {count} * {count} = {cube}");
                count++;
              }
            } 

            //adacha1();
            //Zadacha2();
            //Zadacha3();

            
        }
    }
}