
using System.Data;

// tvoření polí:

char[,] computerBattlefield = new char[11, 11];
char[,] myBattlefield = new char[11, 11];
char[,] myView = new char[11, 11];

computerBattlefield = {
{0,1,2,3,4,5,6,7,8,9,10},
{'A',-,-,-,-,-,-,-,-,-,-},
{'B',-,-,-,-,-,-,-,-,-,-},
{'C',-,-,-,-,-,-,-,-,-,-},
{'D',-,-,-,-,-,-,-,-,-,-},
{'E',-,-,-,-,-,-,-,-,-,-},
{'F',-,-,-,-,-,-,-,-,-,-},
{'G',-,-,-,-,-,-,-,-,-,-},
{'H',-,-,-,-,-,-,-,-,-,-},
{'I',-,-,-,-,-,-,-,-,-,-},
{'J',-,-,-,-,-,-,-,-,-,-}
}

myBattlefield = {
{0,1,2,3,4,5,6,7,8,9,10},
{'A',-,-,-,-,-,-,-,-,-,-},
{'B',-,-,-,-,-,-,-,-,-,-},
{'C',-,-,-,-,-,-,-,-,-,-},
{'D',-,-,-,-,-,-,-,-,-,-},
{'E',-,-,-,-,-,-,-,-,-,-},
{'F',-,-,-,-,-,-,-,-,-,-},
{'G',-,-,-,-,-,-,-,-,-,-},
{'H',-,-,-,-,-,-,-,-,-,-},
{'I',-,-,-,-,-,-,-,-,-,-},
{'J',-,-,-,-,-,-,-,-,-,-}
}

myView = {
{0;1,2,3,4,5,6,7,8,9,10},
{'A',-,-,-,-,-,-,-,-,-,-},
{'B',-,-,-,-,-,-,-,-,-,-},
{'C',-,-,-,-,-,-,-,-,-,-},
{'D',-,-,-,-,-,-,-,-,-,-},
{'E',-,-,-,-,-,-,-,-,-,-},
{'F',-,-,-,-,-,-,-,-,-,-},
{'G',-,-,-,-,-,-,-,-,-,-},
{'H',-,-,-,-,-,-,-,-,-,-},
{'I',-,-,-,-,-,-,-,-,-,-},
{'J',-,-,-,-,-,-,-,-,-,-}
}

// Letadlová loď - 5x1
// Bitevní loď - 4x1
// Křižník - 3x1
// Ponorka - 3x1
// Torpédoborec - 2x1
// Člun - 1x1

Dictionary<int, string> ships = new Dictionary<int, string>();
ships[0] = "L";
ships[1] = "B";
ships[2] = "K";
ships[3] = "P";
ships[4] = "T";
ships[5] = "C";

// tvorba pole PC

int L = rnd.Next(1,10);
bool orientationL = new rnd();

int B = rnd.Next(1, 10);
while (L == B)
{
    B = rnd.Next(1, 10);
    bool orientationB = Random;
}

int K = rnd.Next(1, 10);
while (L == K || K == B)
{
    K = rnd.Next(1, 10);
    bool orientationK = Random;
}

int P = rnd.Next(1, 10);
while (L == P || P == B || P == K) 
{
    P = rnd.Next(1, 10);
    bool orientationP = Random;
}

int T = rnd.Next(1, 10);
while (L == T || T == B || T == P || T == K)
{
    T = rnd.Next(1, 10);
    bool orientationT = Random;
}

int C = rnd.Next(1, 10);
while (C == T || C == B || C == P || C == K || C == L)
{
    C = rnd.Next(1, 10);
    bool orientationC = Random;
}

//začátek viditelného programu

Console.WriteLine("Vítej ve hře. Na pole 10x10 si vyskládej: 1. Letadlovou loď 5x1, 2. Bitevní loď 4x1, 3. Křižník 3x1x, 4. Ponorka 3x1, 5. Torpédoborec 2x1 a 6. Člun 1x1.");
Console.ReadKey();

int shipx = 0;
int shipy = 0;

//tvorba pole Usera
for (int i = 0; i < 5; i++) ;
{
    Console.WriteLine("POlož první loď. Napiště nejdříc souřadnici X (číslo)");
    Console.ReadLine();
    if (Console.Readline() != 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9 || 10)
    {
        while (true)
        {
            Console.WriteLine("Souřadnice jsou od 1 do 10");

            Console.ReadLine();
            break;
        }
    }
    else shipx = Console.ReadLine(Convert.ToChar());

    Console.WriteLine("Napiš souřadnici Y");
    Console.ReadLine();
    if (Console.Readline() != 1 || 2 || 3 || 4 || 5 || 6 || 7 || 8 || 9 || 10)
    {
        while (true)
        {
            Console.WriteLine("Souřadnice jsou od 1 do 10");

            Console.ReadLine();
            break;
        }
    }
    else shipy = Console.ReadLine(Convert.ToChar());

    myBattlefield[shipx, shipy] = ships[i];

}


int countdownUser = 18;
int countdownPC = 18;

//když countdown bude 0, hra končí

while (countdownPC != 0 || countdownUser != 0)
{
    //User shoots

    int x = 0; // souřadnice 1

    int y = 0; // řádek

    Console.WriteLine("Jste na tahu. vyberte, kam budete střílet. Napište nejdřív souřadnici X (číslo pole)");
    x = Console.ReadLine(Convert.ToInt32());

    Console.WriteLine("Zapište souřadnici Y");
    y = Console.ReadLine(Convert.ToInt32());

    if (computerBattlefield[x, y] = /* loď */ )
    {
        computerBattlefield[x, y] = 'X';
        countdownUser--;
    }
    else
        computerBattlefield[x, y] = '0';

    Console.Write(myView);

    int a = rnd.Next(1, 10);
    int z = rnd.Next(1, 10);

    if (myBattlefield[a, z] = 'L' || 'T' || 'C' || 'K' || 'P')
    {
        myBattlefield[a, z] = 'X';
        countdownUser--;

        //pc shoots on one of the squares next to the previous one
    }

    Console.Write(myBattlefield);

    if (countdownUser == 0 || countdownPC == 0)
    {
        Console.WriteLine("Konec hry.");
        if (countdownPC == 0)
        {
            Console.WriteLine("Vyhráli jste.");
        }
        else
            Console.WriteLine("Prohráli jste.");
        Console.ReadKey();
    }
    
    // konec hry
    // omlouvám se, že jsi tohle musel číst.
}
