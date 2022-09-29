// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine()); 
int[] array = FillArray(razmer, -100, 100);
PrintArray(newarray);
//int[] newarray = MultiplyElem(razmer, -100, 100);
/*int[] array1 = new int[3];
int j= 0;
    for (int i = 0; i < array1.Length; i++)
        {
        array1[i] =array[i]*array[array.Length-j-1];
        j=j+1;
    }   

*/
int[] MultiplyElem(int[] array_local) {     
    int Len = 0;      
    if (array_local.Length % 2 == 0) Len = array_local.Length / 2;     
    else        
    Len = array_local.Length / 2 + 1;      
    int[] new_array = new int[Len];      
    for (int i = 0; i < Len; i++)
    {
        new_array[i] = array_local[i] * array_local[array_local.Length - 1 - i];
    }}

void PrintArray(int[] arr) {     
    Console.WriteLine("\n [" + String.Join(",", arr) + "]"); 
    } 


Console.WriteLine("[" + String.Join(",",array)+ "]"); 
Console.WriteLine("[" + String.Join(",",newarray)+ "]"); 




    int[] FillArray(int razmer, int min, int max)
{
    int[] filledArray = new int[razmer];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

    
    
