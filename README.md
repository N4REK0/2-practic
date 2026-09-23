# Практическая работа №2 
## Выполнил студент группы П25-2.1. Оганджанян Нарек Артёмикович

### Блок 3.1. Арифметические операторы
---
№ 1. Вычислите результат выражения int x = 17 / 5; int y = 17 % 5;. Ответ: x = 3, y = 2.
```csharp
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
            Console.WriteLine("Вычисление результата");

            int x = 17 / 5;
            int y = 17 % 5;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
        }
    }
}
```
---
№ 2. Каково значение res после выполнения int a = 5; int res = ++a * 2;? Ответ: res = 12 (префиксный инкремент увеличивает a до 6, затем умножение)
```csharp
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
            Console.WriteLine("Вычислите значение res");

            int a = 5;
            int res = ++a * 2;

            Console.WriteLine($"res = {res}");
        }
    }
}


```

---
№ 3.Каково значение res после выполнения int a = 5; int res = a++ * 2;? Ответ: res = 10 (постфиксный инкремент использует исходное значение 5, затем a становится 6).
```csharp
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
            Console.WriteLine("Значение res: ");

            int a = 5;
            int res = a++ * 2;

            Console.Write($"res = {res}");
        }
    }
}
```

----
№ 4. Чему равен результат 7 / 2 и 7.0 / 2? Ответ: 3 (целочисленное деление) и 3.5 (деление с плавающей точкой).

```csharp
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
            int c = 7 / 2;
            decimal p = 7.0m / 2;

            console.writeline($"решение целочисленного делеия: {c}");
            console.writeline($"решение целочисленного делеия: {p}");
        }
    }
}
```

---
№ 5. Каков результат выражения -15 % 4 в C#? Ответ: -3 (знак остатка совпадает со знаком делимого).

```csharp
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
            console.writeline("вычислите результат: ");

            int q = -15 % 4;

            console.writeline($"результат: {q}");
        }
    }
}
```

---
№6. Что выведет выражение int x = 10; x = x++ + ++x;?
```csharp
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
            console.writeline("вычислите: ");

            int x = 10;
            x = x++ + ++x;

            console.writeline($"решение {x}");
            
        }
    }
}
```

---
№7. Что произойдет при выполнении int max = int.MaxValue; int res = checked(max + 1);?
```csharp
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
            int max = int.maxvalue;
            int res = checked(max + 1);

            console.writeline($"вывод {res}");
        }
    }
}
```

---
№8. Что произойдет при int max = int.MaxValue; int res = unchecked(max + 1);?

```csharp
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
            int max = int.maxvalue;
            int res = unchecked(max + 1);

            console.writeline($"вывод {res}");
            
        }
    }
}
```

---
№ 9. Чему равен результат деления 1.0 / 0.0 и 0.0 / 0.0?
```csharp
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
            console.writeline("вычислите: ");

            double x = 1.0 / 0.0;
            double y = 0.0 / 0.0;

            console.writeline($"x = {x}");
            console.writeline($"y = {y}");
        }
    }
}
```

---
№ 10. Вычислите: int a = 8; int b = 3; int c = a - b * 2 + a / b;
```csharp
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
            int a = 8;
            int b = 3;
            int c = a - b * 2 + a / b;

            console.writeline($"c = {c}");
            
        }
    }
}
```
Блок 3.2. Операторы сравнения
---
№ 11. Каков результат 5 > 3 и 5 >= 5 ? Ответ : true, true

```csharp
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
            bool x = 5 > 3;
            bool y = 5 >= 5;

            console.writeline($"x = {x}");
            console.writeline($"y = {y}");
        }
    }
}
```

---
№ 12. Чему равно "hello" == "hello" в C# и почему?
```csharp
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
            bool x = "hello" == "hello";

            console.writeline($"{x}");
        }
    }
}
```

