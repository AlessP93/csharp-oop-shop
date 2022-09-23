
Prodotto UtenteProdotto = new Prodotto();

UtenteProdotto.SetCodice(new Random().Next(0, 100));
UtenteProdotto.SetNome("Iphone");
UtenteProdotto.SetDescrizione("Iphone 13 pro max 512gb black");
UtenteProdotto.SetPrezzo(1399);
UtenteProdotto.SetIva(22);

Console.WriteLine("Codice del prodotto");
Console.WriteLine(UtenteProdotto.GetCodice());
Console.WriteLine();
Console.WriteLine("Nome del prodotto");
Console.WriteLine(UtenteProdotto.GetNome());
Console.WriteLine();
Console.WriteLine("Descrizione del prodotto");
Console.WriteLine(UtenteProdotto.GetDescrizione());
Console.WriteLine();
Console.WriteLine("Prezzo del prodotto");
Console.WriteLine(UtenteProdotto.GetPrezzo() + "$");
Console.WriteLine();
Console.WriteLine("Iva del prodotto");
Console.WriteLine(UtenteProdotto.GetIva() + "%");
Console.WriteLine();
Console.WriteLine("Prodotto con iva");
Console.WriteLine(UtenteProdotto.functionIva());
Console.WriteLine();
Console.WriteLine("Codice + nome");
Console.WriteLine(UtenteProdotto.concatenazione());



