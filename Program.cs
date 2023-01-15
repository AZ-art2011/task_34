// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// task 34

Console.Clear();
int val = 0;
int[] RandArray = new int[10];

for (int i=0; i<RandArray.Length; i++)
{
    RandArray[i] = new Random().Next(100, 1000);
    if (RandArray[i]%2 == 0) val++;
}

Console.Write($" [ {String.Join(", ", RandArray)}]");
Console.Write($" -> {val} четных чисел");