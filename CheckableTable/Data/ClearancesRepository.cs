using CheckableTable.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckableTable.Data
{
    public class ClearancesRepository
    {
        public List<ReviewClearanceTrackViewModel> Get()
        {
            return new List<ReviewClearanceTrackViewModel>()
            {
                new ReviewClearanceTrackViewModel()
                {
                    ID = 1, 
                    Name = "First clearance",
                    Status = ReviewClearanceStatus.Approve
                },
                new ReviewClearanceTrackViewModel()
                {
                    ID = 2,
                    Name = "Second clearance",
                    Status = ReviewClearanceStatus.Reject
                },
                new ReviewClearanceTrackViewModel()
                {
                    ID = 13,
                    Name = "Third clearance",
                    Status = ReviewClearanceStatus.Other
                },
                new ReviewClearanceTrackViewModel()
                {
                    ID = 4,
                    Name = "Fourth clearance",
                    Status = ReviewClearanceStatus.Reject
                },
                new ReviewClearanceTrackViewModel()
                {
                    ID = 5,
                    Name = "Fifth clearance",
                    Status = ReviewClearanceStatus.Approve
                },
            };
        }
    }
}
