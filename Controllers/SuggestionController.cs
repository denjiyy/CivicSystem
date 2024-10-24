using CivicSystem.Data;
using CivicSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
}