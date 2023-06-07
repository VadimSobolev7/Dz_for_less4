// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int A=123;
int[] array=new int[A];
Random random=new Random();
for(int i=0;i<array.Length;i++)
array[i]=random.Next(0,10);
for(int i=0;i<array.Length;i++)
System.Console.Write($"{array[i],4}");

int count=0;
for(var i=0; i<array.Length;i++)
{
if(i>10 && i<99)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);
