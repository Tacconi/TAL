// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.52
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace TimeAndLapseLibrary.Data.Designer
{
    // Races
    public partial class RaceConfiguration : EntityTypeConfiguration<Race>
    {
        public RaceConfiguration()
            : this("dbo")
        {
        }
 
        public RaceConfiguration(string schema)
        {
            ToTable(schema + ".Races");
            HasKey(x => x.RaceId);

            Property(x => x.RaceId).HasColumnName("RaceID").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName("Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.Lenght).HasColumnName("Lenght").IsRequired().HasColumnType("real");
            Property(x => x.Slope).HasColumnName("Slope").IsRequired().HasColumnType("real");
            Property(x => x.WidthRoad).HasColumnName("WidthRoad").IsRequired().HasColumnType("real");
            Property(x => x.StartAddress).HasColumnName("StartAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.EndAddress).HasColumnName("EndAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.RaceDate).HasColumnName("RaceDate").IsRequired().HasColumnType("datetime");
            Property(x => x.Place).HasColumnName("Place").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Pavement).HasColumnName("Pavement").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SubscriptionPrice).HasColumnName("SubscriptionPrice").IsRequired().HasColumnType("float");
            Property(x => x.PaymentDate).HasColumnName("PaymentDate").IsRequired().HasColumnType("datetime");
            Property(x => x.PaymentPlace).HasColumnName("PaymentPlace").IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.OrganizedBy).HasColumnName("OrganizedBy").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.Photo).HasColumnName("Photo").IsRequired().HasColumnType("image").HasMaxLength(2147483647);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
