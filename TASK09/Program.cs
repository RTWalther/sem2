// 9. Напишите программу, которая
// 1.выводитслучайное число из отрезка [10, 99] 
// 2.и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10-99 ->{num}");

// int firstDigit = num / 10; // 78 / 10 = 7 .8 (8 отбрасывается)
// int secondDigit = num % 10; // 78 % 10 = 

// int res = firstDigit; 
// if (secondDigit > firstDigit) res = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа = {res}");

// int res = default; 
// if (firstDigit > secondDigit) res = firstDigit;
// else res = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа = {res}");

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {result}");

// Console.Write($"Наибольшая цифра числа {num} = ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);


// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} = {max}");


int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7 .8 (8 отбрасывается)
    int secondDigit = num % 10; // 78 % 10 = 8 
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit (num);
Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");

int maxDigit1 = MaxDigit (23);
Console.WriteLine($"Наибольшая цифра числа {23} = {maxDigit1}");

int maxDigit2 = MaxDigit (67);
Console.WriteLine($"Наибольшая цифра числа {67} = {maxDigit2}");

int maxDigit3 = MaxDigit (87);
Console.WriteLine($"Наибольшая цифра числа {87} = {maxDigit3}");
