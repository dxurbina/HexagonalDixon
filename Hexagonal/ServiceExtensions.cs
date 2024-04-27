using Hexagonal.Features.Category.Application.Services;
using Hexagonal.Features.Category.Application.UseCases;
using Hexagonal.Features.Category.Domain.Ports.In;
using Hexagonal.Features.Category.Domain.Ports.Out;
using Hexagonal.Features.Category.Infrastructure;
using Hexagonal.Features.Note.Application.Services;
using Hexagonal.Features.Note.Application.UseCases;
using Hexagonal.Features.Note.Domain.Ports.In;
using Hexagonal.Features.Note.Domain.Ports.Out;
using Hexagonal.Features.Note.Infrastructure;
using Hexagonal.Features.NotesTags.Application.Services;
using Hexagonal.Features.NotesTags.Application.UseCases;
using Hexagonal.Features.NotesTags.Domain.Ports.In;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;
using Hexagonal.Features.NotesTags.Infrastructure;
using Hexagonal.Features.Tag.Application.Services;
using Hexagonal.Features.Tag.Application.UseCases;
using Hexagonal.Features.Tag.Domain.Ports.In;
using Hexagonal.Features.Tag.Domain.Ports.Out;
using Hexagonal.Features.Tag.Infrastructure;
using Hexagonal.Features.User.Application.Services;
using Hexagonal.Features.User.Application.UseCases;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;
using Hexagonal.Features.User.Infrastructure;


namespace Hexagonal
{
    public static class ServiceExtensions
    {
        public static void AddUserExtension(this IServiceCollection services)
        {
            services.AddScoped<IUserDbAdapterPort, UserDbAdapter>();
            services.AddScoped<IGetUsers, GetUsersImpl>();
            services.AddScoped<IGetUserById, GetUserByIdImpl>();
            services.AddScoped<IGetUserByEmail, GetUserByEmailImpl>();
            services.AddScoped<ICreateUser, CreateUserImpl>();
            services.AddScoped<IUpdateUser, UpdateUserImpl>();
            services.AddScoped<IDeleteUser, DeleteUserImpl>();

            services.AddScoped<IUserServicePort, UserService>();


        }

        public static void AddCategoryExtension(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDbAdapterPort, CategoryDbAdapter>();
            services.AddScoped<IGetCategories, GetCategoriesImpl>();
            services.AddScoped<IGetCategoryById, GetCategoryByIdImpl>();
            services.AddScoped<ICreateCategory, CreateCategoryImpl>();
            services.AddScoped<IUpdateCategory, UpdateCategoryImpl>();
            services.AddScoped<IDeleteCategory, DeleteCategoryImpl>();

            services.AddScoped<ICategoryServicePort, CategoryService>();
        }

        public static void AddNoteExtension(this IServiceCollection services)
        {
            services.AddScoped<INoteDbAdapterPort, NoteDbAdapter>();
            services.AddScoped<IGetNotes, GetNotesImpl>();
            services.AddScoped<IGetNoteById, GetNoteByIdImpl>();
            services.AddScoped<ICreateNote, CreateNoteImpl>();
            services.AddScoped<IUpdateNote, UpdateNoteImpl>();
            services.AddScoped<IDeleteNote, DeleteNoteImpl>();

            services.AddScoped<INoteServicePort, NoteService>();
        }

        public static void AddTagExtension(this IServiceCollection services)
        {
            services.AddScoped<ITagDbAdapterPort, TagDbAdapter>();
            services.AddScoped<IGetTags, GetTagsImpl>();
            services.AddScoped<IGetTagById, GetTagByIdImpl>();
            services.AddScoped<ICreateTag, CreateTagImpl>();
            services.AddScoped<IUpdateTag, UpdateTagImpl>();
            services.AddScoped<IDeleteTag, DeleteTagImpl>();

            services.AddScoped<ITagServicePort, TagService>();
        }

        public static void AddNotesTagsExtension(this IServiceCollection services)
        {
            services.AddScoped<INotesTagsDbAdapterPort, NotesTagsDbAdapter>();
            services.AddScoped<IGetNotesTags, GetNotesTagsImpl>();
            services.AddScoped<IGetNotesTagsById, GetNotesTagsByIdImpl>();
            services.AddScoped<ICreateNotesTags, CreateNotesTagsImpl>();
            services.AddScoped<IUpdateNotesTags, UpdateNotesTagsImpl>();
            services.AddScoped<IDeleteNotesTags, DeleteNotesTagsImpl>();

            services.AddScoped<INotesTagsServicePort, NotesTagsService>();
        }

    }
}
