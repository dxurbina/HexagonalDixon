using Hexagonal.Features.Category.Infrastructure;
using Hexagonal.Features.Note.Infrastructure;
using Hexagonal.Features.NotesTags.Infrastructure;
using Hexagonal.Features.Tag.Infrastructure;
using Hexagonal.Features.User.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Shared.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CategoryEntity> Categories {  get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<NoteEntity> Notes { get; set; }
        public DbSet<NotesTagsEntity> NotesTags { get; set; }
    }
}