---
№ 13. Чему равно выражение double.NaN == double.NaN?
```csharp
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
            bool x = double.nan == double.nan;

            console.writeline($"{x}");
        }
    }
}
```
---
№ 14. Каков результат выражения object a = new int[] { 1 };

```csharp
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
            object a = new int[] { 1 };
            object b = new int[] { 1 };

            bool r = a == b;

            console.writeline($"r = {r}");
        }
    }
}
```

---
№ 15. Чему равно 10 != 10.0?
```csharp
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
                        bool x = 10 != 10.0;

            console.writeline($"x = {x}");
            
        }
    }
}
```

---
№ 16. Что вернет null == null?
```csharp
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
            bool x = null == null;

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 17. Каков результат выражения (3 < 5) == (10 >= 20)?

```csharp
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
            bool x = (3 < 5) == (10 >= 20);

            console.writeline($"x = {x}");
        }
    }
}
```

---
№18. Вычислите bool res = 4 <= 4 && 5 > 2;

```csharp
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
            bool res = 4 <= 4 && 5 > 2;

            console.writeline($"res = {res}");
        }
    }
}
```

---
№ 19. Что вернет выражение char c = 'b'; bool res = c > 'a';? 

```csharp
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
            char c = 'b';
            bool res = c > 'a';

            console.writeline($"res = {res}");
            
        }
    }
}
```

---
№20. Сравните результат bool r = -0.0 == 0.0;

```csharp
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
            bool r = -0.0 > 0.0;

            console.writeline($"r = {r}");
            
        }
    }
}
```

Блок 3.3. Логические операторы
-
№ 21. Чему равен результат 5 & 3 в двоичном и десятичном виде?

```csharp
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
            bool x = !true || false && true;

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 22. Будет ли вызван метод Foo() в false && Foo()?

```csharp
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
            
            bool x = false && foo();

            console.writeline($"x = {x}");
            
        }
    }
}
```
---
№ 23. Будет ли вызван метод Foo() в false & Foo()? 

```csharp
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
           int x = false & foo();

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 24. Вычислите результат: true ^ false ^ true.

```csharp
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
            bool x = true ^ false ^ true;

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 25. Что вернет выражение !(5 > 2 || 3 < 1) ?

