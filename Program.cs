
//Prodotto UtenteProdotto = new Prodotto();

//UtenteProdotto.SetCodice(new Random().Next(0, 100));
//UtenteProdotto.SetNome("Iphone");
//UtenteProdotto.SetDescrizione("Iphone 13 pro max 512gb black");
//UtenteProdotto.SetPrezzo(1399);
//UtenteProdotto.SetIva(22);

//Console.WriteLine("Codice del prodotto");
//Console.WriteLine(UtenteProdotto.GetCodice());
//Console.WriteLine();
//Console.WriteLine("Nome del prodotto");
//Console.WriteLine(UtenteProdotto.GetNome());
//Console.WriteLine();
//Console.WriteLine("Descrizione del prodotto");
//Console.WriteLine(UtenteProdotto.GetDescrizione());
//Console.WriteLine();
//Console.WriteLine("Prezzo del prodotto");
//Console.WriteLine(UtenteProdotto.GetPrezzo() + "$");
//Console.WriteLine();
//Console.WriteLine("Iva del prodotto");
//Console.WriteLine(UtenteProdotto.GetIva() + "%");
//Console.WriteLine();
//Console.WriteLine("Prodotto con iva");
//Console.WriteLine(UtenteProdotto.functionIva());
//Console.WriteLine();
//Console.WriteLine("Codice + nome");
//Console.WriteLine(UtenteProdotto.concatenazione());



////crea un prodotto caratterizzato da:
//public class Prodotto
//{
//    private int codice;
//    private string nome;
//    private string descrizione;
//    private double prezzo;
//    private int iva;

//    // setter
//    public void SetCodice(int codice)
//    {
//        this.codice = codice;
//    }

//    public void SetNome(string nome)
//    {
//        this.nome = nome;
//    }

//    public void SetDescrizione(string descrizione)
//    {
//        this.descrizione = descrizione;
//    }

//    public void SetPrezzo(double prezzo)
//    {
//        this.prezzo = prezzo;
//    }

//    public void SetIva(int iva)
//    {
//        this.iva = iva;
//    }

//    //getter
//    public int GetCodice()
//    {
//        return codice;
//    }
//    public string GetNome()
//    {
//        return nome;
//    }
//    public string GetDescrizione()
//    {
//        return descrizione;
//    }

//    public double GetPrezzo()
//    {
//        return prezzo;
//    }

//    public int GetIva()
//    {
//        return iva;
//    }
//    //methods
//    public double functionIva()
//    {
//        return GetPrezzo() + (GetIva() / 100);
//    }
//    public string concatenazione()
//    {
//        return GetCodice() + " - " + GetNome();
//    }
//}



// ESERCIZIO CON CLASSE ASTRATTA

public class Prodotto
{
    public int Code { get; set; }
    public string Name { get; set; }    
    public string Description { get; set; }
    public string Price { get; set; }
    public string Iva { get; set; }

}
