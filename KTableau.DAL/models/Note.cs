using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTableau.DAL.models
{
    [Table("Notes")]
    public class Note
    {
        public int NoteId { get; set; }

        // The task this note belongs to
        public int TaskId { get; set; }

        public string Description { get; set; }

        // When this note is created
        public DateTime Date { get; set; }
        
        public byte[] RowVersion { get; set; }

        // Navigations properties

        public Task Task { get; set; }


    }
}
