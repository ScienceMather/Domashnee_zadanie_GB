
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}

int[,] Create_duo_mass(int strok, int stolb, int f1_num, int f2_num)
{
    int[,] rand_mass = new int[strok, stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            rand_mass[i, j] = new Random().Next(f1_num, f2_num);
        }
    }
    return rand_mass;
}

void PrintMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "  ");
        }
    }
    Console.WriteLine();
}

int[,] PerMatrix(int[,] mass1, int[,] mass2)
{
    int sumar = 0;
    int[,] permass = new int[mass1.GetLength(0), mass2.GetLength(1)];
    if (mass1.GetLength(1) == mass2.GetLength(0))
    {
        for (int i = 0; i < mass1.GetLength(0); i++)
        {
            for (int j = 0; j < mass2.GetLength(1); j++)
            {
                for (int k = 0; k < mass2.GetLength(0); k++)
                {
                    permass[i, j]+=mass1[i,k]*mass2[k,j];
                }
            }
        }
    }
    
    else Console.WriteLine("Matrici ne peremnojautsya!");
    return permass;
}


int num_i1 = GetNumber("Vvedite kol-vo strok: ");
int num_j1 = GetNumber("Vvedite kol-vo stolbtsov: ");
int num_i2 = GetNumber("Vvedite kol-vo strok: ");
int num_j2 = GetNumber("Vvedite kol-vo stolbtsov: ");

int[,] d_mass1 = Create_duo_mass(num_i1, num_j1, -5, 6);
int[,] d_mass2 = Create_duo_mass(num_i2, num_j2, -5, 6);
PrintMass(d_mass1);
PrintMass(d_mass2);

int[,] result = PerMatrix(d_mass1, d_mass2);
PrintMass(result);


