Console.Write("Введите количество строк в массиве: ");
string str = Console.ReadLine();
if (int.TryParse(str, out int amountString))
{

}
else
{
    Console.WriteLine("Введите целое положительное число");
}
if (amountString <= 0)
{
    Console.WriteLine("Количество строк должно быть положительным");
}

string [] inputArray = new string [amountString];
int count = 0;
for (int i = 0; i < amountString; i++)
{
    Console.Write($"Введите {i+1}-й элемент массива строк: ");
    inputArray[i] = Console.ReadLine();
    if (inputArray[i].Length < 4)
    {
        count++;
    }
}
string [] finalArray = new string [count];
int j = 0;
for (int i = 0; i < amountString; i++)
{
    if (inputArray[i].Length < 4)
    {
        finalArray[j] = inputArray[i];
        j++;
    }
}

Console.Write(finalArray[new Random().Next(0,count)]);
