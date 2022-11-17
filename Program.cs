string[] fillArray(int arraySize)
{
    string[] userArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Введите {i + 1} строку из {arraySize}: ");
        userArray[i] = Console.ReadLine();
    }
    return userArray;
}

int calculateFutureArraySize(string[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3) count++;
    }
    return count;
}

string[] resultArray(string[] userArray, int sizeForNewArray)
{
    string[] resultArray = new string[sizeForNewArray];
    int j = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            resultArray[j] = userArray[i];
            j++;
        }
    }
    return resultArray;
}

void printArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write($"\"{incomingArray[i]}\"");
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.Write("Какое кол-во строк будем вносить в массив? ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] userArray = fillArray(arraySize);

int sizeForNewArray = calculateFutureArraySize(userArray);

string[] result = resultArray(userArray, sizeForNewArray);
printArray(result);