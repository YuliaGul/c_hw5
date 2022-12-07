//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void FillArray (double[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write("Введите элемент массива = ");
        collection[index] = Convert.ToDouble(Console.ReadLine());
    }

}
string PrintArray (double[]collection)
{
    string result = "[ ";
    for (int position = 0; position < collection.Length; position++)
    {
        result = result + ($"{collection[position]}") + ($"  ");
    }
    
    return result + "]";
}

double MaxNumber (double[]collection)
{
    double maxresult = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if (maxresult < collection[i]) maxresult = collection [i];
    }
    return maxresult;
}
double MinNumber (double[]collection)
{
    double minresult = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if (minresult > collection[i]) minresult = collection [i];
    }
    return minresult;
}

double [] array = new double[10];
FillArray(array);
string newArray = PrintArray(array);
Console.Write("Исходный массив: ");
Console.WriteLine(newArray);
double maxnumber = MaxNumber (array);
Console.Write("Максимум: ");
Console.WriteLine(maxnumber);
double minnumber = MinNumber (array);
Console.Write("Минимум: ");
Console.WriteLine(minnumber);
Console.Write("Разница между max и min: ");
Console.WriteLine(maxnumber - minnumber);