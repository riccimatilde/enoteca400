using System.ComponentModel.DataAnnotations;

public class Login
{
    [Key]
    public int ID { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}