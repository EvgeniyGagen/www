int[] array = {4,5,6};
int n = array.Length;
int find = 5;
int index = 0;
while(index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(find);
    }
    index++;
}
