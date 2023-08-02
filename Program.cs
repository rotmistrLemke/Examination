// метод вывода массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод получения размерности итогового массива
int GetResultArrLengrt(string[] arr)
{
    string[] resultArr = new string[];
    int len = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].ToString().ToCharArray().Length < 4)
        {
            len++;
        }
    }
    return len;
}


