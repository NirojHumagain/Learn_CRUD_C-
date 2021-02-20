using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnCRUDOperation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDOperation
{
    public class Configuration
    {
        public class LoanTemplateAccessConfiguration : IEntityTypeConfiguration<PersonDetails>
        {
            public void Configure(EntityTypeBuilder<PersonDetails> builder)
            {
                builder.ToTable("dbo.PersonDetails");
                builder.HasKey(e => e.Id);
               

            }

                
        }
    }
}
