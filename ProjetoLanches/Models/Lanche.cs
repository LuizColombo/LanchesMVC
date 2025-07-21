using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLanches.Models
{
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição do Lanche")]
        [StringLength(200, MinimumLength = 20)]
        public string DescricaoCurta { get; set; }

        [Required]
        [Display(Name = "Descrição Detalhada do Lanche")]
        [StringLength(200, MinimumLength = 20)]
        public string DescricaoLonga { get; set; }

        [Required]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 999.00)]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, MinimumLength = 20)]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, MinimumLength = 20)]
        public string ImagemThumb { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
