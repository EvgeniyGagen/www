using System;
class Program
{
    static void SelectRase()
    {
        string[] namesRase = {"3","2","6","7","9"};
        for (int i = 0; i < namesRase.Length-1; i++)
        {
            Console.Write(i+1 + " - " + namesRase[i] + ", ");
        }
        Console.WriteLine(namesRase.Length + " - " + namesRase[namesRase.Length-1] + ".");
        Console.WriteLine("Укажите вашу позицию? ");
        int numberRase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша число: " + namesRase[numberRase-1]);
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
        SelectRase();
        //SelectSex();
        //SelectClass();
    }


}
