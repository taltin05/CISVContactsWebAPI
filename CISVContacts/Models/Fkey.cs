using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Fkey
    {
        public int FkeyId { get; set; }
        public string DeleteTable { get; set; }
        public string LinkTable { get; set; }
        public string LinkField { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
