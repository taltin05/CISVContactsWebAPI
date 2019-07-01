using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Syst
    {
        public int SystId { get; set; }
        public int? PasswordMinlength { get; set; }
        public bool? PasswordNumeric { get; set; }
        public bool? PasswordSpecial { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
        public string Homepage { get; set; }
    }
}
