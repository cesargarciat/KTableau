using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Tasks")]
    public class Task
    {

        public int TaskId { get; set; }

        // The project this task belongs to
        public int ProjectId { get; set; }

        public int State { get; set; }

        // We do not set the MAX length to, 
        // so it is not needed to set the data annotation
        public string Description { get; set; }

        // When this task is created
        public DateTime Date { get; set; }

        // The user who executes this task
        public int UserId { get; set; }

        public byte[] RowVersion { get; set; }

        // Navigation properties : Task's list of notes
        public List<Note> Notes { get; set; }

        // NP: Task's list of transitions
        public List<Transition> Transitions { get; set; }

        // NP: Task's user 
        public User TaskUser { get; set; }

    }
}
