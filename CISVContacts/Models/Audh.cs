using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Audh
    {
        public int AudhId { get; set; }
        public int? SessId { get; set; }
        public string Operation { get; set; }
        public DateTime? TransDate { get; set; }
        public string TableName { get; set; }
        public int? RowId { get; set; }
        public string Notes { get; set; }
    }
}
