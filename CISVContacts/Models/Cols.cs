using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Cols
    {
        public int ColsId { get; set; }
        public int? TablId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDescription { get; set; }
        public int? AuditSort { get; set; }
    }
}
