using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Usrs
    {
        public int UsrsId { get; set; }
        public string Email { get; set; }
        public string PassHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }
        public bool? Admin { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
