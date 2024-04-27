using Hexagonal.Features.Note.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Hexagonal.Features.Category.Domain.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }


    }
}