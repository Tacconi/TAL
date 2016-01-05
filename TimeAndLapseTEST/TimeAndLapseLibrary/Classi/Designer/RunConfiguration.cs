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
    // Runs
    public partial class RunConfiguration : EntityTypeConfiguration<Run>
    {
        public RunConfiguration()
            : this("dbo")
        {
        }
 
        public RunConfiguration(string schema)
        {
            ToTable(schema + ".Runs");
            HasKey(x => x.RunId);

            Property(x => x.RunId).HasColumnName("RunID").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MancheId).HasColumnName("MancheID").IsRequired().HasColumnType("uniqueidentifier");

            // Foreign keys
            HasRequired(a => a.Manch).WithMany(b => b.Runs).HasForeignKey(c => c.MancheId); // FK__Runs__MancheID__3D5E1FD2
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
