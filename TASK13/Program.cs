// Напишите программу, которая 
// 1.выводит третью цифру заданного числа
// 2.или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
while (num => 1000);
      num / 10;
  int thirtNumber = num % 10;
       return thirtNumber; 
}
int finalNum = ThirdDigit(num);
Console.WriteLine(finalNum);
