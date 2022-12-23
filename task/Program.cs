Console.Write("Введите количество строк в массиве: ");
//int amountString = Convert.ToInt32(Console.ReadLine());
string str = Console.ReadLine();
if (int.TryParse(str, out int amountString))
{

}
else
{
    Console.WriteLine("Введите целое число больше нуля");
}
if (amountString < 0)
{
    Console.WriteLine("Введите целое число больше нуля");
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
count = 0;
for (int i = 0; i < amountString; i++)
{
    if (inputArray[i].Length < 4)
    {
        finalArray[count] = inputArray[i];
        count++;
    }
}
//string arr = string.Join(", ", inputArray);
//Console.Write(arr);

Console.Write(finalArray[new Random().Next(0,count)]);
