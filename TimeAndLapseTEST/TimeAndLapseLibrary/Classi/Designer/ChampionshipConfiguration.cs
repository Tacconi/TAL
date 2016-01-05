// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
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

namespace TimeAndLapseLibrary.Classi.Designer
{
    // Championships
    public partial class ChampionshipConfiguration : EntityTypeConfiguration<Championship>
    {
        public ChampionshipConfiguration()
            : this("dbo")
        {
        }
 
        public ChampionshipConfiguration(string schema)
        {
            ToTable(schema + ".Championships");
            HasKey(x => x.ChampionshipId);

            Property(x => x.ChampionshipId).HasColumnName("ChampionshipID").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName("Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.Prize).HasColumnName("Prize").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>