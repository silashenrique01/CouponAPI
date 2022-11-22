using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CouponAPI.Models
{
    public class Coupon
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
