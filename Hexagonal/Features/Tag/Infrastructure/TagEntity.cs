using Hexagonal.Features.NotesTags.Infrastructure;
using Hexagonal.Features.Tag.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagonal.Features.Tag.Infrastructure
{
    [Table("Tags")]
    public class TagEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<NotesTagsEntity> NotesTags { get; set; }

        public TagEntity FromModel(TagModel model)
        {
            Id = model.Id;
            Name = model.Name;
            return this;
        }

        public TagModel ToModel()
        {
            return new TagModel
            {
                Id = Id,
                Name = Name,
            };
        }

        public void UpdatePropsFromModel(TagModel model)
        {
            Name = model.Name ?? Name;

        }


    }
}
