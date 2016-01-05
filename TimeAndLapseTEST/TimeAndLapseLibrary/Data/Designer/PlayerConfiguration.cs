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
    // Players
    public partial class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        public PlayerConfiguration()
            : this("dbo")
        {
        }
 
        public PlayerConfiguration(string schema)
        {
            ToTable(schema + ".Players");
            HasKey(x => x.PlayerId);

            Property(x => x.PlayerId).HasColumnName("PlayerID").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RegistrationId).HasColumnName("RegistrationID").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.TeamId).HasColumnName("TeamID").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.CrewId).HasColumnName("CrewID").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.EventId).HasColumnName("EventID").IsRequired().HasColumnType("uniqueidentifier");

            // Foreign keys
            HasRequired(a => a.Event).WithMany(b => b.Players).HasForeignKey(c => c.EventId); // FK__Players__EventID__31EC6D26
            HasRequired(a => a.Player_CrewId).WithMany(b => b.Players).HasForeignKey(c => c.CrewId); // FK__Players__CrewID__30F848ED
            HasRequired(a => a.Registration).WithMany(b => b.Players).HasForeignKey(c => c.RegistrationId); // FK__Players__Registr__2F10007B
            HasRequired(a => a.Team).WithMany(b => b.Players).HasForeignKey(c => c.TeamId); // FK__Players__TeamID__300424B4
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
