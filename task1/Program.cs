//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

void EvenNumbers (int[]collection)
{
    Console.Write("Четные числа: ");
    for (int i = 0; i < collection.Length; i++)
        if (collection[i]%2==0) Console.Write($"{collection[i]} ");
}

int [] array = new int[10];
FillArray(array);
string newArray = PrintArray(array);
Console.Write("Исходный массив: ");
Console.WriteLine(newArray);
EvenNumbers (array);