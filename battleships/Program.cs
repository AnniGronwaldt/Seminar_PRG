
using System.Data;

static void Print2DArray(char[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Varování: blbuvzdornost je sama trochu blbá

// tvoření polí:

char[,] computerBattlefield = {
{'0','1','2','3','4','5','6','7','8','9','X'},
{'A','-','-','-','-','-','-','-','-','-','-'},
{'B','-','-','-','-','-','-','-','-','-','-'},
{'C','-','-','-','-','-','-','-','-','-','-'},
{'D','-','-','-','-','-','-','-','-','-','-'},
{'E','-','-','-','-','-','-','-','-','-','-'},
{'F','-','-','-','-','-','-','-','-','-','-'},
{'G','-','-','-','-','-','-','-','-','-','-'},
{'H','-','-','-','-','-','-','-','-','-','-'},
{'I','-','-','-','-','-','-','-','-','-','-'},
{'J','-','-','-','-','-','-','-','-','-','-'}
};

char[,] myBattlefield = {
{'0','1','2','3','4','5','6','7','8','9','X'},
{'A','-','-','-','-','-','-','-','-','-','-'},
{'B','-','-','-','-','-','-','-','-','-','-'},
{'C','-','-','-','-','-','-','-','-','-','-'},
{'D','-','-','-','-','-','-','-','-','-','-'},
{'E','-','-','-','-','-','-','-','-','-','-'},
{'F','-','-','-','-','-','-','-','-','-','-'},
{'G','-','-','-','-','-','-','-','-','-','-'},
{'H','-','-','-','-','-','-','-','-','-','-'},
{'I','-','-','-','-','-','-','-','-','-','-'},
{'J','-','-','-','-','-','-','-','-','-','-'}
};

char[,] myView = {
{'0','1','2','3','4','5','6','7','8','9','X'},
{'A','-','-','-','-','-','-','-','-','-','-'},
{'B','-','-','-','-','-','-','-','-','-','-'},
{'C','-','-','-','-','-','-','-','-','-','-'},
{'D','-','-','-','-','-','-','-','-','-','-'},
{'E','-','-','-','-','-','-','-','-','-','-'},
{'F','-','-','-','-','-','-','-','-','-','-'},
{'G','-','-','-','-','-','-','-','-','-','-'},
{'H','-','-','-','-','-','-','-','-','-','-'},
{'I','-','-','-','-','-','-','-','-','-','-'},
{'J','-','-','-','-','-','-','-','-','-','-'}
};

// Letadlová loď - 5x1
// Bitevní loď - 4x1
// Křižník - 3x1
// Ponorka - 3x1
// Torpédoborec - 2x1
// Člun - 1x1

// tvorba pole PC

bool lL = false;
bool bL = false;
bool k = false;
bool p = false;
bool t = false;
bool c = false;

while (lL == false)
{
    Random LL1 = new Random();
    int L1 = LL1.Next(1, 10);
    Random LL2 = new Random();
    int L2 = LL2.Next(1, 10);
    Random random = new Random();
    bool orientationL = random.Next(2) == 0;
    if (computerBattlefield[L1, L2] != '-')
    {
        while (computerBattlefield[L1, L2] != '-')
        {
            L1 = LL1.Next(1, 10);
            L2 = LL2.Next(1, 10);
            orientationL = random.Next(2) == 0;
        }
    }
    else /*polož blok lodi*/
    {
        if (orientationL == true)
        {
            for (int i = 0; i < 5; i++)
            {
                computerBattlefield[L1, L2 + i] = 'L';
                char[] valuesToCheck = { 'L', 'L', 'L', 'L', 'L' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        lL = false;
                    }
                    else
                    {
                        lL = true;
                    }
                }

            }
        }
        else if (orientationL == false)
        {
            for (int i = 0; i < 5; i++)
            {
                computerBattlefield[L1 + i, L2] = 'L';
                char[] valuesToCheck = { 'L', 'L', 'L', 'L', 'L' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        lL = false;
                    }
                    else
                    {
                        lL = true;
                    }
                }
            }

        }

        
    }
}

