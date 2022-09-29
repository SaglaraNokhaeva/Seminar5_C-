// Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


Console.Clear();  
Console.WriteLine("Введите число для поиска: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(4, 0, 10);  
bool rezult=false;

Console.WriteLine("[" + String.Join(",",array)+ "]"); 


for (int i=0; i<array.Length;i++)
if  (array[i]==n) rezult=true;



Console.WriteLine("[" + String.Join(",",array)+ "]");  
Console.WriteLine(rezult);

    int[] FillArray(int size, int min, int max)
{   int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

