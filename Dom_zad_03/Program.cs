Console.WriteLine("Vvedite a: ");
string anum = Console.ReadLine();
double a=Convert.ToDouble(anum);
if (a%2==0) 
{
    Console.WriteLine("Chetnoe!");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Nechetnoe!");
    Console.WriteLine(a);
}
