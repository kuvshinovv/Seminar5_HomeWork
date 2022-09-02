//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int min = 0;  // определяем переменные
int max = 0;
int size = 0;

int[] CreateRandomArray(int size, int min, int max){   // Создаем рандомный массив
    int[] array = new int[size];
    
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max+1);
        }
    return array;
}

void ShowArray(int[] array){        // метод выведения на экран созданного массива
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write($"]");
}

void CountChet(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i]%2 == 0){
            count++;
        }
    }
    Console.Write($"Количество чётных чисел в массиве {count} ");
}

int InputSIZE(){
    Console.WriteLine("Введите значение размера массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    return size;
}

int InputMIN(){
    Console.WriteLine("Введите МИНИМАЛЬНЫЙ трёхзначный элемент массива: ");
    min = Convert.ToInt32(Console.ReadLine());
        if (min <= 99 || min > 1000){
            Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова...");
            Console.WriteLine("Введите МИНИМАЛЬНЫЙ трёхзначный элемент массива: ");
            min = Convert.ToInt32(Console.ReadLine());
        }
        return min;
}
int InputMAX(){
    Console.WriteLine("Введите МАКСИМАЛЬНЫЙ трёхзначный элемент массива: ");
    max = Convert.ToInt32(Console.ReadLine());
        if (max < 99 || max > 1000){
            Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова...");
            InputMAX();
        }
        else if (max < min){
            Console.WriteLine("Вы ввели максимум, который меньше минимума, попробуйте снова...");
            InputMAX();
        }
    return max;
}

InputSIZE();
InputMIN();
InputMAX();

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine();
CountChet(array);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76