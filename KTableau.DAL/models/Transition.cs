using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KTableau.DAL.models
{
    [Table("Transitions")]
    public class Transition
    {
        public int TransitionId { get; set; }

        public int TaskId { get; set; }

        public int State { get; set; }

        // The user associated to this task
        public int UserId { get; set; }

        //When this transition is created
        public DateTime DateCreation { get; set; }

        public byte[] RowVersion { get; set; }

        // Navigation properties
        public Task Task { get; set; }
    }
}
