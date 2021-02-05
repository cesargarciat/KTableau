using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KTableau.DAL.models
{
    [Table("Teams")]
    public class Team
    {

        /**
         * Do we really need a TeamId ?
         */

        //public int TeamId { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }

 
        public byte[] RowVersion { get; set; }

        // NP (Relationship to Project)
        public virtual Project Project { get; set; }

        // to N
        public virtual User User{ get; set; }


    }
}
