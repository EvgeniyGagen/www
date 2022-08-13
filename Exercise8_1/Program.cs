int[] array = {1, 2, 3, 4, 5};
int n = array.Length;
int index = 0;
while(index < n)
{
    if(array[index] % 2==0)
    {
        Console.Write("четное число -");
        Console.WriteLine(array[index]);
    }
    else
    {
        Console.WriteLine("нечетное число");
    }
    index++;
}
