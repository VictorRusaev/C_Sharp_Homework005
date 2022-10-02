Console.Clear();

int[] mainArray = CreateArray();
Console.Write(String.Join(", ", mainArray));
int numOfEv = EvenFromArray(mainArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных элементов: {numOfEv}");

int[] CreateArray()
{
    int[] array = new int[10];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(100, 1000);
    }
    return array;
}

int EvenFromArray(int[] arr)
{
    int numberOfEven = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            numberOfEven = numberOfEven + 1;
        }
    }
    return numberOfEven;
}

