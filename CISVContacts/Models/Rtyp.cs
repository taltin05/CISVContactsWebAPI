using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Rtyp
    {
        public int RtypId { get; set; }
        public string RelationshipType { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
