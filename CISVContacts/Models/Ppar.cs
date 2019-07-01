using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Ppar
    {
        public int PparId { get; set; }
        public int? ContId { get; set; }
        public string Year { get; set; }
        public int? ProgId { get; set; }
        public string HostCounCode { get; set; }
        public string HostChapId { get; set; }
        public string HostCity { get; set; }
        public int? DelegationChapId { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
