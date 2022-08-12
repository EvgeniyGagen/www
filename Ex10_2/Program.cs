int[] array = {7,8,2};
int n = array.Length;
int find = 8;
int index = 0;
while(index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(find);
    }
    index++;
}
