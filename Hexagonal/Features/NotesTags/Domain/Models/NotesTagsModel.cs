using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.User.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Hexagonal.Features.NotesTags.Domain.Models
{
    public class NotesTagsModel
    {
        public int Id { get; set; }
        public int NoteId { get; set; }

        public virtual NoteModel Note { get; set; }

        public int TagId { get; set; }

        public virtual TagModel Tag { get; set; }


    }
}