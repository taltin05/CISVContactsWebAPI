using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Sess
    {
        public int SessId { get; set; }
        public int? UsrsId { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public string IpAddress { get; set; }
        public string Browser { get; set; }
        public string UserAgent { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
