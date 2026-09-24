using _01_StatikusElemek;
Console.WriteLine($"Az átváltott 100 EUR értéke Forintban: {ValutaValto.EurToHuf(100)}");
Console.WriteLine($"Az átváltott 250 USD értéke Forintban: {ValutaValto.UsdToHuf(250)}");
Console.WriteLine($"Az összes átváltás száma: {ValutaValto.GetOsszesAtvaltas()}");