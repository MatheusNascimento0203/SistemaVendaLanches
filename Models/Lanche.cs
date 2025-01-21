using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {   
        [Key]
        public int Id { get; set; }

        [StringLength (100, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} caracteres")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [MinLength (20, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength (200, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O descrição detalhada do lanche deve ser informada")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho Imagem Miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}