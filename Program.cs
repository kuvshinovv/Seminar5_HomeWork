//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/* int min = 0;  // определяем переменные
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
CountChet(array); */


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


/* int min = 0;  // определяем переменные
int max = 0;
int size = 0;
int sum = 0;

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

void SummNechetPos(int[] array){
    
    for (int i = 0; i < array.Length; i=i+2) {
        sum = sum + array[i];
    }
    Console.Write($" Сумма элементов, стоящих на нечётных позициях = {sum} ");
}

int InputMAX(){
    Console.WriteLine("Введите МАКСИМАЛЬНЫЙ элемент массива: ");
    max = Convert.ToInt32(Console.ReadLine());
        if (max < min){
            Console.WriteLine("Вы ввели максимум, который меньше минимума, попробуйте снова...");
            InputMAX();
        }
    return max;
}

Console.WriteLine("Введите значение размера массива: ");
size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите МИНИМАЛЬНОЕ значение массива: ");
min = Convert.ToInt32(Console.ReadLine());
InputMAX();

int[] array = CreateRandomArray(size, min, max);

ShowArray(array);
SummNechetPos(array);
 */



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int min = 0;  // определяем переменные
int max = 0;
int size = 0;
int maxElement = 0;
int minElement = 0;
bool pass = false;

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

int MaxEL(int[] array){
    maxElement = array[0];
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxElement){
                maxElement = array[i];
            }
        } 
    return  maxElement;
}

int MinEL(int[] array){
    minElement = array[0];
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < minElement){
                minElement = array[i];
            }
        } 
    return  minElement;  
}

int InputSIZE(){
    Console.WriteLine("Введите значение размера массива: ");
    size = Convert.ToInt32(Console.ReadLine());
        if(size>0){
           pass = true;  // т.к. размер массива больше 0 то ставим в pass значение true и в дальнейшем продолжем ввдить данные.
        }
        else if(size<0){
            Console.WriteLine("Размер массива не может быть отрицательным! ");
            InputSIZE();  // использовал рекурсию (вызов функции самой себя)
        }
        else if(size==0){
            Console.WriteLine("Размер массива = 0! Минимальных и Максимальных значений нет!!! ");
            pass = false;
        }
    return size;
}

int InputMAX(){
        Console.WriteLine("Введите МАКСИМАЛЬНЫЙ элемент массива: ");
        max = Convert.ToInt32(Console.ReadLine());
            if (max < min){
                Console.WriteLine("Вы ввели максимум, который меньше минимума, попробуйте снова...");
                InputMAX();  // использовал рекурсию (вызов функции самой себя)
            }
        return max;
    }


InputSIZE();
if (pass == true){   // pass работает как флаг..  если он true (т.е введенный размер массива > 0, то тогда продолжаем вводить мин и макс...  
                    //если он false то останавливаем программу и говорим что размер массива = 0 )

    Console.WriteLine("Введите МИНИМАЛЬНОЕ значение массива: ");   // этот ввод не стал делать методом, т.к. его значение может быть любым
    min = Convert.ToInt32(Console.ReadLine());
    
    InputMAX();   // вызываем функци. ввода максимального числа

    int[] array = CreateRandomArray(size, min, max);  // создаем массив и кладем в переменную 

    ShowArray(array); // выводим созданный массив

    int maxel = MaxEL(array);  // вызываем функцию которая ищет максимальное число
    int minel = MinEL(array);   // вызываем функцию которая ищет минимальное число
    Console.WriteLine($" Разница между максимальным ({maxel}) и минимальным ({minel}) элементом = {maxel-minel} ");
}