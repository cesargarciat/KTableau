using System;
using System.Collections.Generic;
using System.Text;

namespace KTableau.DAL.models
{
    class Tasks
    {

        public int Id { get; set; }

        public int TaskId { get; set; }

        public int State { get; set; }

        public DateTime Date { get; set; }

        public string User { get; set; }

    }
}
