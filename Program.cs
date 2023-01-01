// Знакомство с яз.программирования. Семинар-5.


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
//ЗАДАЧА-1. Задать массив из 12 элементов, заполн. случ. числами от -9 до 9. Найти сумму отриц.элем. массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)        // метод создает и заполняет массив заданного размера случ.числами, но
{                                                                    // с указанием максимального и минимального значения
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)                                          // метод формирует массив для вывода на консоль                               
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();                                            // строка позволяет перенести следующую информацию на другую строку
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum += array[i]; // sum = sum + array[i];
        }
    }

    return sum;
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int result = GetSumOfNegatives(myArray);

Console.WriteLine("Сумма отрицательных элементов в массиве равна " + result);  // решено
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-1(самост). Замена элементов массива. Полож. заменить на отриц.Отриц.- на положит. // умн. на -1
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)        
{                                                                    
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)                                                                         
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();                                            
}

int[] ReversPlusMinus(int[] array)
{
    int n = -1;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * n;   //array[i]*= n;
    }
    return array;
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[] myArray = CreateRandomArray(length, min, max);
Console.Write("исходный массив: ");
ShowArray(myArray);

Console.WriteLine();

int[] newArray = ReversPlusMinus(myArray);
Console.Write("преобразованный массив: ");
ShowArray(newArray);

Console.WriteLine();                                        // решено
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-2(самост). Программа, кот. определяет: присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)        
{                                                                    
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)                                          // метод формирует массив для вывода на консоль                               
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
    Console.WriteLine();                                            // строка позволяет перенести следующую информацию на другую строку
}

bool NumYesNo(int[] array, int n)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == n)
            return true;
        
    }

    return false;
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
Console.Write("массив : ");
ShowArray(myArray);

Console.Write("введите проверяемое число :");
int n = Convert.ToInt32(Console.ReadLine());

bool res = NumYesNo(myArray,n);

if(res == false)Console.WriteLine("нет такого числа в массиве");
if(res == true)Console.WriteLine("поздравляю, проверяемое число в массиве присутствует");  // решено
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-3(самост). Задать массив из М случайных чисел. Найти количество элементов массива, значения кот. лежат от А до Б

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();                                  
}

int AnnnB(int[] array, int nnA, int nnB)
{
    
    int count = 0;
    
    if (nnA > nnB)
    {
        int temp = nnA;
        nnA = nnB;
        nnB = temp;
    }
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] >= nnA && array[i] <= nnB)count++;
    }        
    return count;         
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

Console.Write("массив : ");

ShowArray(myArray);

Console.Write("введите число А :");
int nnA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число Б :");
int nnB = Convert.ToInt32(Console.ReadLine());

int diffRes = AnnnB(myArray, nnA, nnB);

Console.WriteLine("количество чисел между А и Б равно  " + diffRes);     // решено
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// HomeWork
// HomeWork
// HomeWork

int[] CreateRandomArray(int size, int minValue, int maxValue)                  // метод формирует массив для вывода на консоль
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}


int[] CreateHandArray(int size)                                               // метод ввода массива пользователем
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)Console.Write("Введите  первый элемент массва : ");
        if(i != 0 & i != size-1)Console.Write("Введите  следующий элемент массва : ");
        if(i == size-1)Console.Write("Введите  последний элемент массва : ");
        int elemArr = Convert.ToInt32(Console.ReadLine());

        array[i] = elemArr;
    }

    return array;
}


void ShowArray(int[] array)                                                   // метод формирует массив для вывода на консоль                               
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();                                                     // строка позволяет перенести следующую информацию на другую строку
}


void ShowArrayMod(int[] array)                                               // метод вывода массива на консоль (модерниз.)
{ 
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)Console.Write("массив: [" + array[i] + ",");
        if(i != 0 & i != array.Length-1)Console.Write(array[i] + ",");
        if(i == array.Length-1)Console.Write(array[i] + "]");
    }
    Console.WriteLine();                                           
}

