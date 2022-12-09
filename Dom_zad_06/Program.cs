Console.Write("Vvedite trehznachnoe chislo: ");
int chislo = int.Parse(Console.ReadLine());
int count =1;
while (count<2)
{
    double result_1 = chislo%10;
    double result_2 =chislo-result_1;
    double result_3 = result_2/10;
    Console.WriteLine($"Vtoraya cifra {result_3}!");
    count++;
}