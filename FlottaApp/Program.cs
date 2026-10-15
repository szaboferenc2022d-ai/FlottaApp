using FlottaApp;

List<Jarmu> jarmuvek = new List<Jarmu>();



int hibasSorokSzama = 0;

foreach (string sor in File.ReadAllLines("jarmuvek.csv").Skip(1))
{
    string[] adatok = sor.Split(';');
    if (adatok.Length != 4)
    {
        hibasSorokSzama++;
        continue;
    }
    string tipus = adatok[0].Trim();
    string rendszam = adatok[1].Trim();
    if (!int.TryParse(adatok[2].Trim(), out int alapar))
    {
        hibasSorokSzama++;
        continue;
    }
    var extra = adatok[3].Trim();

    if (string.IsNullOrWhiteSpace(tipus) || string.IsNullOrWhiteSpace(rendszam))
    {
        hibasSorokSzama++;
        continue;
    }
    jarmuvek.Add(new Jarmu(tipus, rendszam, alapar, extra));
}

int Jarmu = 0;
int Teherauto = 0;

foreach (Jarmu jarmu in jarmuvek)
{
    if (jarmu.tipus == "J")
    {
        Jarmu++;
    }
    else if (jarmu.tipus == "T")
    {
        Teherauto++;
    }
}

Console.WriteLine("--- FLOTTA ELEMZÉS ---");
Console.WriteLine($"Sikeresen beolvasott járművek: {jarmuvek.Count} db");
Console.WriteLine($"Kiszűrt hibás sorok száma: {hibasSorokSzama} db");

Console.WriteLine("--- JÁRMŰVEK LISTÁJA ---");
foreach (Jarmu jarmu in jarmuvek)
{
    Console.WriteLine(jarmu);
}
