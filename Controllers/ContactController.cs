using Microsoft.AspNetCore.Mvc;
using d:\projectazure\myresumebot\Models;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ContactController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("submit_contact")]
    public IActionResult SubmitContact(ContactForm contactForm)
    {
        _context.ContactForms.Add(contactForm);
        _context.SaveChanges();
        return Ok();
    }
}