while (bL == false)
{
    Random BB1 = new Random();
    int B1 = BB1.Next(1, 10);
    Random BB2 = new Random();
    int B2 = BB2.Next(1, 10);
    Random random2 = new Random();
    bool orientationB = random2.Next(2) == 0;
    if (computerBattlefield[B1, B2] != '-')
    {
        while (computerBattlefield[B1, B2] != '-')
        {
            B1 = BB1.Next(1, 10);
            B2 = BB2.Next(1, 10);
            orientationB = random2.Next(2) == 0;
        }
    }
    else /*polož blok lodi*/
    {
        if (orientationB == true)
        {
            for (int i = 0; i < 4; i++)
            {
                computerBattlefield[B1 + i, B2] = 'B';
                char[] valuesToCheck = { 'B', 'B', 'B', 'B' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        bL = false;
                    }
                    else
                    {
                        bL = true;
                    }
                }
            }
        }
        else if (orientationB == false)
        {
            for (int i = 0; i < 4; i++)
            {
                computerBattlefield[B1, B2 + i] = 'B';
                char[] valuesToCheck = { 'B', 'B', 'B', 'B' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        bL = false;
                    }
                    else
                    {
                        bL = true;
                    }
                }
            }
        }
    }
    
}

while (k == false)
{
    Random KK1 = new Random();
    int K1 = KK1.Next(1, 10);
    Random KK2 = new Random();
    int K2 = KK2.Next(1, 10);
    Random random3 = new Random();
    bool orientationK = random3.Next(2) == 0;
    if (computerBattlefield[K1, K2] != '-')
    {
        while (computerBattlefield[K1, K2] != '-')
        {
            K1 = KK1.Next(1, 10);
            K2 = KK2.Next(1, 10);
            orientationK = random3.Next(2) == 0;
        }
    }
    else /*polož blok lodi*/
    {
        if (orientationK == true)
        {
            for (int i = 0; i < 3; i++)
            {
                computerBattlefield[K1 + i, K2] = 'K';
                char[] valuesToCheck = { 'K', 'K', 'K' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        k = false;
                    }
                    else
                    {
                        k = true;
                    }

                }
            }
        }
        else if (orientationK == true)
        {
            for (int i = 0; i < 3; i++)
            {
                computerBattlefield[K1, K2 + i] = 'K';
                char[] valuesToCheck = { 'K', 'K', 'K' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        k = false;
                    }
                    else
                    {
                        k = true;
                    }
                }
            }
        }
    
    }
}

while (p == false)
{
    Random PP1 = new Random();
    int P1 = PP1.Next(1, 10);
    Random PP2 = new Random();
    int P2 = PP2.Next(1, 10);
    Random random4 = new Random();
    bool orientationP = random4.Next(2) == 0;
    if (computerBattlefield[P1, P2] != '-')
    {
        while (computerBattlefield[P1, P2] != '-')
        {
            P1 = PP1.Next(1, 10);
            P2 = PP2.Next(1, 10);
            orientationP = random4.Next(2) == 0;
        }
    }
    else /*polož blok lodi*/
    {
        if (orientationP == true)
        {
            for (int i = 0; i < 3; i++)
            {
                computerBattlefield[P1 + i, P2] = 'P';
                char[] valuesToCheck = { 'P', 'P', 'P' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        p = false;
                    }
                    else
                    {
                        p = true;
                    }
                }
            }
        }
        else if (orientationP == false)
        {
            for (int i = 0; i < 3; i++)
            {
                computerBattlefield[P1, P2 + i] = 'P';
                char[] valuesToCheck = { 'P', 'P', 'P' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        p = false;
                    }
                    else
                    {
                        p = true;
                    }
                }
            }
        }
    }
    
}

while (t == false)
{
    Random TT1 = new Random();
    int T1 = TT1.Next(1, 10);
    Random TT2 = new Random();
    int T2 = TT2.Next(1, 10);
    Random random5 = new Random();
    bool orientationT = random5.Next(2) == 0;
    if (computerBattlefield[T1, T2] != '-')
    {
        while (computerBattlefield[T1, T2] != '-')
        {
            T1 = TT1.Next(1, 10);
            T2 = TT2.Next(1, 10);
            orientationT = random5.Next(2) == 0;
        }
    }
    else /*polož blok lodi*/
    {
        if (orientationT == true)
        {
            for (int i = 0; i < 2; i++)
            {
                computerBattlefield[T1 + i, T2] = 'T';
                char[] valuesToCheck = { 'T', 'T' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        t = false;
                    }
                    else
                    {
                        t = true;
                    }
                }
            }
        }
        else if (orientationT == false)
        {
            for (int i = 0; i < 2; i++)
            {
                computerBattlefield[T1, T2 + i] = 'T';
                char[] valuesToCheck = { 'T', 'T' };
                foreach (char value in valuesToCheck)
                {
                    if (!Array.Exists(valuesToCheck, computerBattlefield => computerBattlefield == value))
                    {
                        t = false;
                    }
                    else
                    {
                        t = true;
                    }
                }
            }
        }
    }
    
}

