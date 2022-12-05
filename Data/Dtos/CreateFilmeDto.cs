using System.ComponentModel.DataAnnotations;

namespace FilmesAPI2.Data.Dtos;

public class CreateFilmeDto
{

    [Required(ErrorMessage = "Titulo é obrigatório")]
    public string Titulo { get; set; }

    [StringLength(20, ErrorMessage = "Genero precisa ter no maximo 20 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "Diretor é obrigatório"), StringLength(20, ErrorMessage = "Diretor precisa ter no maximo 20 caracteres")]
    public string Diretor { get; set; }

    [Range(1, 300, ErrorMessage = "Filme precisa ter duração máxima de 250 minutos")]
    public int Duracao { get; set; }

}
