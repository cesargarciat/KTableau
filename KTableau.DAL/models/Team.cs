using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KTableau.DAL.models
{
    [Table("Teams")]
    public class Team
    {

        public int UserId { get; set; }

        public int ProjectId { get; set; }

 
        public byte[] RowVersion { get; set; }
    }
}
