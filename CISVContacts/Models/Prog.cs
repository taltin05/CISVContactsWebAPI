using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Prog
    {
        public int ProgId { get; set; }
        public string Program { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }
        public string Duration { get; set; }
        public string SizeOfGroup { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
