using System.ComponentModel.DataAnnotations;

namespace Api_iesb_backend.Domain;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public DateTime Datanascimento { get; set; }
    public string Sexo { get; set; }
    public string EstadoCivil { get; set; }
}
