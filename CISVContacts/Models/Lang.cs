using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Lang
    {
        public int LangId { get; set; }
        public string Language { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
