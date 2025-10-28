using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Models
{
    public class Produto
    {
        public int Produto_ID { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(150, ErrorMessage = "O título não pode ter mais de 150 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "URL da Capa")]
        public string? Imagem_url { get; set; }

        [Required(ErrorMessage = "O campo Preço Original é obrigatório.")]
        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Preço Original")]
        public decimal Preco_original { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Preço com Desconto")]
        public decimal? Preco_descontado { get; set; }

        [Required(ErrorMessage = "O campo Estoque é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo.")]
        public int Estoque { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Peso { get; set; } 

        public string? Dimensoes { get; set; } 

        [Required(ErrorMessage = "O campo Condição é obrigatório.")]
        [Display(Name = "Condição")]
        public string Condicao_produto { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatório.")]
        [Display(Name = "Gênero")] 
        public string Categoria { get; set; } 

        public string? Idioma { get; set; }

        public decimal Avaliacao_media { get; set; } = 0;

        public int Numero_de_avaliacoes { get; set; } = 0;

        [Required(ErrorMessage = "O campo Plataforma é obrigatório.")]
        [Display(Name = "Plataforma")]
        public string Plataforma { get; set; } 

        [Display(Name = "Desenvolvedora")]
        public string? Desenvolvedora { get; set; }

        [Display(Name = "Publicadora")]
        public string? Publicadora { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime? DataLancamento { get; set; }

        [Display(Name = "Classificação Indicativa")] 
        public string? ClassificacaoIndicativa { get; set; }
    }
}