using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Note.Infrastructure;
using Hexagonal.Features.User.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagonal.Features.User.Infrastructure
{
    [Table("Users")]
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<NoteEntity> Notes { get; set; }

        public UserEntity FromModel(UserModel model)
        {
            Id = model.Id;
            Name = model.Name;
            LastName = model.LastName;
            Email = model.Email;
            Password = model.Password;
            return this;
        }

        public UserModel ToModel()
        {
            return new UserModel
            {
                Id = Id,
                Name = Name,
                LastName = LastName,
                Email = Email,
                Password = Password
            };
        }

        public void UpdatePropsFromModel(UserModel model)
        {
            Name = model.Name ?? Name;
            LastName = model.LastName ?? LastName;
            Email = model.Email ?? Email;
            Password = model.Password ?? Password;
        }


    }
}
