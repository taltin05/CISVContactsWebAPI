using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Note
    {
        public int NoteId { get; set; }
        public int? ContId { get; set; }
        public int? UsrsId { get; set; }
        public DateTime? NoteDate { get; set; }
        public string Note1 { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
