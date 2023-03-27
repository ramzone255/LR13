using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = @"Input.txt";
            double x = 0, y = 0; //Фактические значения
            try
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                InputData(path, x, y);
                ReadData(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");

            }
        }
        static void InputData(string p, double M, double R) //Формальные значения
        {


            StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
            sw.WriteLine(M);
            sw.WriteLine(R);
            sw.Close();
        }
        //Перегрузка метода записи
        static void InputData(string p, double m) //Формальные значения
        {


            StreamWriter sw = new StreamWriter(p, false, Encoding.Default);
            sw.WriteLine(m);
            sw.Close();
        }
        //метод чтения из файла
        static void ReadData(string p)
        {
            StreamReader sr = new StreamReader(p, Encoding.Default);
            double M = double.Parse(sr.ReadLine());
            double R = double.Parse(sr.ReadLine());
            double V = 1.58*Math.Pow(10,-3);
            double T = 340;
            double P = 8 * Math.Pow(10, 4);
            double m = Solve(M,R,V,T,P);
            Console.WriteLine($"Результат m = {m}");
            InputData(@"Rezult.txt", m, 0);
            Console.ReadKey();
        }
        static double Solve(double M, double R, double V, double T, double P)
        {
            return (P*V*M)/(R*T);
        }
    }
}