/*
Console.Write("введите количество элементов массива :");                     // исходный код программы
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("хотите самостоятельно заполнить массив?(y,n) :");
string answer = Console.ReadLine();

int d = 0;
if(answer != "y")d = 1;
if(d != 1)
{
    int[] myArray = CreateHandArray(length);

    Console.Write("хотите красивый вывод на экран?(y,n) :");
    string answShow = Console.ReadLine();

    if(answShow != "y")d = 1;
    if(d != 1)
    {
        ShowArrayMod(myArray);
    }
    else
    {
        ShowArray(myArray);
    }
}
else
{
    Console.Write("введите минимальное значение :");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максимальное значение :");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] myArray = CreateRandomArray(length, min, max);
    
    Console.Write("хотите красивый вывод на экран?(y,n) :");
    string answShow = Console.ReadLine();

    if(answShow != "y")d = 0;
    if(d != 0)
    {
        ShowArrayMod(myArray);
    }
    else
    {
        ShowArray(myArray);
    }
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int NEven(int[] array)                                                       // метод
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    
        if(array[i] % 2 == 0)
            sum = sum + 1;

    return sum;        
}   // разблокировать в коде программы " к задаче 34" // решено


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int NOdd(int[] array)                                                        // метод
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    
        if(i % 2 != 0) // проверка по нечетным индексам     /// if(i % 2 == 0) это для проверки по нечетной позиции элемента           
            sum = sum + array[i];

    return sum;        
}   // разблокировать в коде программы " к задаче 36"  // решено



Console.Write("введите количество элементов массива :");                     // код программы
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("хотите самостоятельно заполнить массив?(y,n) :");
string answer = Console.ReadLine();

int d = 0;
if(answer != "y")d = 1;
if(d != 1)
{
    int[] myArray = CreateHandArray(length);

    Console.Write("хотите красивый вывод на экран?(y,n) :");
    string answShow = Console.ReadLine();

    if(answShow != "y")d = 1;
    if(d != 1)
    {
        ShowArrayMod(myArray);
    }
    else
    {
        ShowArray(myArray);
    }

    //int result = NEven(myArray);                                                                    // к задаче 34
    //Console.WriteLine("Количество четных чисел в массиве равно " + result);                         // к задаче 34

    //int result = NOdd(myArray);                                                                     // к задаче 36
    //Console.WriteLine("Сумма элементов, стоящих на нечетных позициях в массиве равна " + result);   // к задаче 36
}
else
{
    Console.Write("введите минимальное значение :");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максимальное значение :");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] myArray = CreateRandomArray(length, min, max);
    
    Console.Write("хотите красивый вывод на экран?(y,n) :");
    string answShow = Console.ReadLine();

    if(answShow != "y")d = 0;
    if(d != 0)
    {
        ShowArrayMod(myArray);
    }
    else
    {
        ShowArray(myArray);
    }

    //int result = NEven(myArray);                                                                    // к задаче 34
    //Console.WriteLine("Количество четных чисел в массиве равно " + result);                         // к задаче 34

    //int result = NOdd(myArray);                                                                     // к задаче 36
    //Console.WriteLine("Сумма элементов, стоящих на нечетных позициях в массиве равна " + result);   // к задаче 36   
} 


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// NextDouble()   new Random().NextDouble(); //генерирует случ.вещественные числа от 0 до 1 и не принимает аргументы
                                             // типа new Random().Next(minValue, maxValue + 1) и (minValue, maxValue + 1) - это аргументы

/*
double[] CreateRandomArrayD(int size, int minValue, int maxValue)        
{                                                                    
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
        for(int i = 0; i < size; i++)
            array[i] = Math.Round(array[i], 1);
        
    return array;
}

void ShowArrayD(double[] array)                                                                         
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " _ ");
        
    }
    Console.WriteLine();                                           
}

double MinMaxDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)max = array[i];
        if(array[i] < min)min = array[i];
    }
    diff = max - min;
    return diff;
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArrayD(length, min, max);
ShowArrayD(myArray);

double result = MinMaxDiff(myArray);
result = Math.Round(result, 1);

Console.WriteLine("Разность между максимальным и минимальным элементом массива равна " + result);       //решено                                             
*/










