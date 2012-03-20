using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LCBOBuddy_Backend.Model.DataTransferObjects
{
    public class ReviewListingsResponse
    {
        public IList<Review> Reviews;

        public ReviewListingsResponse()
        {
            Reviews = new List<Review>();
        }
    }
}