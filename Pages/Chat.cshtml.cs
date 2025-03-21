using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MentalEase.Pages;

public class ChatModel : PageModel
{
    private readonly ILogger<ChatModel> _logger;

    public ChatModel(ILogger<ChatModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Initialize chat page
    }
} 