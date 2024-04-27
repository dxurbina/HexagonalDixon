namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public interface ITagServicePort : IGetTags, IGetTagById, ICreateTag, IUpdateTag, IDeleteTag
    {
    }
}
