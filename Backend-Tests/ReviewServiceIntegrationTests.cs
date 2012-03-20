using System.Collections.Generic;
using System.IO;
using System.Net;
using LCBOBuddy_Backend.Model;
using LCBOBuddy_Backend.Model.DataTransferObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack;
using ServiceStack.ServiceModel.Serialization;

namespace Backend_Tests
{
    [TestClass]
    public class ReviewServiceIntegrationTests
    {
        const string BASEURI = "http://localhost:54445";
        [TestMethod]
        public void Can_I_Obtain_The_Default_Review_Listings()
        {
            var thing =
                JsonDataContractDeserializer.Instance.DeserializeFromStream<IList<Review>>(
                    new FileStream("C:/Projects/Winesnob-Backend/_lcbobuddy-backend/LCBOBuddy-Backend/Content/listings.json", FileMode.Open));
            

            const string requestUri = BASEURI + "/reviews/"; 
            var client = WebRequest.Create(requestUri); 
            var json = new StreamReader(client.GetResponse().GetResponseStream()).ReadToEnd();
            var response = JsonDataContractDeserializer.Instance.DeserializeFromString<ReviewListingsResponse>(json);
            Assert.IsNotNull(response); 
            Assert.IsTrue(response.Reviews.Count==7);
            Assert.IsTrue(response.Reviews[6].id == 684597);
        }
    }
}