```csharp
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
            bool x = !(5 > 2 || 3 < 1);

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 26. Дано: bool a = true, b = false;. Чему равно a && !b || b && !a ?

```csharp
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
            bool a = true, b = false;
            bool c = a && !b || b && !a;

            console.writeline($"c = {c}");
        }
    }
}
```

---
№ 27. 
```csharp
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
            int x = 10;

            bool result = true || (x / 0 == 1);

            console.writeline($"res = {result}");
        }
    }
}
```

---
№ 28. 
```csharp
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
           bool x = false & (10 / 0 == 1);

            console.writeline($"x = {x}");
            
        }
    }
}
```

---
№ 29. 
```csharp
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
            bool a = true, b = false;
            bool morgan = !(a && b);
            bool morganequivalent = !a || !b;

            console.writeline($"{morgan}, {morganequivalent}");
            
        }
    }
}
```

---
№ 30. 
```csharp
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
            bool a = true, b = false;
            bool morgan = !(a || b);
            bool morganequivalent = !a && !b;

            console.writeline($"{morgan}, {morganequivalent}");
            
        }
    }
}
```

Блок 3.4
---

№ 31. 
```csharp
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
            int res = 5 & 3;

            console.writeline($"result = {res}");
            
        }
    }
}
```

---
№ 32. 
```csharp
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
            int res = 5 | 3;

            console.writeline($"result = {res}");
            
        }
    }
}
```
---
№ 33. 
```csharp
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
            int res = 5 ^ 3;

            console.writeline($"result = {res}");
        }
    }
}
```
---
№ 34. 
```csharp
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
            int res = ~0;

            console.writeline($"result = {res}");
            
        }
    }
}
```
---
№ 35. 
```csharp
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
            int res = 1 << 4;

            console.writeline($"result = {res}");
            
        }
    }
}
```
---
№ 36. 
```csharp
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
             int res = 40 >> 2;

             console.writeline($"{res}");
            
        }
    }
}
```
---
№ 37. 
```csharp
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
            int n = 10;
            bool x = (n & 8) != 0;
            bool y = (n & (1 << 3)) != 0;
            if (x)
            {
                console.writeline("3-й бит установлен");
            }
            else
            {
                console.writeline("3-й бит не установлен");
            }
            
        }
    }
}
```
---
№ 38. 
```csharp
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
            int n = 8;
            n |= (1 << 2);
            console.writeline($"n = {n}");
        }
    }
}
```
---
№ 39. 
```csharp
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
            int n = 20;
            n &= ~(1 << n);
            console.writeline($"n = {n}");
            
        }
    }
}
```
---
№ 40. 
```csharp
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
            int x = (-16) >> 2;
            console.writeline($"x = {x}");
        }
    }
}
```
Блок 3.5. Операторы присваивания
---
№ 41. 

```csharp
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
            int x = 10;
            x += 5; // += прибавляет к текущему значению в переменной 5 и сохраняет в ней обновленное значение

            console.writeline($"x = {x}");
        }
    }
}
```

---
№   42. 
```csharp
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
            int a = 10;
            a *= 2 + 3; // то же самое действие что и в предыдущей задаче только с умножением

            console.writeline($"a = {a}");
        }
    }
}
```

---
№ 43. 
```csharp
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
            int x = 12;
            x >>= 2; // сдвиг битов вправо тоесть если число 12 было 1100 бит мы сдвинули направо и в итоге получили 0011 что значит 3

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 44. 
```csharp
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
            int? x = null;
            int y = 5;
            x = x ?? y;

            console.writeline($"x = {x}");
        }
    }
}
```
---
№ 45. 
```csharp
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
            string str = null;
            str = str ?? "default";
            str = str ?? "custom"; // получается, если стоит ?? это означает взять информацию справа если слево пусто 

            console.writeline($"str = {str}");
        }
    }
}
```
---
№ 46. 
```csharp
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
            byte b = 1;
            b += 2;

            console.writeline($"b = {b}");
        }
    }
}
```
---
№ 47. 
```csharp
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
            int a = 5, b = 10, c = 0;
            c = a = b; // просто присваиваются значение из переменной b (10) в переменную a и c

            console.writeline($"c = {c}");
            console.writeline($"a = {a}");
        }
    }
}
```
---
№ 48. 
```csharp
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
            int mask = 1;
            mask <<= 3; // сдвиг битов влево на 3
            mask |= 2; // |= это побитовое или если у нас чило 8 это 1000 бит и 2 это 0010 то получается 1010 что означает 10

            console.writeline($"mask = {mask}");
        }
    }
}
```
---
№ 49. 
```csharp
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
            int x = 15;
            x %= 4; // %=  означает деление числа и записать целый остаток обратно в переменную 

            console.writeline($"x = {x}");
        }
    }
}
```
---
№ 50. 
```csharp
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
            int x = 7;
            x ^= 7;

            console.writeline($"x = {x}");
        }
    }
}
```
Блок 3.6
---
№ 51. 

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 75;
            string res = score >= 60 ? "pass" : "fail";

            console.writeline($"res = {res}");
        }
    }
}
```
№ 52. 

---

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = (x > 10) ? 100 : (x > 2) ? 50 : 0;

            console.writeline($"y = {y}");
        }
    }
}
```
№ 53. 

---

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = true ? 10 : 15.5;

            console.writeline($"result = {result}");
        }
    }
}
```
---
№ 54. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            console.writeline(s?.length);
        }
    }
}
```
---
№ 55. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "вотсап";
            int? lenght = s?.length;

            console.writeline($"lenght = {lenght}");
        }
    }
}
```

---
№ 56. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string res = name ?? "anonymous";

            console.writeline($"res = {res}");
        }
    }
}
```

