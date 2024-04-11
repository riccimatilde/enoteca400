public class Carrello
{
    public int CarrelloId { get; set; }
    public string? NomeProdotto { get; set; }
    public decimal Prezzo { get; set; }
    public int Quantita { get; set; }
    public Registrazione? Registrazione { get; set; }
    public int RegistrazioneId { get; set; }
}

