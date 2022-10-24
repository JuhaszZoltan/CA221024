Tombok();


static void Tombok()
{
    Random rnd = new();

    int[] szamok = new int[10];
    char[] betuk = new char[] { 'a', 'b', 'c'};
    string[] karakterlancok = { "kutya", "cica", "hörcsög" };

    Console.WriteLine(karakterlancok[1]);
    Console.WriteLine(betuk.Length);

    for (int i = 0; i < szamok.Length; i++)
    {
        szamok[i] = rnd.Next(10, 100);
    }

    for (int i = 0; i < szamok.Length; i++)
    {
        Console.Write($"{szamok[i]} ");
    }
    Console.Write('\n');

    //NEM FOG MŰKÖDNI:
    //foreach (var szam in szamok)
    //{
    //    szam = rnd.Next(10, 100);
    //}

    foreach (var szam in szamok)
    {
        Console.Write($"{szam} ");
    }
    Console.Write('\n');

    bool vanBenne42 = szamok.Contains(42);
    Console.WriteLine(vanBenne42 ? "van benne 42" : "nincs benne 42");

    int osszeg = szamok.Sum();
    Console.WriteLine($"tömb elemeinek összege: {osszeg}");

    //megmondja, hogy a <array> tömbben a <value> érték hányas indexű helyen van
    //HA NINCS BENNE, akkor -1-et ad vissza!
    int index = Array.IndexOf(szamok, 30);
    Console.WriteLine($"a 30-as szám indexe: {index}");

    int mini = Array.IndexOf(szamok, szamok.Min());
    Console.WriteLine($"legkisebb elem indexe: {mini}");

    Array.Sort(szamok);
    Array.Reverse(szamok);

    Array.Resize(ref szamok, 15);

    

    foreach (var szam in szamok)
    {
        Console.Write($"{szam} ");
    }
    Console.Write('\n');


    List<int> szamLista = szamok.ToList();

    szamLista.Add(10);
}

static void ErtekEsReferencia()
{
    // ÉRTÉK típusú működés:
    int x = 10;
    int y = x;
    y -= 5;
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");

    //REFERENCIA típusú működés
    int[] e = new int[1];
    e[0] = 10;
    int[] f = e;
    f[0] -= 5;

    Console.WriteLine($"e[0] = {e[0]}");
    Console.WriteLine($"f[0] = {f[0]}");
}