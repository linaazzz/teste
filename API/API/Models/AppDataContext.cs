using System;
using Microsoft.EntityFrameworkCore;

namespace API.Models;
public class AppDataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

}