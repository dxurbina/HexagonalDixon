using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Infrastructure;
using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagonal.Features.NotesTags.Infrastructure
{
    [Table("NotesTags")]
    public class NotesTagsEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("NoteId")]
        public int NoteId { get; set; }

        public virtual NoteEntity Note { get; set; }
        [ForeignKey("TagId")]
        public int TagId { get; set; }

        public virtual TagEntity Tag { get; set; }

        public NotesTagsEntity FromModel(NotesTagsModel model)
        {
            Id = model.Id;
            return this;
        }

        public NotesTagsModel ToModel()
        {
            return new NotesTagsModel
            {
                Id = Id,
            };
        }

        public void UpdatePropsFromModel(NotesTagsModel model)
        {
        }


    }
}
