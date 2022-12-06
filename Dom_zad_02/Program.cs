int a=new Random().Next(0,99);
int b=new Random().Next(0,99);
int c=new Random().Next(0,99);
int max= 0;
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine("a samoe bolshoe!");
        max=a;

    }
    else
    {
        Console.WriteLine("c samoe bolshoe!");
        max=c;
    }
}

else

    if (b>c)
    {
        Console.WriteLine("b samoe bolshoe!");
        max=b;

    }
    else
    {
        Console.WriteLine("c samoe bolshoe!");
        max=c;
    }
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine("Max ravno: ");
Console.WriteLine(max);
