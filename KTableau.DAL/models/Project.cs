using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Projects")]
    public class Project
    {

        public int ProjectId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProjectName { get; set; }
                
        public string Description { get; set; }

        public DateTime DateCreation { get; set; }

        // The user who creates the project
        public int UserId { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