while (c == false)
{
    Random CC1 = new Random();
    int C1 = CC1.Next(1, 10);
    Random CC2 = new Random();
    int C2 = CC2.Next(1, 10);
    if (computerBattlefield[C1, C2] != '-')
    {
        while (computerBattlefield[C1, C2] != '-')
        {
            C1 = CC1.Next(1, 10);
            C2 = CC2.Next(1, 10);
            break;
        }
    }
    else /*polož blok lodi*/
    {
        computerBattlefield[C1, C2] = 'C';
        c = true;
    }
    computerBattlefield[C1, C2] = 'C';
    c = true;
}

//začátek viditelného programu

Console.WriteLine("Vítej ve hře. Na pole 10x10 si vyskládej: 1. Letadlovou loď 5x1, 2. Bitevní loď 4x1, 3. Křižník 3x1x, 4. Ponorka 3x1, 5. Torpédoborec 2x1 a 6. Člun 1x1.");
Console.WriteLine("Stistkni jakoukoliv klávesu.");
Console.ReadKey();

int shipx = 0;
int shipy = 0;

//tvorba pole Usera
//POLOŽENÍ LETADLOVÉ LODĚ
Console.WriteLine("Polož první loď (Letadlovou loď). Napiš nejdřív souřadnici X (Písmeno, zadej ale v čísle!) pro horní levou souřadnici.");
int karel = Convert.ToInt32(Console.ReadLine());
if (karel > 0 || karel < 11)
{
    shipx = karel;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (karel > 1 || karel < 10)
        {
            shipx = karel;
            break;
        }  
    }
}
Console.WriteLine("Napiš souřadnici Y (číslo).");
int jantar = Convert.ToInt32(Console.ReadLine());
if (jantar > 0 || jantar < 11)
{
    
    shipy = jantar;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (jantar > 1 || jantar < 10)
        {
            shipy = jantar;
            break;
        }   
    }
}
Console.WriteLine("Chceš mít loď orientovanou horizontálně nebo vertikálně? (Horizontánlě = H, Vertikálně = V)");
char kartel = Convert.ToChar(Console.ReadLine());
if (kartel == 'H')
{
    for (int j = 0; j < 5; j++)
    {
        myBattlefield[shipx, shipy + j] = 'L';
    }
}
else if (kartel == 'V')
{
    for (int j = 0; j < 5; j++)
    {
        myBattlefield[shipx + j, shipy] = 'L';
    }
}
else
{
    while (kartel != 'V' || kartel != 'H')
    {
        Console.WriteLine("Napiš H nebo V");
        Console.ReadLine();
        if (kartel == 'V' || kartel == 'H')
        {
            if (kartel == 'H')
            {
                for (int j = 0; j < 5; j++)
                {
                    myBattlefield[shipx, shipy + j] = 'L';
                }
            }
            else if (kartel == 'V')
            {
                for (int j = 0; j < 5; j++)
                {
                    myBattlefield[shipx + j, shipy] = 'L';
                }
            }
        }
    }

}

Print2DArray(myBattlefield);
Console.WriteLine();

//POKLÁDÁME BITVENÍ LOĎ
Console.WriteLine("Teď polož bitevní loď. Napiš nejdřív souřadnici X (Písmeno, zadej ale v čísle!) pro horní levou souřadnici.");
int kytka = Convert.ToInt32(Console.ReadLine());
if (kytka > 0 || kytka < 11)
{
    shipx = kytka;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (kytka > 1 || kytka < 10)
        {
            shipx = kytka;
            break;
        }  
    }
}
Console.WriteLine("Napiš souřadnici Y (číslo).");
int mor = Convert.ToInt32(Console.ReadLine());
if (mor > 0 || mor < 11)
{
    shipy = mor;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (mor > 1 || mor < 10)
        {
            shipy = mor;
            break;
        }
    }
    
}
Console.WriteLine("Chceš mít loď orientovanou horizontálně nebo vertikálně? (Horizontánlě = H, Vertikálně = V)");
char mozek = Convert.ToChar(Console.ReadLine());
if (mozek == 'H')
{
    for (int j = 0; j < 4; j++)
    {
        myBattlefield[shipx, shipy + j] = 'B';
    }
}
else if (mozek == 'V')
{
    for (int j = 0; j < 4; j++)
    {
        myBattlefield[shipx + j, shipy] = 'B';
    }
}
else
{
    while (mozek != 'V' || mozek != 'H')
    {
        Console.WriteLine("Napiš H nebo V");
        Console.ReadLine();
        if (mozek == 'V' || mozek == 'H')
        {
            break;
        }
    }

}

Print2DArray(myBattlefield);
Console.WriteLine();

