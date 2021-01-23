using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string UserName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Surname { get; set; }

        // If this user is active (valid or invalid)
        public DateTime DateCreation { get; set; }

        public bool Active { get; set; }

        public byte[] RowVersion { get; set; }


    }
}
