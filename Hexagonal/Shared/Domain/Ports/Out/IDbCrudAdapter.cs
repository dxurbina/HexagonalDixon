namespace Hexagonal.Shared.Domain.Ports.Out
{
    public interface IDbCrudAdapter<TModel>
    {
        Task<List<TModel>> FindAll();
        Task<TModel?> FindById(int id);
        Task<TModel> Create(TModel model);
        Task<TModel> Update(int id, TModel model);
        Task<int> Delete(int id);
    }
}

