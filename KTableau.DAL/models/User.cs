using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Users")]
    public class User
    {

        // Data Annotations: to set the column properties

        public int UserId { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Surname { get; set; }

        // If this user is active (valid or invalid)
        [Required]
        public DateTime DateCreation { get; set; }

        [Required]
        public bool Active { get; set; }


        public byte[] RowVersion { get; set; }


        // NP (to N)
        public List<Team> Team { get; set; }

    

    }
}
