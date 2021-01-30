using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Notes")]
    public class Note
    {
        // (PK)
        public int NoteId { get; set; }

        // (FK)
        // The task this note belongs to
        public int TaskId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }

        // When this note is created
        [Required]
        public DateTime Date { get; set; }
        
        public byte[] RowVersion { get; set; }

        // Navigations properties

        public virtual TaskProject Task { get; set; }


    }
}
