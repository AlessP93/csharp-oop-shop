//crea un prodotto caratterizzato da:
public abstract Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private int iva;

    // setter
    public void SetCodice(int codice)
    {
        this.codice = codice;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }

    public void SetPrezzo(double prezzo)
    {
        this.prezzo = prezzo;
    }

    public void SetIva(int iva)
    {
        this.iva = iva;
    }

    //getter
    public int GetCodice()
    {
        return codice;
    }
    public string GetNome()
    {
        return nome;
    }
    public string GetDescrizione()
    {
        return descrizione;
    }

    public double GetPrezzo()
    {
        return prezzo;
    }

    public int GetIva()
    {
        return iva;
    }

    //methods
    public double functionIva()
    {
        return GetPrezzo() + (GetIva() / 100);
    }
    public string concatenazione()
    {
        return GetCodice() + " - " + GetNome();
    }
    public abstract void Stampa();
   
}



