
using System.Linq.Expressions;
string str = "";


int wahl = 0;
while (wahl!=7)
{
    try
    {
        Menu(ref wahl);
        switch (wahl)
        {
            case 1:
                stringverlangen(ref str);
                Leere(str);
                break;
            case 2:
                stringverlangen(ref str);
                zählen(str);
                break;
            case 3:
                stringverlangen(ref str);
                ohnileer(str);
                break;
            case 4:
                stringverlangen(ref str);
                Batman(str);
                break;
            case 5:
                stringverlangen(ref str);
                Batmantausch(str);
                break;
            case 6:
                stringverlangen(ref str);
                rückwärts(str);
                break;
            case 7: break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}




static void stringverlangen(ref string str)
{
    try
    {
        Console.Write($"Geben sie einen String ein: ");
        str = Console.ReadLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


static void Leere(string str)
{
    int k = 0;
    foreach (var item in str)
    {
        if(item==' ')
        {
            k++;
        }
    }
    Console.WriteLine($"Der Satz hat {k} Leerzeichen");
}


static void rückwärts(string str)
{
    string str2 = "";
    for (int i = str.Length-1; i>=0; i--)
    {
     str2+=str[i];
        
    }
    Console.WriteLine(str2);
}


static void zählen(string str)
{
    int a = 0, e=0, s=0;
    foreach (var item in str)
    {
        if (item == 'a'|| item == 'A')
        {
            a++;
        }
        if (item == 'e' || item == 'E')
        {
            e++;
        }
        if (item == 's' || item == 'S')
        {
            s++;
        }
    }
    Console.WriteLine($"Der Satz hatt {a} a/A\nsoviel e/E {e}\nund soviel s/S {s}");
}
static void ohnileer(string str)
{
    int k = 0;
    foreach (var item in str)
    {
        if (item == ' ')
        {
            k++;
        }
    }
    Console.WriteLine($"Der Satz hat {str.Length-k} zeichen ohne die leerzeichen");
}
static void Batman(string str)
{
    if (str.Contains("Batman")|| str.Contains("batman"))
    {
        Console.WriteLine($"Batman ist im satz vorhanden");
    }
    else
    {
        Console.WriteLine($"Batman ist nicht vorhanden");
    }
}
static void Batmantausch(string str)
{
    if (str.Contains("Batman"))
    {
        string str2 = str.Replace("Batman", "Ironman");
        Console.WriteLine(str2);
    }
    if (str.Contains("batman"))
    {
        string str2 = str.Replace("batman", "Ironman");
        Console.WriteLine(str2);
    }
    else
    {
        Console.WriteLine($"Batman ist nicht vorhanden");
    }
    
}
static void Menu(ref int wahl)
{
    Console.Write($"\tMenu\n");
    Console.WriteLine($"_______________________");
    Console.WriteLine($"1) Die leere Stellen zählen ");
    Console.WriteLine($"2) Die «a/A», «e/E» und «s/S» zählen    ");
    Console.WriteLine($"3) Die Anzahl der Buchstaben zählen (ohne leere Stellen)");
    Console.WriteLine($"4) Überprüfen ob Herr Batman im Text befinde");
    Console.WriteLine($"5) Den Namen «Batman» mit «Ironman» im Text ersetzen  ");
    Console.WriteLine($"6) Den eingegeben Text rückwärts anzeigen  ");
    Console.WriteLine($"7) Abbrechen");
    Console.Write($"Wahlen sie die Methode: ");
    wahl = Convert.ToInt32(Console.ReadLine());

    
}