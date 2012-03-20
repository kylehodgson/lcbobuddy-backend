using System.Collections.Generic;
using System.IO;
using LCBOBuddy_Backend.Model.DataTransferObjects;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceModel.Serialization;

namespace LCBOBuddy_Backend.Model.Services
{
    public class ReviewService : ServiceBase<ReviewListings>
    {
        protected override object Run(ReviewListings request)
        {
            return _getDefaultReviewListings();
        }

        private object _getDefaultReviewListings()
        {
            var response = new ReviewListingsResponse();
            //var thing =
            //    JsonDataContractDeserializer.Instance.DeserializeFromStream<IList<Review>>(
            //        new FileStream("C:/Projects/Winesnob-Backend/_lcbobuddy-backend/LCBOBuddy-Backend/Content/listings.json", FileMode.Open));
            //response.Reviews = thing;
            return response;
        }
    }
}