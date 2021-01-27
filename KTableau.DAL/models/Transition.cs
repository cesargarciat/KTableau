using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KTableau.DAL.models
{
    [Table("Transitions")]
    public class Transition
    {
        // (PK)
        public int TransitionId { get; set; }

        // (FK)
        public int TaskId { get; set; }

        [Required]
        public int State { get; set; }

        // (FK)
        // The user associated to this task 
        public int UserId { get; set; }

        
        // When this transition is created
        [Required]
        public DateTime DateCreation { get; set; }

        public byte[] RowVersion { get; set; }

        // Navigation properties
        public Task Task { get; set; }
    }
}
