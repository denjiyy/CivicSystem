using CivicSystem.Data;
using CivicSystem.Web.Models;
using CivicSystem.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CivicSystem.Controllers;

[Authorize]
public class SuggestionController : Controller
{
    private readonly ApplicationDbContext _context;

    public SuggestionController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var suggestions = await _context.Suggestions
            .Select(s => new SuggestionInfoViewModel(
                s.Id,
                s.Title,
                s.Description,
                s.UserId,
                s.Status.ToString(),
                s.CreatedOn.ToString()
            )).ToListAsync();

        return View(suggestions);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Details(Guid id)
    {
        var suggestion = await _context.Suggestions
            .Where(s => s.Id == id)
            .AsNoTracking()
            .Select(s => new DetailsViewModel()
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                CreatedOn = s.CreatedOn.ToString(),
                Status = s.Status.ToString(),
                UserId = s.User.UserName ?? null!
            }).FirstOrDefaultAsync();

        if (suggestion == null)
        {
            return NotFound();
        }

        return View(suggestion);
    }
}