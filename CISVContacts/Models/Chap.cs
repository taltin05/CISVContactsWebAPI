using System;
using System.Collections.Generic;

namespace CISVContacts
{
    public partial class Chap
    {
        public int ChapId { get; set; }
        public string CounCode { get; set; }
        public string ChapterName { get; set; }
        public string ChapterShort { get; set; }
        public string Url { get; set; }
        public int? SessIdCreate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public int? SessIdModify { get; set; }
        public DateTime? ModifyDatetime { get; set; }
    }
}
