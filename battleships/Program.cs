
string[,] computerBattlefield = new string[11, 11];
string[,] myBattlefield = new string[11, 11];
string[,] myView = new string[11, 11];

computerBattlefield[0, 1] = "1";
computerBattlefield[0, 2] = "2";
computerBattlefield[0, 3] = "3";
computerBattlefield[0, 4] = "4";
computerBattlefield[0, 5] = "5";
computerBattlefield[0, 6] = "6";
computerBattlefield[0, 7] = "7";
computerBattlefield[0, 8] = "8";
computerBattlefield[0, 9] = "9";
computerBattlefield[0, 10] = "10";
computerBattlefield[1, 0] = "A";
computerBattlefield[2, 0] = "B";
computerBattlefield[3, 0] = "C";
computerBattlefield[4, 0] = "D";
computerBattlefield[5, 0] = "E";
computerBattlefield[6, 0] = "F";
computerBattlefield[7, 0] = "G";
computerBattlefield[8, 0] = "H";
computerBattlefield[9, 0] = "I";
computerBattlefield[10, 0] = "J";

myBattlefield[0, 1] = "1";
myBattlefield[0, 2] = "2";
myBattlefield[0, 3] = "3";
myBattlefield[0, 4] = "4";
myBattlefield[0, 5] = "5";
myBattlefield[0, 6] = "6";
myBattlefield[0, 7] = "7";
myBattlefield[0, 8] = "8";
myBattlefield[0, 9] = "9";
myBattlefield[0, 10] = "10";
myBattlefield[1, 0] = "A";
myBattlefield[2, 0] = "B";
myBattlefield[3, 0] = "C";
myBattlefield[4, 0] = "D";
myBattlefield[5, 0] = "E";
myBattlefield[6, 0] = "F";
myBattlefield[7, 0] = "G";
myBattlefield[8, 0] = "H";
myBattlefield[9, 0] = "I";
myBattlefield[10, 0] = "J";

myView[0, 1] = "1";
myView[0, 2] = "2";
myView[0, 3] = "3";
myView[0, 4] = "4";
myView[0, 5] = "5";
myView[0, 6] = "6";
myView[0, 7] = "7";
myView[0, 8] = "8";
myView[0, 9] = "9";
myView[0, 10] = "10";
myView[1, 0] = "A";
myView[2, 0] = "B";
myView[3, 0] = "C";
myView[4, 0] = "D";
myView[5, 0] = "E";
myView[6, 0] = "F";
myView[7, 0] = "G";
myView[8, 0] = "H";
myView[9, 0] = "I";
myView[10, 0] = "J";

// Letadlová loď - 5x1
// Bitevní loď - 4x1
// Křižník - 3x1
// Ponorka - 3x1
// Torpédoborec - 2x1


// typy lodí

for 
{
    // cyklus pro tvoření pole PC

}


Console.WriteLine("Čus, Usere. Na pole 10x10 si vyskládej: 1 Letadlovou loď 5x1, 1x Bitevní loď 4x1, Křižník 3x1x, Ponorka 3x1 a Torpédoborec 2x1.");
Console.WriteLine("Nejdřív, polož letadlovou loď na souřadnici");

Console.ReadLine();

if (Readline != "[ 1 - 10], [1 - 10]") 
{
    while (true)
    {
        Console.WriteLine("Souřadnice jsou od 1 do 10, zapisují se ve formátu x,y");

        Console.ReadLine();
        break;
    }
}



//tvorba pole Usera

while (true)
{
    //User shoots

    int x = 0;
    int y = 0;

    Console.WriteLine("Vystřelte na souřadnice x,y");

    Console.ReadLine();

    Console.Write();

    //pc shoots

    int hit = 0;

    if (hit == 1)
    {
        //pc shoots on one of the squares next to the previous one
    }
}
