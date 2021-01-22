using System;
using System.Collections.Generic;
using System.Text;

namespace KTableau.DAL.models
{
    class Notes
    {
        public int Id { get; set; }

        public int TaskId { get; set; }

        public string Note { get; set; }

        public DateTime Date { get; set; }
        
        public byte[] RowVersion { get; set; }


    }
}
