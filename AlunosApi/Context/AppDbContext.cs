using AlunosApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Aluno>().HasData(
        //        new Aluno
        //        {
        //            Id = 1,
        //            Nome = "Marina Silva",
        //            Email = "marinasilva@gmail.com",
        //            Idade = 23
        //        },
        //        new Aluno
        //        {
        //            Id = 2,
        //            Nome = "Jorge Luiz",
        //            Email = "jorgeluiz@gmail.com",
        //            Idade = 25
        //        }
        //    );
        //}
    }
}
