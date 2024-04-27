using System.ComponentModel.DataAnnotations;

namespace Hexagonal.Features.Tag.Domain.Models
{
    public class TagModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

    }
}