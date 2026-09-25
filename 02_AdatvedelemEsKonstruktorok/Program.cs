using _02_AdatvedelemEsKonstruktorok;
Bankszamla Anna = new Bankszamla("87654321-87654321-87654321");
Bankszamla Bela = new Bankszamla("12345678-12345678-12345678", 100000, 50000);
Anna.Befizetes(10000);
Bela.Kivetel(20000);
Console.WriteLine($"Anna számlaszáma: {Anna.Szamlaszam}, egyenlege: {Anna.Egyenleg} Ft, hitelkerete: {Anna.HitelKeret} Ft");
Console.WriteLine($"Béla számlaszáma: {Bela.Szamlaszam}, egyenlege: {Bela.Egyenleg} Ft, hitelkerete: {Bela.HitelKeret} Ft");