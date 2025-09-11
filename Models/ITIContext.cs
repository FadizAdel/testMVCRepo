using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace MVC_christenZarif.Models;

public class ITIContext :DbContext
{
    public ITIContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=.;Initial Catalog=ITI_MVC;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<crsResult> CrsResults { get; set; }
}
