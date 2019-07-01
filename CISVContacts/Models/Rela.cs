using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Rela
    {
        public int RelaId { get; set; }
        public int? RtypId { get; set; }
        public int? ParentContId { get; set; }
        public int? ChildContId { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
