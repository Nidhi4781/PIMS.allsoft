using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PIMS.allsoft.Interfaces;
using PIMS.allsoft.Models;
using PIMS.allsoft.Services;

namespace PIMS.allsoft.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]
    [Authorize(Roles ="Admin")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
        }
        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync(Categories Category)
        {
            var category = await _categoryService.AddCategoryAsync(Category);

            return Created("", category); // Or Ok(category); if you prefer using 200 status code.

            //var Categorys = await _categoryService.AddCategoryAsync(Category);
            //return (IActionResult)Categorys;
        }
        // Other CRUD endpoints for categories
    }
}
