using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Projects")]    public class Project
    {
        // (PK)
        public int ProjectId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string ProjectName { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateCreation { get; set; }

        public int TeamId { get; set; }

        // (FK)
        // The user who creates the project
        public int UserId { get; set; }

        public byte[] RowVersion { get; set; }

        // Navigation properties (relationship to Team)
        public Team Team{ get; set; }

        public List<Task> Tasks { get; set; }
    }
}
