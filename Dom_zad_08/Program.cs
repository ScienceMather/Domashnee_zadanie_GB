Console.Write("Vvedite pyatiznachnoe chislo: ");
string chislo = Console.ReadLine();

int srez = chislo.Length;
bool T = false;

for (int i =0;i<srez/2;i++)
{
    T = false;
    if (chislo[i]==chislo[srez-i-1])  T = true;
}

if (T) Console.WriteLine($"{chislo} Eto palindrom!");
else  Console.WriteLine($"{chislo} Eto ne palindrom!");
