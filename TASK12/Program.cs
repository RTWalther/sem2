// Напишите программу, которая 
// 1.будет принимать на вход два числа 
// 2.и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

// bool Multiple(int number1, int number2)
// {
//     return number1 % number2 == 0;
// }
// bool.multiple = Multiple(num1,num2);
// Console.WriteLine(multiple?"Кратно" : $"не кратно, остаток {num1 % num2}");

int Multiple(int number1, int number2)
{
    return number1 % number2 ;
}

int remain = Multiple(num1,num2);
Console.WriteLine(remain == 0?"кратно" : $"не кратно, остаток {remain}");