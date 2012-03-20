
namespace LCBOBuddy_Backend.Model
{
    //"1": {
    //     "id": "64287",
    //     "image_url": "http://lcbo.com/app/images/products/0064287.jpg",
    //     "image_thumb_url": "http://lcbo.com/app/images/products/website/0064287.jpg",
    //     "name": "Cono Sur 2010 Viognier",
    //     "category": "White",
    //     "region": "Chile",
    //     "price": "10.00",
    //     "rating": "89",
    //     "description": "Cono Sur makes the world’s best $10 viognier. There are classic aromas of star fruit, lychee, spearmint and pepper with orange marmalade and spice. It’s mid-weight and a touch sweet, yet lively. It’s a great aperitif white.",
    //     "byline": "Review by David Lawrason",
    //     "byline_link": "http://www.torontolife.com/daily/daily-dish/from-the-print-edition-daily-dish/2011/12/16/eight-bargain-bottles/#more-108615"
    //  },
    public class Review
    {
        public int id { get; set;  }
        public string image_url { get; set;  }
        public string image_thumb_url { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string region { get; set; }
        public decimal price { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
        public string byline { get; set; }
        public string byline_link { get; set; }
    }
}