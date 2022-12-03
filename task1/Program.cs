

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Программа, которая из 3х массивов слов и цифр: ( 1. Hello, 2, world, :-); 2. 1234, 1567, -2, computer science; 3. Russia, Denmark, Kazan)  выведет только те слова и цифры, которые состоят из трех или меньше символов."); 	
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
		
