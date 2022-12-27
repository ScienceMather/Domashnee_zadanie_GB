
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}

double [,] Create_duo_mass (int strok,int stolb, int f1_num ,int f2_num)
{
    double [,] rand_mass=new double[strok,stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            rand_mass[i,j]=Math.Round(new Random().NextDouble()*(f2_num-f1_num)+f1_num,2);
        }
    }
    return rand_mass;
}

void PrintMass(double [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i,j] + "  ");
        }
    }
}

int num_i=GetNumber("Vvedite kol-vo strok: ");
int num_j=GetNumber("Vvedite kol-vo stolbtsov: ");

double [,] d_mass = Create_duo_mass(num_i,num_j, -10, 11);
PrintMass(d_mass);


