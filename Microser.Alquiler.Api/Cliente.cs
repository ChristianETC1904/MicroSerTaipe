using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Microser.Alquiler.Api
{
    public class Alquiler
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        public int IdAlquiler { get; set; }

        public string? NombreAlquiler { get; set; }
                
        public int EdadAlquiler { get; set; }

       
    }
}
