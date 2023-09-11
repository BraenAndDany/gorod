string[] osn = new string[1000];
string copy=osn[0];
string gor = osn[0];
int g = 0;
Console.WriteLine("Vvedite pervi gorod");
osn[g] = Console.ReadLine();

for(int i = 0; i < 2;)
{
    
    Console.WriteLine("Vvedite gorod");
    copy = osn[g];
    gor =Console.ReadLine();
    if (copy[copy.Length-1] == gor[0])
    {
        g++;
    }
    else
    {
        i = 2;
        Console.WriteLine("Game over");
    }
    for (int j=0;j<osn.Length-1;j++)
    {
        if (gor == osn[j])
        {
            i = 2;
            Console.WriteLine("Game over");
        }
    }
    osn[g] = gor;
}