using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Note.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagonal.Features.Category.Infrastructure
{
    [Table("Categories")]
    public class CategoryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        public CategoryEntity FromModel(CategoryModel model)
        {
            Id = model.Id;
            Name = model.Name;
            return this;
        }

        public CategoryModel ToModel()
        {
            return new CategoryModel
            {
                Id = Id,
                Name = Name,
            };
        }

        public void UpdatePropsFromModel(CategoryModel model)
        {
            Name = model.Name ?? Name;

        }


    }
}
