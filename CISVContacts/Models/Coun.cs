using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CISVContacts
{
    public partial class Coun
    {
        public string CounCode { get; set; }
        public string Country { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
