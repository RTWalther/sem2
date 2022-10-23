// Напишите программу, которая 
// 1. выводит случайное трёхзначное число 
// 2. удаляет вторую цифру этогочисла.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int FirstLastNumber(int number)
{
    int firstNumber = number / 100;
    int LastNumber = number % 10;
    // int result = firstNumber*10 + LastNumber;
    // return result;
    return firstNumber*10 + LastNumber;
}

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int finalNum = FirstLastNumber(num);
Console.WriteLine(finalNum);