//POKLÁDÁME KŘIŽNÍK
Console.WriteLine("Teď polož křižník. Napiš nejdřív souřadnici X (Písmeno, zadej ale v čísle!) pro horní levou souřadnici.");
int vyvarZKrtka = Convert.ToInt32(Console.ReadLine());
if (vyvarZKrtka > 0 || vyvarZKrtka < 11)
{
    shipx = vyvarZKrtka;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (vyvarZKrtka > 0 || vyvarZKrtka < 11)
        {
            shipx = vyvarZKrtka;
            break;
        }
    }
}
Console.WriteLine("Napiš souřadnici Y (číslo).");
int jatra = Convert.ToInt32(Console.ReadLine());
if (jatra > 0 || jatra < 11)
{
    shipy = jatra;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (jatra > 0 || jatra < 11)
        {
            shipy = jatra;
            break;
        }   
    }
}
Console.WriteLine("Chceš mít loď orientovanou horizontálně nebo vertikálně? (Horizontánlě = H, Vertikálně = V)");
char jetel = Convert.ToChar(Console.ReadLine());
if (jetel == 'H')
{
    for (int j = 0; j < 3; j++)
    {
        myBattlefield[shipx, shipy + j] = 'K';
    }
}
else if (jetel == 'V')
{
    for (int j = 0; j < 3; j++)
    {
        myBattlefield[shipx + j, shipy] = 'K';
    }
}
else
{
    while (jetel != 'V' || jetel != 'H')
    {
        Console.WriteLine("Napiš H nebo V");
        Console.ReadLine();
        if (jetel == 'V' || jetel == 'H')
        {
            break;
        }
    }
}

Print2DArray(myBattlefield);
Console.WriteLine();

//POKLÁDÁME PONORKU
Console.WriteLine("Teď polož ponorku. Napiš nejdřív souřadnici X (Písmeno, zadej ale v čísle!) pro horní levou souřadnici.");
int vajgl = Convert.ToInt32(Console.ReadLine());
if (vajgl > 0 || vajgl < 11)
{
    shipx = vajgl;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (vajgl > 0 || vajgl < 11)
        {
            shipx = vajgl;
            break;
        }  
    } 
}
Console.WriteLine("Napiš souřadnici Y (číslo).");
int minus = Convert.ToInt32(Console.ReadLine());
if (minus > 0 || minus < 11)
{
    shipy = minus;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (minus > 0 || minus < 11)
        {
            shipy = minus; 
            break;
        } 
    }
}
Console.WriteLine("Chceš mít loď orientovanou horizontálně nebo vertikálně? (Horizontánlě = H, Vertikálně = V)");
char kartac = Convert.ToChar(Console.ReadLine());
if (kartac == 'H')
{
    for (int j = 0; j < 3; j++)
    {
        myBattlefield[shipx, shipy + j] = 'P';
    }
}
else if (kartac == 'V')
{
    for (int j = 0; j < 3; j++)
    {
        myBattlefield[shipx + j, shipy] = 'P';
    }
}
else
{
    while (kartac != 'V' || kartac != 'H')
    {
        Console.WriteLine("Napiš H nebo V");
        Console.ReadLine();
        if (kartac == 'V' || kartac == 'H')
        {
            break;
        }
    }
}

Print2DArray(myBattlefield);
Console.WriteLine();

//POKLÁDÁME TORPÉDOBOREC
Console.WriteLine("Teď polož torpédoborec. Napiš nejdřív souřadnici X (Písmeno, zadej ale v čísle!) pro horní levou souřadnici.");
int triangl = Convert.ToInt32(Console.ReadLine());
if (triangl > 0 || triangl < 11)
{
    shipx = triangl;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (triangl > 1 || triangl < 10)
        {
            shipx = triangl;
            break;
        } 
    }
}
Console.WriteLine("Napiš souřadnici Y (číslo).");
int zaba = Convert.ToInt32(Console.ReadLine());
if (zaba > 0 || zaba < 11)
{
    shipy = zaba;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (zaba > 0 || zaba < 11)
        {
            shipy = zaba;
            break;
        }   
    }
}
Console.WriteLine("Chceš mít loď orientovanou horizontálně nebo vertikálně? (Horizontánlě = H, Vertikálně = V)");
char spadlaKachna = Convert.ToChar(Console.ReadLine());
if (spadlaKachna == 'H')
{
    for (int j = 0; j < 2; j++)
    {
        myBattlefield[shipx, shipy + j] = 'T';
    }
}
else if (spadlaKachna == 'V')
{
    for (int j = 0; j < 2; j++)
    {
        myBattlefield[shipx + j, shipy] = 'T';
    }
}
else
{
    while (spadlaKachna != 'V' || spadlaKachna != 'H')
    {
        Console.WriteLine("Napiš H nebo V");
        Console.ReadLine();
        if (spadlaKachna == 'V' || spadlaKachna == 'H')
        {
            break;
        }
    }
}

