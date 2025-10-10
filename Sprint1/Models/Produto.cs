using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1.Models
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

        [Display(Name = "URL da Imagem")]
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

        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public string Categoria { get; set; }

        public string? Idioma { get; set; }

        public decimal Avaliacao_media { get; set; } = 0;

        public int Numero_de_avaliacoes { get; set; } = 0;
    }
}