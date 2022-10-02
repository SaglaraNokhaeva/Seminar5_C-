// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine()); 
int[] array = FillArray(razmer, 0, 10);
PrintArray(array);
MultiplyElem(array);
PrintArray(MultiplyElem(array));

int [] MultiplyElem(int[] arr) {  
    int new_arr_length =  razmer;
    if (razmer % 2 == 1) new_arr_length=new_arr_length+1;     
    int[] new_arr = new int[new_arr_length/2];      
    int k=razmer-1;
    for (int i = 0; i < razmer/2; i++)
    {
        new_arr[i] = arr[i] * arr[k];
        k--;
    }
    if (razmer % 2 == 1) new_arr[new_arr_length/2-1] = arr[new_arr_length/2-1];
    return new_arr;
    }

void PrintArray(int[] arr) {     
    Console.WriteLine("\n [" + String.Join(",", arr) + "]"); 
    } 


//Console.WriteLine("[" + String.Join(",",array)+ "]"); 
//Console.WriteLine("[" + String.Join(",",new_array)+ "]"); 




    int[] FillArray(int razmer, int min, int max)
{
    int[] filledArray = new int[razmer];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

    
    
