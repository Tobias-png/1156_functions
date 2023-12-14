
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Security.Cryptography;

namespace funkce_test;

internal class FuncApp
{
    public void Run()
    {
        TextLength("heh");
        SquareRoot(2);
        PrintHappyBirthday(false);
        IsOdd(5);
        Counter(1, 12);
        //ReturnLonger("ano", "ne");
    }

    //1
    public int TextLength(string str)
    {
        if (int.TryParse(str, out int r))
            return r;
        else
            return 0;

        Console.WriteLine(r);
    }

    //2


    public int SquareRoot(int b)
    {
        return (b * b);
    }


    //3


    public void PrintHappyBirthday(bool c)
    {
        if (c = true)
        {
            Console.WriteLine("Všechno nejlepší");
        }
    }

    //4

    string x = "číslo je sudé";
    string y = "číslo je liché";
    public int IsOdd(int d)
    {
        if ((d % 2) == 0)
        {
            int.TryParse(x, out int r);
                return r;
            
        }
        else
        {
            int.TryParse(y, out int s);
                return s;
        }
     }


    //5

    public void Counter(int number1, int number2)
    {
        for (int i = number1; i < number2; i++)
        {
            Console.WriteLine(i);
        }
    }

    //6

    /*public int ReturnLonger()



    */
}