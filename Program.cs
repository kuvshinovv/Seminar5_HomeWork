//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

/* int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write($"]");
}


int CountPosEl(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    
    {
        if (array[i]>0) count +=array[i];
    }
    return count;
}

int CountNegEl(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    
    {
        if (array[i]<0) count +=array[i];
    }
    return count;
}

Console.WriteLine("input Size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);


int posSum = CountPosEl(array);
int negSum = CountNegEl(array);
Console.WriteLine();
Console.WriteLine($"Сумма позитивныйх элементов {posSum} и сумма негативных элементов {negSum} ");
 */

//___________________________________________________________________________________________________________
//Задача 1 - Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.


/* int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void CountPosEl(int[] array){
    //int count = 0;
    for (int i = 0; i < array.Length; i++) {
    array[i] = array[i]*(-1);
    Console.Write(array[i]+" ");
    }
}

void ShowArray(int[] array){
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write($"]");
}

Console.WriteLine("input Size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);

ShowArray(array);
Console.WriteLine();
CountPosEl(array); */


//Задача 2 - Задайте одномерный массив из произвольно кол-ва случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/* 
int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void CountPosEl(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=10 && array[i]<100) 
        {
         count ++;
        }
    }
    Console.WriteLine($"Количество искомых чисел: {count} ");
    
}

void ShowArray(int[] array){
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write($"]");
}

Console.WriteLine("input Size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine();
CountPosEl(array); */


//Задача 3- Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void Proverka(int[] array, int number){
    bool x = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i]){
            x = true;        
        }  
    }
    if(x == true) Console.WriteLine($"Число {number} присутствует в массиве");
    else Console.WriteLine($"Число {number} НЕ присутствует в массиве");
} 

void ShowArray(int[] array){
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write($"]");
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input Size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);


ShowArray(array);
Console.WriteLine();
Proverka(array, number);