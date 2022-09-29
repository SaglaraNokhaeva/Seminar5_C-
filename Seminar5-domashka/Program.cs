Console.Clear();
Console.WriteLine("Введите номер задачи (34, 36 или 38) для проверки:");
int num = int.Parse(Console.ReadLine());
if(num==34) Task34();
else if(num==36) Task36();
else if (num==38) Task38();
else Console.WriteLine("Дополнительные задачи не выполняла.");

void Task34(){
   
// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[razmer];
massiv=Rand_mass(massiv);
Console.Write(String.Join(",",massiv));
int even_count=Get_even_count(massiv);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел = {even_count}");


int Get_even_count(int[] massiv_local){
    int i=0;
    int even_coun=0;
    for (i=0;i<massiv_local.Length;i++){
      if ((massiv_local[i]%2)==0) even_coun++;
    }
    return even_coun;
}

int [] Rand_mass(int[] massiv_local){
    int i=0;
    Random rnd =new Random();
    for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = new Random().Next(100, 1000);;
    }
    return massiv_local;
}
};


void Task36(){
   
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[razmer];
massiv=Rand_mass(massiv);
Console.Write(String.Join(",",massiv));
int summa=Get_sum(massiv);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {summa}");


int Get_sum(int[] massiv_local){
    int i=0;
    int sum=0;
    for (i=0;i<massiv_local.Length;i++){
      if ((i%2)!=0) sum+=massiv_local[i];
    }
    return sum;
}

int [] Rand_mass(int[] massiv_local){
    int i=0;
    Random rnd =new Random();
    for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = new Random().Next(0, 10);;
    }
    return massiv_local;
}
}

void Task38(){
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());

double[] massiv = new double[razmer];
massiv=Rand_mass(massiv);
Console.Write(String.Join(",",massiv));
double raznost=Get_sum(massiv);
Console.WriteLine();
Console.WriteLine($"Разность максимального и минимального элементов = {raznost}");


double Get_sum(double[] massiv_local){
    int i=0;
    double rezult=0;
    double min=massiv_local[0];
    double max=massiv_local[0];
    for (i=0;i<massiv_local.Length;i++){
      if (massiv_local[i]>max) max=massiv_local[i];
      if (massiv_local[i]<min) min=massiv_local[i];
    }
    rezult=max-min;
    return rezult;
}

double [] Rand_mass(double[] massiv_local){
    int i=0;
    Random rnd =new Random();
    for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = rnd.NextDouble();
    }
    return massiv_local;
}
};