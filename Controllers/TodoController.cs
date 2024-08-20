using Microsoft.AspNetCore.Mvc;
using dotnet_mvc_todos.Models;
using dotnet_mvc_todos.DB;
using dotnet_mvc_todos.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc_todos.Controllers;

public class TodoController : Controller
{
    private readonly AppDbContext _context;

    public TodoController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        if (_context.Todos == null)
        {
            return Problem("Todo is null");
        }

        var todos = from t in _context.Todos
                    select t;

        var viewModel = new TodoIndexViewModel
        {
            Todos = await todos.ToListAsync(),
        };

        return View(viewModel);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(string NewTitle)
    {
        if (!string.IsNullOrEmpty(NewTitle))
        {
            var todo = new Todo { Title = NewTitle };
            _context.Add(todo);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
