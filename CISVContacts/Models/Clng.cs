using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Clng
    {
        public int ClngId { get; set; }
        public int? ContId { get; set; }
        public int? LangId { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