Print2DArray(myBattlefield);
Console.WriteLine();

Console.WriteLine("A teď polož poslední loď - člun (má jen jedno pole");
Console.WriteLine("Napiš první souřadnici X (Písmeno, zadej ale číslo!)");
int clun1 = Convert.ToInt32(Console.ReadLine());
if (clun1 > 0 || clun1 < 11)
{
    shipx = clun1;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (clun1 > 0 || clun1 < 11)
        {
            shipx = clun1;
            break;
        }  
    }
}
Console.WriteLine("Napiš souřadnici Y (číslo).");
int clun2 = Convert.ToInt32(Console.ReadLine());
if (clun2 > 0 || clun2 < 11)
{
    shipy = clun2;
}
else
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10");
        Console.ReadLine();
        if (clun2 > 0 || clun2 < 11)
        {
            shipy = clun2;
            break;
        }
    }
}
myBattlefield[shipx, shipy] = 'C';

Print2DArray(myBattlefield);
Console.WriteLine();

Console.WriteLine("Paráda! Teď máš rozmístěné své loďe. Stiskni jakoukoliv klávesu pro začátek hry.");
Console.ReadKey();

int countdownUser = 18;
int countdownPC = 18;

//když countdown bude 0, hra končí

while (countdownPC != 0 || countdownUser != 0)
{
    //User shoots

    int x = 0; // souřadnice 1

    int y = 0; // řádek

    Console.WriteLine("Jste na tahu. vyberte, kam budete střílet. Napište nejdřív souřadnici X (vertikální/písmeno, zadej číslo.)");
    x = Convert.ToInt32(Console.ReadLine());
    if (x > 1 || x < 10)
    {
        x = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        while (true)
        {
            Console.WriteLine("Souřadnice jsou od 1 do 10.");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 0 || x > 11)
            {
                break;
            }
        }
    }

    Console.WriteLine("Zapište souřadnici Y (horizontální).");
    y = Convert.ToInt32(Console.ReadLine());
    if (y !> 0 && y !< 11)
    {
        y = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        while (true)
        {
            Console.WriteLine("Souřadnice jsou od 1 do 10.");
            y = Convert.ToInt32(Console.ReadLine());
            if (x < 0 || x > 11)
            {
                break;
            }
        }
    }


    if (computerBattlefield[x, y] != '-')
    {
        computerBattlefield[x, y] = 'X';
        myView[x, y] = 'X';
        countdownUser--;
    }
    else
    {
        myView[x, y] = '0';
    }

    Print2DArray(myView);

    //computer shoots

    Random bullet1 = new Random();
    int a = bullet1.Next(1, 10);
    Random bullet2 = new Random();
    int z = bullet2.Next(1, 10);

    if (myBattlefield[a, z] != '-')
    {
        myBattlefield[a, z] = 'X';
        countdownUser--;
    }
    else
    {
        Console.WriteLine("Jupí! Tvé lodě se vyhnuli zásau!");
    }

    Print2DArray(myBattlefield);

    if (countdownUser == 0 || countdownPC == 0)
    {
        Console.WriteLine("Konec hry.");
        if (countdownPC == 0)
        {
            Console.WriteLine("Gratuluji, Vyhrál jsi!");
            Console.WriteLine("Stiskni jakoukoliv klávesu pro ukončení hry!");
            Print2DArray(computerBattlefield);
            Console.ReadKey();
            break;
        }
        else if (countdownUser == 0)
        { 
            Console.WriteLine("Bohužel jsi prohrál :(");
            Console.WriteLine("Stiskni jakoukoliv klávesu pro ukončení hry!");
            Print2DArray(computerBattlefield);
            Console.ReadKey();
            break;
        }
        else
        {
            Console.WriteLine("Remíza? jaká to náhoda!");
            Console.WriteLine("Stiskni jakoukoliv klávesu pro ukončení hry!");
            Print2DArray(computerBattlefield);
            Console.ReadKey();
            break;
        }
    }

    // konec hry
    // omlouvám se, že jsi tohle musel číst.
    // fyi měla jsem tady v jednu dobu 1069 errorů kvůli špatně naformátovaným charům. lol.

    //Credits:
    // https://aspdotnethelp.com/check-if-a-csharp-string-array-contains-multiple-values/
    //2DArrayPlayground
}
