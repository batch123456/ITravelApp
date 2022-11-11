using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProjectAPI.Models
{


        public class TravelDetails
        {
            [Key]
            public int TravelId { get; set; }
            public string Location { get; set; }

            public int CostOfTravel { get; set; }

            public string PlacesToVisit { get; set; }
            public string SuggestedHotels { get; set; }

            public string Images { get; set; }

            public virtual ICollection<Comments> comments { get; set; }










        }
    }