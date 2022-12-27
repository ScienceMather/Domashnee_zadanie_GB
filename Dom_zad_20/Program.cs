
int GetElem(string text)
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

string CheckElem(int [,] mass,int ch_i,int ch_j)
{
    string result="Takogo elementa massiva net!";
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i==ch_i && j==ch_j)
            {
                int right_elem = mass[i,j];
                result=$"Element est i raven: {right_elem}";
            }
        }
    }
    return result;
}

int II = new Random().Next(3,9);
int JJ = new Random().Next(3,7);

int [,] d_mass = Create_duo_mass(II,JJ, -10, 11);

int check_i=GetElem("Vvedite i: ");
int check_j=GetElem("Vvedite j: ");

PrintMass(d_mass);

string result = CheckElem(d_mass,check_i,check_j);
Console.WriteLine(result);


