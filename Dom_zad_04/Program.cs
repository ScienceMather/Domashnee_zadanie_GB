Console.WriteLine("Vvedite a: ");
string anum = Console.ReadLine();
int a=Convert.ToInt32(anum);
int count =2;

while (count<a+1)
{
    if (count%2==0)
    {
        Console.Write(count);
        count++;
    }
    else
    {
        
        Console.Write(",");
        count++;
    }
    
}
Console.Write(".");