// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат 
//в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
//В своём решении сделайте для 123 
//[5, 18, 123, 6, 2] -> 1 
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

Console.Clear();  
int[] array = FillArray(123, -100, 100); 
int sum=0;

for (int i=0; i<array.Length;i++){
if  (array[i]>9&&array[i]<100) 
sum+=1;
};

Console.WriteLine("[" + String.Join(",",array)+ "]"); 
Console.WriteLine($"Количество чисел из диапазона = {sum}");  

    int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}
