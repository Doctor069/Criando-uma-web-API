using System.ComponentModel.DataAnnotations;

namespace NET_6_criando_uma_web.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "Titulo do filme é obrigatorio")] // Required quer dizer que tal campo tem que ser obrigatorio atender tais medidads
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Genero obrigaorio ser preenchido")] // ErrorMessage - caso nao seja preenchido aparecerar
        [StringLength(50, ErrorMessage = "O filme deve conter no maximo 50 caracteres")]
        public string Genero { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage = "A duração tem que ser entre 70 e 600 minutos")] // Range - entre 70 e 600 minutos é permitido
        public int Duracao { get; set; }
    }
}
