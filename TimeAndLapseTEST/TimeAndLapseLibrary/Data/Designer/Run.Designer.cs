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
    // Runs
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Run
    {
        public Guid RunId { get; set; } // RunID (Primary key)
        public Guid MancheId { get; set; } // MancheID

        // Reverse navigation
        public virtual ICollection<Timing> Timings { get; set; } // Timings.FK__Timings__RunID__35BCFE0A

        // Foreign keys
        public virtual Manch Manch { get; set; } // FK__Runs__MancheID__3D5E1FD2
        
        public Run()
        {
            Timings = new List<Timing>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
