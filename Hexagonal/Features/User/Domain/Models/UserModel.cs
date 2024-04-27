using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Note.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Hexagonal.Features.User.Domain.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public virtual ICollection<NoteModel> Notes { get; set; }
    }
}