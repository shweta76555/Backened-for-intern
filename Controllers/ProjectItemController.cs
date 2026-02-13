using backened_for_intern.Interfaces;
using backened_for_intern.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backened_for_intern.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    [ApiController]
    public class ProjectItemController : ControllerBase
    {
        private readonly IProjectItemService _service;

        public ProjectItemController(IProjectItemService service)
        {
            _service = service;
        }

      // create
        [HttpPost]
        public async Task<IActionResult> Create(ProjectItem item)
        {
            var created = await _service.Create(item);
            return Ok(created);
        }

        // Get All
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var items = await _service.GetAll();
        //    return Ok(items);
        //}


        [HttpGet("test-error")]
        public IActionResult TestError()
        {
            throw new Exception("This is a test exception");
        }


        // Get By Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetById(id);

            if (item == null)
                return NotFound("Item not found");

            return Ok(item);
        }

        // Update
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProjectItem item)
        {
            var updated = await _service.Update(id, item);

            if (!updated)
                return NotFound("Item not found");

            return Ok("Updated successfully");
        }

        // Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.Delete(id);

            if (!deleted)
                return NotFound("Item not found");

            return Ok("Deleted successfully");
        }
    }
}
