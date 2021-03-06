﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Infrastructure.Domain;

namespace Infrastructure.EntityMapping
{
    class SubCatFieldMapping : EntityTypeConfiguration<SubCatField>
    {
        public SubCatFieldMapping()
        {
            // PRIMARY KEY

            HasKey(c => c.Id);

            // PROPERTIES

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Subject);

            Property(c => c.Category);

            Property(c => c.Field);

        }
    }
}
