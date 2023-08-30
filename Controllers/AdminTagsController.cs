using AuthSystem.Data;
using AuthSystem.Models.Domain;
using AuthSystem.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AuthSystem.Controllers
{
    public class AdminTagsController : Controller
    {
        public readonly AuthDbContext _context;
        public AdminTagsController(AuthDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var tags = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };

            _context.Tags.Add(tags);
            _context.SaveChanges();
          
            return View("Add");
        }
    }
}
