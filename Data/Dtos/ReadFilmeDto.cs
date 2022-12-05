using System.ComponentModel.DataAnnotations;

namespace FilmesAPI2.Data.Dtos;

public class ReadFilmeDto
{
    
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public string Diretor { get; set; }
    public int Duracao { get; set; }
    public DateTime Hora_Consulta { get; set; } = DateTime.Now;
}
