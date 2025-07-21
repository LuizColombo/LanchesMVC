using System.ComponentModel.DataAnnotations;

namespace ProjetoLanches.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100)]
        [Required]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200)]
        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
