Console.Clear();

int[] mainArray = CreateArray();
Console.Write(String.Join(", ", mainArray));
int sumOfNotEv = SumOfNotEvenI(mainArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {sumOfNotEv}");

int[] CreateArray()
{
    int[] array = new int[10];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(-100, 100);
    }
    return array;
}

int SumOfNotEvenI(int[] arr)
{
    int sumOfNotEvenI = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sumOfNotEvenI = sumOfNotEvenI + arr[i];
        }
    }
    return sumOfNotEvenI;
}
