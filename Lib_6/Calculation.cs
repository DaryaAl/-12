using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lib_6
{
    public class Calculation
    {
        //Параметры:
        //Входные:
        //num1, num2 - переменные(два числа)
        //Функция для рассчета среднего геометрического двух чисел
        public static double GeometricMean(double num1, double num2)
        {
            double a = num1 * num2;
            double rez = Math.Sqrt(a);
            return rez;
        }

        //Параметры:
        //Входные:
        //х - переменная
        //Функция для перестановки сотен и десятков трехзначного числа
        public static int Change(int x)
        {
            int p;
            p = (x / 100) * 10 + ((x % 100) / 10) * 100 + (x % 10);
            return p;
        }
    }
}
