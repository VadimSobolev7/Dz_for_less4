// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Это наш массив: ");
PrintArray(numbers);

int count = 0;

for (int x = 0; x < numbers.Length; x++)
if (numbers[x] % 2 == 0)
count++;

Console.WriteLine($"У нас {numbers.Length} чисел, {count} из них чётные");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(99,999);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}