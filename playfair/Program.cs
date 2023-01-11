using playfair;

PlayfairKodolo playfairKodolo = new(@"..\..\..\RES\kulcstabla.txt");

//6. feladat:
Console.Write("6. feladat - Kérek egy nagybetűt: ");
char karakter = char.Parse(Console.ReadLine()!);

(int sorIndex, int oszlopIndex) = playfairKodolo.Index(karakter);
Console.WriteLine($"A karakter sorának indexe: {sorIndex}");
Console.WriteLine($"A karakter oszlopának indexe: {oszlopIndex}");

//8. feladat:
Console.Write("8. feladat - Kérek egy karakterpárt: ");
string karakterpar = Console.ReadLine()!;
Console.WriteLine($"Kódolva: {playfairKodolo.KodolBetupar(karakterpar)}");
