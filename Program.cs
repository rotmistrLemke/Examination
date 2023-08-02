// метод вывода массива
void PrintArr(string[] arr)
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

//метод получения итогового массива
string[] GetResultArr(string[] arr, int resultArrayLength)
{
    string[] resultArr = new string[resultArrayLength];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].ToString().ToCharArray().Length < 4)
        {
            resultArr[index] = arr[i];
            index ++;
        }
    }
    return resultArr;
}

string [] testArr = new string [] {"233123","sdf234","123","e","r4"};

PrintArr(GetResultArr(testArr,GetResultArrLengrt(testArr)));
