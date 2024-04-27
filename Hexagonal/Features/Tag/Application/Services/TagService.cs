using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Domain.Ports.In;

namespace Hexagonal.Features.Tag.Application.Services
{
    public class TagService: ITagServicePort
    {
        private readonly IGetTagById _getTagByIdService;
        private readonly IGetTags _getTagsService;
        private readonly ICreateTag _createTag;
        private readonly IUpdateTag _updateTag;
        private readonly IDeleteTag _deleteTag;


        public TagService(IGetTagById getTagByIdService, IGetTags getTagsService, ICreateTag createTag, IUpdateTag updateTag, IDeleteTag deleteTag)
        {
            _getTagByIdService = getTagByIdService;
            _getTagsService = getTagsService;
            _createTag = createTag;
            _updateTag = updateTag;
            _deleteTag = deleteTag;
        }

        public Task<List<TagModel>> GetTags()
        {
            return _getTagsService.GetTags();
        }

        public Task<TagModel?> GetTagById(int id)
        {
            return _getTagByIdService.GetTagById(id);
        }

        public Task<TagModel> Create(TagModel tag)
        {
            return _createTag.Create(tag);
        }

        public Task<TagModel> Update(int id, TagModel tag)
        {
            return _updateTag.Update(id, tag);
        }

        public Task<int> Delete(int id)
        {
            return _deleteTag.Delete(id);
        }


    }
}
