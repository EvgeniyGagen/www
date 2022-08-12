int[] array = {1, 2, 3, 4, 5, 6};
int n = array.Length;
int index = 0;
while(index < n)
{
    if(array[index] % 2==0)
    {
        Console.WriteLine("четное число");
    }
    else
    {
        Console.WriteLine("нечетное число");
    }
    index++;
}
