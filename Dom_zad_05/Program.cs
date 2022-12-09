Console.Write("Vvedite trehznachnoe chislo: ");
int triple = int.Parse(Console.ReadLine());
double result_10 = triple%10;
double result_100 =triple-result_10;
double result_2 = result_100/10;
double result_1 = result_2%10;
Console.WriteLine($"Vtoraya cifra {result_1}!");
