using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckableTable.Models.ViewModel
{
    public class ReviewClearanceTrackViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ReviewClearanceStatus Status { get; set; }
    }
    public enum ReviewClearanceStatus
    {
        Approve,
        Reject,
        Other
    }
}
