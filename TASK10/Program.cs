﻿//  Напишите программу, которая 
//  1. принимает на вход трёхзначное число 
//  2. и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Secondigit(int num)
{
    int secondDigit = (num/10)%10;
    return secondDigit; 
}
int finalNum = Secondigit(num);
Console.WriteLine(finalNum);