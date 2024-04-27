namespace Hexagonal.Features.Tag.Domain
{
    public class TagNotFoundException : Exception
    {
        public TagNotFoundException(int id) : base($"Tag with id {id} not found")
        {
        }

    }
}