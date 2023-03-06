Console.Write("Введите количество элементов массива:\t");
int elementsCount = int.Parse(Console.ReadLine());

string[] stringArray = new string[elementsCount];

for (int i = 0; i < stringArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    stringArray[i] = Console.ReadLine();
}

string[] gsawelltoett = GetStringArrayWithElementLengthLessThanOrEqualToThree(stringArray);

PrintArray(stringArray);
Console.Write(" -> ");
PrintArray(gsawelltoett);


string[] GetStringArrayWithElementLengthLessThanOrEqualToThree(string[] arr)
{
    int index = 0;
    string[] strArr = new string[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length <= 3 && arr[i].Length > 0)
        {
            strArr[index] = arr[i];
            index++;
        }
    }

    string[] resultArr = new string[index];
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        resultArr[i] = strArr[i];
    }
    return resultArr;
}

void PrintArray(string[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\"" + ", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}