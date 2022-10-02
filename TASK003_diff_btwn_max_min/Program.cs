Console.Clear();

double[] mainArray = CreateArray();
Console.WriteLine(String.Join(", ", mainArray));
double max = MaxSelection(mainArray);
double min = MinSelection(mainArray);
Console.WriteLine($"Max: {max}, Min: {min}");
Console.WriteLine($"Разница между Max и Min: {DiffMaxFromMin(max, min)}");

double[] CreateArray()
{
    double[] array = new double[10];
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 100);
    }
    return array;
}

double MaxSelection(double[] arr1)
{
    double maxResult = 0;
    for(int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i] > maxResult) 
        {
            maxResult = arr1[i];
        }
    }
    return maxResult;
}

double MinSelection(double[] arr2)
{
    double minResult = 100;
    for(int i = 0; i < arr2.Length; i++)
    {
        if(arr2[i] < minResult)
        {
            minResult = arr2[i];
        }
    }
    return minResult;
}

double DiffMaxFromMin(double maximum, double minimum)
{
    double DiffMaxFromMin = maximum - minimum;
    return DiffMaxFromMin;
}

