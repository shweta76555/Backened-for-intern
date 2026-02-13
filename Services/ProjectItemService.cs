using backened_for_intern.Data;
using backened_for_intern.Interfaces;
using backened_for_intern.Models;
using Microsoft.EntityFrameworkCore;

namespace backened_for_intern.Services
{
    public class ProjectItemService : IProjectItemService
    {
        private readonly ApplicationDbContext _context;

        public ProjectItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProjectItem> Create(ProjectItem item)
        {
            _context.ProjectItems.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<List<ProjectItem>> GetAll()
        {
            return await _context.ProjectItems.ToListAsync();
        }

        public async Task<ProjectItem?> GetById(int id)
        {
            return await _context.ProjectItems.FindAsync(id);
        }

        public async Task<bool> Update(int id, ProjectItem item)
        {
            var existing = await _context.ProjectItems.FindAsync(id);
            if (existing == null) return false;

            existing.Title = item.Title;
            existing.Description = item.Description;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var item = await _context.ProjectItems.FindAsync(id);
            if (item == null) return false;

            _context.ProjectItems.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
