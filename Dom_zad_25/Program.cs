
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}

int[,,] Create_trio_mass(int strok, int stolb, int sloi, int f1_num, int f2_num)
{
    int[,,] rand_mass = new int[strok, stolb, sloi];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            for (int k = 0; k < sloi; k++)
            {
                rand_mass[i, j, k] = new Random().Next(f1_num, f2_num);
            }
        }
    }
    return rand_mass;
}

void PrintMassRow(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.Write(mass[i, j,k] +$"({i},{j},{k});   ");
            }
            
        }
    }
    Console.WriteLine();
}


int num_i = GetNumber("Vvedite X: ");
int num_j = GetNumber("Vvedite Y: ");
int num_k = GetNumber("Vvedite Z: ");


int[,,] d_mass = Create_trio_mass(num_i, num_j, num_k, 10, 100);

PrintMassRow(d_mass);


