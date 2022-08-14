using System;
class Program
{
    static void SelectNumb()
    {
        string[] Numbers = {"3","2","6","7","9"};
        for (int i = 0; i < Numbers.Length-1; i++)
        {
            Console.Write(i+1 + " - " + Numbers[i] + ", ");
        }
        Console.WriteLine(Numbers.Length + " - " + Numbers[Numbers.Length-1] + ".");
        Console.WriteLine("Укажите вашу позицию? ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша число: " + Numbers[number-1]);
    }
    
    
    static void WriteSelect(string[] arg)
    {
        for (int i = 0; i < arg.Length-1; i++)
        {
            Console.Write(i+1 + " - " + arg[i] + ", ");
        }
        Console.WriteLine(arg.Length + " - " + arg[arg.Length-1] + "." );
    }

    static void Main(string[] arg)
    {
        SelectNumb();
        //SelectSex();
        //SelectClass();
    }


}
