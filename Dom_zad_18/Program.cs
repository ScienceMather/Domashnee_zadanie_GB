
double EnterData(string text_cord)
{
    Console.WriteLine(text_cord);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double[] FindCross(double a,double c, double b,double d)
{
    // y=a*x+c
    // y=b*x+d
    double [] mass_cord = new double [2];
    mass_cord[0]=(d-c)/(a-b);
    Console.WriteLine($"{mass_cord[0]}");
    // x=(d-c)/(a-b)
    mass_cord[1]=a*((d-c)/(a-b))+c;
    Console.WriteLine($"{mass_cord[1]}");

    // y=a((d-c)/(a-b))+c
    return mass_cord;
}

double Num_A = EnterData  ("Vvedite coordinaty A: ");
double Num_C = EnterData  ("Vvedite coordinaty C: ");
double Num_B = EnterData  ("Vvedite coordinaty B: ");
double Num_D = EnterData  ("Vvedite coordinaty D: ");

if (Num_A==Num_B)
{
    if (Num_B==Num_D) Console.WriteLine("Pryamie sovpadaut!");
    else Console.WriteLine("Pryamie parallelni!");
}
else
{
    double[] FindNum = FindCross(Num_A,Num_C,Num_B,Num_D);
    Console.WriteLine($"({string.Join(";",FindNum)})");
}
// Console.WriteLine($"Rasstoyanie mezjdy tochkami ravno {FindNum}");
