﻿Console.Write("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int numb3 = int.Parse(Console.ReadLine()!);

if ((numb1 > numb2) && (numb1 > numb3)) Console.WriteLine($"{numb1}");
if ((numb1 < numb2) && (numb2 > numb3)) Console.WriteLine($"{numb2}");
if ((numb1 < numb3) && (numb2 < numb3)) Console.WriteLine($"{numb3}");