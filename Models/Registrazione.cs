using System.ComponentModel.DataAnnotations;

public class Registrazione
{
    [Key] 
    public int ID { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public virtual ICollection<Carrello> Carrellos { get; set; } = new List<Carrello>();
}