Console.Write("Vvedite trehznachnoe chislo: ");
int chislo = int.Parse(Console.ReadLine());
int result = 0;
if (chislo<100) Console.WriteLine("Tretei cifri net");
else
{
    while (chislo>=1000) chislo = chislo/10;
    result= chislo%10;
    Console.WriteLine($"Treyaya cifra {result}!");  
}
