namespace Hexagonal.Features.Category.Domain
{
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException(int id) : base($"Category with id {id} not found")
        {
        }

    }
}