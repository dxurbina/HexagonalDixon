namespace Hexagonal.Features.Category.Domain.Ports.In
{
    public interface IDeleteCategory
    {
        Task<int> Delete(int id);
    }

}
