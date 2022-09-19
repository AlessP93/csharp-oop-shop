
Prodotto UtenteProdotto = new Prodotto();

UtenteProdotto.codice = new Random().Next(0, 100000000);
UtenteProdotto.nome = Console.ReadLine();
UtenteProdotto.descrizione = Console.ReadLine();
UtenteProdotto.prezzo = Convert.ToInt32(Console.ReadLine());
UtenteProdotto.iva = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(UtenteProdotto.codice);
Console.WriteLine("inserisci un nome ", UtenteProdotto.nome);
Console.WriteLine("inserisci un descrizione ", UtenteProdotto.descrizione);
Console.WriteLine("inserisci l' iva di 11 numeri ", UtenteProdotto.iva);


//crea un prodotto caratterizzato da:
public class Prodotto
{
    public int codice;
    public string nome;
    public string descrizione;
    public double prezzo;
    public int iva;
}

