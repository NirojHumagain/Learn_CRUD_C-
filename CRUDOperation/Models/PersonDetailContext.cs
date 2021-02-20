using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LearnCRUDOperation.Models;

namespace LearnCRUDOperation.Models
{
    public class PersonDetailContext : DbContext
    {
        public PersonDetailContext(DbContextOptions<PersonDetailContext> options) : base(options)
        {

        }
        public DbSet<PersonDetails> PersonDetails { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfiguration(new CRUDOperation.Configuration.LoanTemplateAccessConfiguration());
        //}
    }
}