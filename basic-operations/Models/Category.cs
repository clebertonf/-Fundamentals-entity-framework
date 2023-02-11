using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basic_operations.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Deixa explicito que o banco irá gera a chave primaria Id
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
