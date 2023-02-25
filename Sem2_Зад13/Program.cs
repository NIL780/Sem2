        // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        // 645 -> 5
        // 78 -> третьей цифры нет
        // 32679 -> 6
        // функция-метод
        Console.Clear();
        Console.WriteLine("Введите число: ");
        string s1 = Convert.ToString(Console.ReadLine());
        char s2 = s1[2];// string s2 = s1.Substring(2);
        Console.WriteLine(s2);
        






//int firstDigit = value / Math.Pow( 10, numberOfDigits );
// Console.WriteLine($"Последнее число трехзначного значения ({a})");

// if (Number>99||Number<1000)
// {int sqr=Number % 10;
// Console.WriteLine($"Последнее число трехзначного значения ({sqr})");}
// if (Number<100)
// {Console.WriteLine("третья цифра отсутствует");
// return;}
// if (Number>=1000)
// {int a=Number/100%10;
// Console.WriteLine($"третья цифра({a})");}

