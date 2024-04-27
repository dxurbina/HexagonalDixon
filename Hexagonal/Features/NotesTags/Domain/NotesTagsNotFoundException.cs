namespace Hexagonal.Features.NotesTags.Domain
{
    public class NotesTagsNotFoundException : Exception
    {
        public NotesTagsNotFoundException(int id) : base($"NotesTags with id {id} not found")
        {
        }

    }
}