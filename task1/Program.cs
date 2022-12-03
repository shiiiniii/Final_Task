
Console.Clear();
Console.WriteLine("Программа, которая из 3х массивов слов и цифр выведет только те, которые состоят из трех или меньше символов."); 	
string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
int maxWordLength = 3;
		
string[] FindShortWordsInArray(string[] array)
{
    int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i].Length <= maxWordLength)
        {
            result[count] = array[i];
            count++;
		}
	}
	Array.Resize(ref result, count);
			
	return result;
}
		
void PrintArray(string[] array)
{
	if(array.Length == 0)
	{
		Console.WriteLine("Нет слов, удовлетворяющих условию.");
	}
	else
	{
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();
	}
}


Console.WriteLine();
Console.WriteLine("Первый ряд слов:");
PrintArray(arr1);
string[] newArray1 = FindShortWordsInArray(arr1);
Console.WriteLine();
Console.WriteLine($"Удовлетворяющие условию (3 символа или меньше): ");
PrintArray(newArray1);
	
Console.WriteLine();
Console.WriteLine("Второй ряд слов:");
PrintArray(arr2);
string[] newArray2 = FindShortWordsInArray(arr2);
Console.WriteLine();
Console.WriteLine($"Удовлетворяющие условию (3 символа или меньше): ");
PrintArray(newArray2);

Console.WriteLine();
Console.WriteLine("Третий ряд слов:");
PrintArray(arr3);
string[] newArray3 = FindShortWordsInArray(arr3);
Console.WriteLine();
PrintArray(newArray3);