---
№ 57. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = null, b = "user", c = "admin";
            string res = a ?? b ?? c;

            console.writeline($"res = {res}");
        }
    }
}
```

---
№ 58. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            int result = false ? (10 / zero) : 42;

            console.writeline($"result = {result}");
        }
    }
}
```

---
№ 59. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            var x = condition ? 10 : "text";

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 60. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6.Тернарный_и_null_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? count = null;
            int res = count?.gethashcode() ?? -1;

            console.writeline($"res = {res}");
        }
    }
}
```
---

## 3.7. Операторы типов и приведения
---
№ 61. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "hello";
            bool check = obj is string;

            console.writeline($"check = {check}");
        }
    }
}
```
---
№ 62. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 123;
            string s = obj as string;

            console.writeline(s ?? "null");
        }
    }
}
```
---
№ 63. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 123;
            string s = (string)obj;

            console.writeline($"s = {s}");
        }
    }
}
```
---
№ 64. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool res = typeof(int) == typeof(int32);

            console.writeline($"res = {res}");
        }
    }
}
```
---
№ 65. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = sizeof(long);

            console.writeline($"res = {res}");
        }
    }
}
```
---
№ 66. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = null;
            bool res = obj is string;

            console.writeline($"res = {res}");
        }
    }
}
```
---
№ 67. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = null;
            bool b = x is null;

            console.writeline($"b = {b}");
        }
    }
}
```
---
№ 68. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = (int)3.99;

            console.writeline($"res = {res}");
        }
    }
}
```
---
№ 69. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = 42;
            if (o is int val && val > 40)
            {
            console.writeline($"val = {val}");
        }
    }
}
```
---
№ 70. 
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Операторы_типов_и_приведения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            console.writeline($"{default(int)}, {default(string) ?? "null"}");
        }
    }
}
```

##4. 35 сложносоставных заданий на логические выражения
---
№ 71. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (5 > 3) && !(10 <= 2) || (4 == 5);
            console.writeline($"задача 1: {x}");
        }
    }
}
```
---
№72. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = !(true && false) ^ (true || false && false);
            console.writeline($"задача 2: {x}");
        }
    }
}
```
---
№73. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (10 & 6) == 2 && (10 | 6) == 14;
            console.writeline($"задача 3: {x}");
        }
    }
}
```
---
№ 74. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (15 >> 1 == 7) && (7 << 2 == 28);
            console.writeline($"задача 4: {x}");
        }
    }
}
```
---
№ 75. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (8 > 5) && (3 + 2 * 4 == 11) && !(false || !true);
            console.writeline($"задача 5: {x}");
        }
    }
}
```
---
№ 76. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (true || false) && (false || true) ^ (true && !false);
            console.writeline($"задача 6: {x}");
        }
    }
}
```
---
№ 77. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (100 / 10 == 10) && (100 % 30 == 10) && !(5 - 5 != 0);
            console.writeline($"задача 7: {x}");
        }
    }
}
```
---
№ 78. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (4 ^ 4) == 0 && (4 ^ 0) == 4 && (0 ^ 0) == 0;
            console.writeline($"задача 8: {x}");
        }
    }
}
```
---
№ 79. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            bool x = !(5 != 5) && ((3 >= 3) || (10 / zero == 1));
            console.writeline($"задача 9: {x}");
        }
    }
}
```
---
№ 80. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            bool x = !((false && (10 / zero == 1)) || (true && (20 > 15)));
            console.writeline($"задача 10: {x}");
        }
    }
}
```
---
№ 81. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (12 & 10) > 5 || (12 | 10) < 15 && !(3 == 3);
            console.writeline($"задача 11: {x}");
        }
    }
}
```
---
№ 82. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((20 >> 2) == 5) ^ ((5 << 1) == 11);
            console.writeline($"задача 12: {x}");
        }
    }
}
```
---
№ 83. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = !((true || false) && (true && !false));
            console.writeline($"задача 13: {x}");
        }
    }
}
```
---
№ 84. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (7 > 2 ? 10 : 20) == 10 && (3 < 1 ? 5 : 15) == 15;
            console.writeline($"задача 14: {x}");
        }
    }
}
```
---
№ 85. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (5 & 1) == 1 && (6 & 1) == 0 && (7 & 1) == 1;
            console.writeline($"задача 15: {x}");
        }
    }
}
```
---
№ 86. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((10 > 5 ? true : false) ^ (3 > 8 ? true : false)) && false;
            console.writeline($"задача 16: {x}");
        }
    }
}
```
---
№ 87. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = !((5 > 2 && 10 > 20)) || (3 == 3 && 4 <= 4);
            console.writeline($"задача 17: {x}");
        }
    }
}
```
---
№ 88. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((1 << 3) == 8) && ((16 >> 4) == 1) && ((2 << 2) == 8);
            console.writeline($"задача 18: {x}");
        }
    }
}
```
---
№ 89. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((10 & 7) == 2) || ((10 | 7) == 15) ^ !(4 > 1);
            console.writeline($"задача 19: {x}");
        }
    }
}
```
---
№ 90. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = false || true && false || true && !false;
            console.writeline($"задача 20: {x}");
        }
    }
}
```
---
№ 91. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (25 % 4 == 1) && (17 / 3 == 5) && (17 % 3 == 2);
            console.writeline($"задача 21: {x}");
        }
    }
}
```
---
№ 92. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((5 ^ 3 ^ 3) == 5) && ((10 ^ 0) == 10);
            console.writeline($"задача 22: {x}");
        }
    }
}
```
---
№ 93. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (true ? (false ? 1 : 2) : (true ? 3 : 4)) == 2;
            console.writeline($"задача 23: {x}");
        }
    }
}
```
---
№ 94. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = !((true && !(false || !false)));
            console.writeline($"задача 24: {x}");
        }
    }
}
```
---
№ 95. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (~0 == -1) && (~(-1) == 0);
            console.writeline($"задача 25: {x}");
        }
    }
}
```
---
№ 96. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((8 & 4) == 0) || ((8 | 4) == 12) && ((8 ^ 4) == 12);
            console.writeline($"задача 26: {x}");
        }
    }
}
```
---
№ 97. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = !(10 >= 10) || (5 < 3) && (2 == 2) || !(false);
            console.writeline($"задача 27: {x}");
        }
    }
}
```
---
№ 98. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (15 & ~1) == 14 && (14 | 1) == 15;
            console.writeline($"задача 28: {x}");
        }
    }
}
```
---
№ 99. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((true || false) ? (false && true ? 10 : 20) : 30) == 20;
            console.writeline($"задача 29: {x}");
        }
    }
}
```
---
№ 100. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((10 > 2) && (5 < 9)) ^ (!(4 >= 5) && (6 != 7));
            console.writeline($"задача 30: {x}");
        }
    }
}
```
---
№ 101. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (7 & 3) == 1 || (7 | 3) == 7;
            console.writeline($"задача 31: {x}");
        }
    }
}
```
---
№ 102. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((10 > 5 && 3 < 1) || ((8 == 8 || (5 > 10)) && (4 + 4 == 8)));
            console.writeline($"задача 32: {x}");
        }
    }
}
```
---
№ 103. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = (!((true && false)) || !((true || false)) && !false);
            console.writeline($"задача 33: {x}");
        }
    }
}
```
---
№ 104. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((32 >> 3 == 4) && (4 << 3 == 32)) ^ ((15 & 7) == 7 && (15 | 7) == 15);
            console.writeline($"задача 34: {x}");
        }
    }
}
```
---
№ 105. 
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35_сложносоставных_заданий_на_логические_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = ((5 > 3 ? (2 > 1 ? true : false) : false) && !((10 > 20) || (30 < 15)));
            console.writeline($"задача 35: {x}");
        }
    }
}
```
---
