using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagonal.Features.Note.Domain.Models
{
    public class NoteModel
    {
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual UserModel User { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryModel Category { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

    }
}