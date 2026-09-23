using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "3.1"
            //Console.WriteLine("Вычисление результата");

            //int x = 17 / 5;
            //int y = 17 % 5;

            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");



            //Console.WriteLine("Вычислите значение res");

            //int a = 5;
            //int res = ++a * 2;

            //Console.WriteLine($"res = {res}");



            //Console.WriteLine("Значение res: ");

            //int a = 5;
            //int res = a++ * 2;

            //Console.Write($"res = {res}");



            //int C = 7 / 2;
            //decimal P = 7.0m / 2;

            //Console.WriteLine($"Решение целочисленного делеия: {C}");
            //Console.WriteLine($"Решение целочисленного делеия: {P}");


            //Console.WriteLine("Вычислите результат: ");

            //int q = -15 % 4;

            //Console.WriteLine($"Результат: {q}");



            //Console.WriteLine("Вычислите: ");

            //int x = 10;
            //x = x++ + ++x;

            //Console.WriteLine($"Решение {x}");



            //int max = int.MaxValue;
            //int res = checked(max + 1);



            //int max = int.MaxValue;
            //int res = unchecked(max + 1);

            //Console.WriteLine($"Вывод {res}");



            //Console.WriteLine("Вычислите: ");

            //double x = 1.0 / 0.0;
            //double y = 0.0 / 0.0;

            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");



            //int a = 8;
            //int b = 3;
            //int c = a - b * 2 + a / b;

            //Console.WriteLine($"C = {c}");

            #endregion

            #region "3.2"

            //bool x = 5 > 3;
            //bool y = 5 >= 5;

            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");



            //bool x = "hello" == "hello";

            //Console.WriteLine($"{x}");



            //bool x = double.NaN == double.NaN;

            //Console.WriteLine($"{x}");




            //object a = new int[] { 1 };
            //object b = new int[] { 1 };

            //bool r = a == b;

            //Console.WriteLine($"r = {r}");



            //bool x = 10 != 10.0;

            //Console.WriteLine($"x = {x}");



            //bool x = null == null;

            //Console.WriteLine($"x = {x}");



            //bool x = (3 < 5) == (10 >= 20);

            //Console.WriteLine($"x = {x}");



            //bool res = 4 <= 4 && 5 > 2;

            //Console.WriteLine($"res = {res}");



            //char c = 'b';
            //bool res = c > 'a';

            //Console.WriteLine($"res = {res}");



            //bool r = -0.0 > 0.0;

            //Console.WriteLine($"r = {r}");

            #endregion

            #region "3.3"

            //bool x = !true || false && true;

            //Console.WriteLine($"x = {x}");



            //bool x = false && Foo();

            //Console.WriteLine($"x = {x}");



            //int x = false & Foo();

            //Console.WriteLine($"x = {x}");



            //bool x = true ^ false ^ true;

            //Console.WriteLine($"x = {x}");



            //bool x = !(5 > 2 || 3 < 1);

            //Console.WriteLine($"x = {x}");



            //bool a = true, b = false;
            //bool c = a && !b || b && !a;

            //Console.WriteLine($"c = {c}");



            //int x = 10;

            //bool result = true || (x / 0 == 1);

            //Console.WriteLine($"res = {result}");



            //bool x = false & (10 / 0 == 1);

            //Console.WriteLine($"x = {x}");



            //bool A = true, B = false;
            //bool Morgan = !(A && B);
            //bool MorganEquivalent = !A || !B;

            //Console.WriteLine($"{Morgan}, {MorganEquivalent}");


            //bool A = true, B = false;
            //bool Morgan = !(A || B);
            //bool MorganEquivalent = !A && !B;

            //Console.WriteLine($"{Morgan}, {MorganEquivalent}");

            #endregion

            #region "3.4"

            //int res = 5 & 3;

            //Console.WriteLine($"result = {res}");



            //int res = 5 | 3;

            //Console.WriteLine($"result = {res}");



            //int res = 5 ^ 3;

            //Console.WriteLine($"result = {res}");



            //int res = ~0;

            //Console.WriteLine($"result = {res}");



            //int res = 1 << 4;

            //Console.WriteLine($"result = {res}");



            //int res = 40 >> 2;

            //Console.WriteLine($"{res}");



            //int n = 10;
            //bool x = (n & 8) != 0;
            //bool y = (n & (1 << 3)) != 0;
            //if (x)
            //{
            //    Console.WriteLine("3-й бит установлен");
            //}
            //else
            //{
            //    Console.WriteLine("3-й бит не установлен");
            //}



            //int n = 8;
            //n |= (1 << 2);
            //Console.WriteLine($"n = {n}");



            //int n = 20;
            //n &= ~(1 << n);
            //Console.WriteLine($"n = {n}");



            //int x = (-16) >> 2;
            //Console.WriteLine($"x = {x}");

            #endregion

            #region "3.5"

            //int x = 10; 
            //x += 5; // += Прибавляет к текущему значению в переменной 5 и сохраняет в ней обновленное значение

            //Console.WriteLine($"x = {x}");



            //int a = 10;
            //a *= 2 + 3; // то же самое действие что и в предыдущей задаче только с умножением

            //Console.WriteLine($"a = {a}");



            //int x = 12;
            //x >>= 2; // сдвиг битов вправо тоесть если число 12 было 1100 бит мы сдвинули направо и в итоге получили 0011 что значит 3

            //Console.WriteLine($"x = {x}");



            //int? x = null;
            //int y = 5;
            //x = x ?? y;

            //Console.WriteLine($"x = {x}");



            //string str = null;
            //str = str ?? "default";
            //str = str ?? "custom"; // получается, если стоит ?? это означает взять информацию справа если слево пусто 

            //Console.WriteLine($"str = {str}");



            //byte b = 1;
            //b += 2; 

            //Console.WriteLine($"b = {b}");



            //int a = 5, b = 10, c = 0;
            //c = a = b; // просто присваиваются значение из переменной b (10) в переменную a и c

            //Console.WriteLine($"c = {c}");
            //Console.WriteLine($"a = {a}");



            //int mask = 1;
            //mask <<= 3; // сдвиг битов влево на 3
            //mask |= 2; // |= это побитовое или если у нас чило 8 это 1000 бит и 2 это 0010 то получается 1010 что означает 10

            //Console.WriteLine($"mask = {mask}");



            //int x = 15;
            //x %= 4; // %=  означает деление числа и записать целый остаток обратно в переменную 

            //Console.WriteLine($"x = {x}");



            //int x = 7;
            //x ^= 7;

            //Console.WriteLine($"x = {x}");

            #endregion

            #region "3.6"

            //int score = 75;
            //string res = score >= 60 ? "Pass" : "Fail";

            //Console.WriteLine($"res = {res}");



            //int x = 5;
            //int y = (x > 10) ? 100 : (x > 2) ? 50 : 0;

            //Console.WriteLine($"y = {y}");



            //double result = true ? 10 : 15.5;

            //Console.WriteLine($"result = {result}");



            //string s = null; 

            //Console.WriteLine(s?.Length);



            //string s = "Вотсап";
            //int? lenght = s?.Length;

            //Console.WriteLine($"lenght = {lenght}");



            //string name = null;
            //string res = name ?? "Anonymous";

            //Console.WriteLine($"res = {res}");



            //string a = null, b = "User", c = "Admin";
            //string res = a ?? b ?? c;

            //Console.WriteLine($"res = {res}");



            //int zero = 0;
            //int result = false ? (10 / zero) : 42;

            //Console.WriteLine($"result = {result}");



            //bool condition = true;
            //var x = condition ? 10 : "text";

            //Console.WriteLine($"x = {x}");



            //int? count = null;
            //int res = count?.GetHashCode() ?? -1;

            //Console.WriteLine($"res = {res}");

            #endregion

            #region "3.7"

            //object obj = "Hello";
            //bool check = obj is string;

            //Console.WriteLine($"check = {check}");



            //object obj = 123;
            //string s = obj as string;

            //Console.WriteLine(s ?? "null");



            //object obj = 123;
            //string s = (string)obj;

            //Console.WriteLine($"s = {s}");



            //bool res = typeof(int) == typeof(Int32);

            //Console.WriteLine($"res = {res}");



            //int res = sizeof(long);

            //Console.WriteLine($"res = {res}");



            //object obj = null;
            //bool res = obj is string;

            //Console.WriteLine($"res = {res}");



            //object x = null;
            //bool b = x is null;

            //Console.WriteLine($"b = {b}");



            //int res = (int)3.99;

            //Console.WriteLine($"res = {res}");



            //object o = 42;
            //if (o is int val && val > 40)
            //{
            //    Console.WriteLine($"val = {val}");
            //}



            //Console.WriteLine($"{default(int)}, {default(string) ?? "null"}");

            #endregion

            #region "4.0"

            //bool x = (5 > 3) && !(10 <= 2) || (4 == 5);
            //Console.WriteLine($"Задача 1: {x}");



            //bool x = !(true && false) ^ (true || false && false);
            //Console.WriteLine($"Задача 2: {x}");



            //bool x = (10 & 6) == 2 && (10 | 6) == 14;
            //Console.WriteLine($"Задача 3: {x}");



            //bool x = (15 >> 1 == 7) && (7 << 2 == 28);
            //Console.WriteLine($"Задача 4: {x}");



            //bool x = (8 > 5) && (3 + 2 * 4 == 11) && !(false || !true);
            //Console.WriteLine($"Задача 5: {x}");



            //bool x = (true || false) && (false || true) ^ (true && !false);
            //Console.WriteLine($"Задача 6: {x}");



            //bool x = (100 / 10 == 10) && (100 % 30 == 10) && !(5 - 5 != 0);
            //Console.WriteLine($"Задача 7: {x}");



            //bool x = (4 ^ 4) == 0 && (4 ^ 0) == 4 && (0 ^ 0) == 0;
            //Console.WriteLine($"Задача 8: {x}");



            //int zero = 0;
            //bool x = !(5 != 5) && ((3 >= 3) || (10 / zero == 1));
            //Console.WriteLine($"Задача 9: {x}");



            //int zero = 0;
            //bool x = !((false && (10 / zero == 1)) || (true && (20 > 15)));
            //Console.WriteLine($"Задача 10: {x}");



            //bool x = (12 & 10) > 5 || (12 | 10) < 15 && !(3 == 3);
            //Console.WriteLine($"Задача 11: {x}");



            //bool x = ((20 >> 2) == 5) ^ ((5 << 1) == 11);
            //Console.WriteLine($"Задача 12: {x}");



            //bool x = !((true || false) && (true && !false));
            //Console.WriteLine($"Задача 13: {x}");



            //bool x = (7 > 2 ? 10 : 20) == 10 && (3 < 1 ? 5 : 15) == 15;
            //Console.WriteLine($"Задача 14: {x}");



            //bool x = (5 & 1) == 1 && (6 & 1) == 0 && (7 & 1) == 1;
            //Console.WriteLine($"Задача 15: {x}");



            //bool x = ((10 > 5 ? true : false) ^ (3 > 8 ? true : false)) && false;
            //Console.WriteLine($"Задача 16: {x}");



            //bool x = !((5 > 2 && 10 > 20)) || (3 == 3 && 4 <= 4);
            //Console.WriteLine($"Задача 17: {x}");



            //bool x = ((1 << 3) == 8) && ((16 >> 4) == 1) && ((2 << 2) == 8);
            //Console.WriteLine($"Задача 18: {x}");



            //bool x = ((10 & 7) == 2) || ((10 | 7) == 15) ^ !(4 > 1);
            //Console.WriteLine($"Задача 19: {x}");



            //bool x = false || true && false || true && !false;
            //Console.WriteLine($"Задача 20: {x}");



            //bool x = (25 % 4 == 1) && (17 / 3 == 5) && (17 % 3 == 2);
            //Console.WriteLine($"Задача 21: {x}");



            //bool x = ((5 ^ 3 ^ 3) == 5) && ((10 ^ 0) == 10);
            //Console.WriteLine($"Задача 22: {x}");



            //bool x = (true ? (false ? 1 : 2) : (true ? 3 : 4)) == 2;
            //Console.WriteLine($"Задача 23: {x}");



            //bool x = !((true && !(false || !false)));
            //Console.WriteLine($"Задача 24: {x}");



            //bool x = (~0 == -1) && (~(-1) == 0);
            //Console.WriteLine($"Задача 25: {x}");



            //bool x = ((8 & 4) == 0) || ((8 | 4) == 12) && ((8 ^ 4) == 12);
            //Console.WriteLine($"Задача 26: {x}");



            //bool x = !(10 >= 10) || (5 < 3) && (2 == 2) || !(false);
            //Console.WriteLine($"Задача 27: {x}");



            //bool x = (15 & ~1) == 14 && (14 | 1) == 15;
            //Console.WriteLine($"Задача 28: {x}");



            //bool x = ((true || false) ? (false && true ? 10 : 20) : 30) == 20;
            //Console.WriteLine($"Задача 29: {x}");



            //bool x = ((10 > 2) && (5 < 9)) ^ (!(4 >= 5) && (6 != 7));
            //Console.WriteLine($"Задача 30: {x}");




            //bool x = (7 & 3) == 1 || (7 | 3) == 7;
            //Console.WriteLine($"Задача 31: {x}");



            //bool x = ((10 > 5 && 3 < 1) || ((8 == 8 || (5 > 10)) && (4 + 4 == 8)));
            //Console.WriteLine($"Задача 32: {x}");



            //bool x = (!((true && false)) || !((true || false)) && !false);
            //Console.WriteLine($"Задача 33: {x}");



            //bool x = ((32 >> 3 == 4) && (4 << 3 == 32)) ^ ((15 & 7) == 7 && (15 | 7) == 15);
            //Console.WriteLine($"Задача 34: {x}");



            //bool x = ((5 > 3 ? (2 > 1 ? true : false) : false) && !((10 > 20) || (30 < 15)));
            //Console.WriteLine($"Задача 35: {x}");

            #endregion

        }
    }
}
