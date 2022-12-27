
int GetNumber(string text)
{
    Console.WriteLine(text);
    int numb =int.Parse(Console.ReadLine());
    return numb;
}

int [,] Create_duo_mass (int strok,int stolb, int f1_num ,int f2_num)
{
    int [,] rand_mass=new int[strok,stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            rand_mass[i,j]=new Random().Next(f1_num,f2_num);
        }
    }
    return rand_mass;
}

void PrintMass(int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i,j] + "  ");
        }
    }
    Console.WriteLine();
}

double[] SummRows(int [,] mass)
{
    double [] res_mass= new double[mass.GetLength(1)];
    
    double result=0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            result= result+mass[i,j];
            
        }
        res_mass[j]=result/mass.GetLength(0);
        result=0;
    }
    return res_mass;
}


int num_i=GetNumber("Vvedite kol-vo strok: ");
int num_j=GetNumber("Vvedite kol-vo stolbtsov: ");

int [,] d_mass = Create_duo_mass(num_i,num_j, -10, 11);
PrintMass(d_mass);

double[] result = SummRows(d_mass);
Console.WriteLine($"[{string.Join(";",result)}]");


