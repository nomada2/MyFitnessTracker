//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFitnessTrackerVS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Set
    {
        public Set()
        {
            this.Exercises = new HashSet<Exercise>();
            this.ExerciseRecords = new HashSet<ExerciseRecord>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
    
        public virtual ICollection<Exercise> Exercises { get; set; }
        public virtual ICollection<ExerciseRecord> ExerciseRecords { get; set; }
    }
}
