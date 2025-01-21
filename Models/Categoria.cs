using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [StringLength (100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome da Categoria")]
        public string CategoriaNome  { get; set; }
        
        [StringLength (200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição da categoria")]
        public string Descricao { get; set; } 

        public List<Lanche> Lanches { get; set;}

    }
}