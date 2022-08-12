int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if(arg2>resalt) resalt = arg2;
    if(arg3>resalt) resalt = arg3;
    return resalt;
}
int a = 44;
int b = 5;
int c = 78;

int max = Max(a, b, c);

Console.Write("max= ");
Console.WriteLine(max);