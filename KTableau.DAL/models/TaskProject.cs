using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Tasks")]
    public class TaskProject
    {
        // (PK)
        public int TaskId { get; set; }

        // (FK)
        // The project this task belongs to
        public int ProjectId { get; set; }

        [Required]
        public int State { get; set; }

        // We do not set the MAX length to, 
        // so it is not needed to set the data annotation

        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }

        // When this task is created
        [Required]
        public DateTime Date { get; set; }

        // (PK)
        // The user who executes this task
        public int UserId { get; set; }

        public byte[] RowVersion { get; set; }

        // Navigation properties : Task's list of notes
        public virtual ICollection<Note> Notes { get; set; }

        // NP: Task's list of transitions
        public virtual ICollection<Transition> Transitions { get; set; }

        // NP: Task's user 
        public virtual User TaskUser { get; set; }

        public virtual Project Project { get; set; }

    }
}
