using System;

namespace flowcontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             ifstatement obj = new ifstatement();
            obj.ifst ();
            ifelsestatement obj2 = new ifelsestatement();
             obj2.ifel ();
            nestedifstatement obj3 = new nestedifstatement();
            obj3.nest1 ();
            elseifstatement obj4 = new elseifstatement();
            obj4.el1();
            whilestatement obj5 = new whilestatement();
            obj5.el2();
           dowhilestatement obj6 = new dowhilestatement();
            obj6.el3();
            forloopstatement obj7 = new forloopstatement();
            obj7.for1();
            
        }
    }
          
}
class ifstatement
{
    public void ifst()
    {
        if (20 > 18)
        {
            Console.WriteLine("20 is greater than 18");
        }
    }
}


class ifelsestatement
{
    public void ifel()
    {
        int time = 20;
        if (time < 18)
        {
            Console.WriteLine("morning.");
        }
        else
        {
            Console.WriteLine(" evening.");
        }
    }
}


class nestedifstatement
{
    public void nest1()
    {
        int x = 5, y = 20;
        if (x > y)
        {
            if (x >= 10)
            {
                Console.WriteLine("x value greater than or equal to 10");
            }
            else
            {
                Console.WriteLine("x value less than 10");
            }
        }
        else
        {
            if (y <= 20)
            {
                Console.WriteLine("y value less than or equal to 20");
            }
            else
            {
                Console.WriteLine("y value greater than 20");
            }
        }
        Console.WriteLine("Press Enter Key to Exit..");
        Console.ReadLine();
    }
}


class elseifstatement
{
    public void el1()
    {
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("hellow");
        }
        else if (time < 20)
        {
            Console.WriteLine("good.");
        }
        else
        {
            Console.WriteLine(" important");
        }
    }
}

class whilestatement
{
    public void el2()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}

class dowhilestatement
{
    public void el3()
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i < 5);
    }
}

class forloopstatement
{
    public void for1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }

}



