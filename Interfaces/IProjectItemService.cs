using backened_for_intern.Models;

namespace backened_for_intern.Interfaces
{
    public interface IProjectItemService
    {
        Task<ProjectItem> Create(ProjectItem item);
        Task<List<ProjectItem>> GetAll();
        Task<ProjectItem?> GetById(int id);
        Task<bool> Update(int id, ProjectItem item);
        Task<bool> Delete(int id);
    }
}
