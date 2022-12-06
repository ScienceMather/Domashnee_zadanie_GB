Console.WriteLine("Vvedite a: ");
string anum = Console.ReadLine();
int a=Convert.ToInt32(anum);

Console.WriteLine("Vvedite b: ");
string bnum = Console.ReadLine();
int b=Convert.ToInt32(bnum);


if (a>b)
{
    Console.WriteLine("a bolshee chislo i ravno:");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("b bolshee chislo i ravno:");
    Console.WriteLine(b);
}