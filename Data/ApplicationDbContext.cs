using Microsoft.EntityFrameworkCore;
using d:\projectazure\myresumebot\Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ContactForm> ContactForms { get; set; }
}
