using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Infrastructure;
using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.NotesTags.Infrastructure;
using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Infrastructure;
using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagonal.Features.Note.Infrastructure
{
    [Table("Notes")]
    public class NoteEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual UserEntity User { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public virtual CategoryEntity Category { get; set; }


        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public NoteEntity FromModel(NoteModel model)
        {
            Id = model.Id;
            Title = model.Title;
            Content = model.Content;
            Created = model.Created;
            return this;
        }

        public NoteModel ToModel()
        {
            return new NoteModel
            {
                Id = Id,
                Title = Title,
                Content = Content,
                Created = Created,
            };
        }

        public void UpdatePropsFromModel(NoteModel model)
        {
            Title = model.Title ?? Title;
            Content = model.Content ?? Content;
            Created = model.Created;
        }


    }
}
