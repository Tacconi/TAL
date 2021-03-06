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
    public interface ITimeAndLapseContext : IDisposable
    {
        DbSet<Category> Categories { get; set; } // Categories
        DbSet<Championship> Championships { get; set; } // Championships
        DbSet<Event> Events { get; set; } // Events
        DbSet<Manch> Manches { get; set; } // Manches
        DbSet<Partecipant> Partecipants { get; set; } // Partecipants
        DbSet<Player> Players { get; set; } // Players
        DbSet<Point> Points { get; set; } // Points
        DbSet<Race> Races { get; set; } // Races
        DbSet<Registration> Registrations { get; set; } // Registrations
        DbSet<Round> Rounds { get; set; } // Rounds
        DbSet<Run> Runs { get; set; } // Runs
        DbSet<Score> Scores { get; set; } // Scores
        DbSet<Season> Seasons { get; set; } // Seasons
        DbSet<Team> Teams { get; set; } // Teams
        DbSet<Timing> Timings { get; set; } // Timings
        DbSet<TimingType> TimingTypes { get; set; } // TimingTypes

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

}
// </auto-generated>
