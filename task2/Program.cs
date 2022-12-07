//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0; 
    while(index<length) 
    {
        collection[index] = new Random().Next(99,1000);
        index++;
    }

}
string PrintArray (int[]collection)
{
    int count = collection.Length;
    int position = 0;
    string result = "[ ";
    while(position < count)
    {
        result = result + ($"{collection[position]}") + ($",");
        position++;
    }
    
    return result + "]";
}

int OddNumbers (int[]collection)
{
    int sumodd = 0;
    Console.Write("Нечетные числа: ");
    for (int i = 0; i < collection.Length; i++)
        if (collection[i]%2 !=0) 
        {
            Console.Write($"{collection[i]} ");
            sumodd += collection[i];
        }
    return sumodd;
}

int [] array = new int[10];
FillArray(array);
string newArray = PrintArray(array);
Console.Write("Исходный массив: ");
Console.WriteLine(newArray);
int result = OddNumbers (array);
Console.WriteLine();
Console.Write("Сумма нечетных чисел: ");
Console.WriteLine(result);
