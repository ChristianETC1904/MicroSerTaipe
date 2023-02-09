using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Microser.Habitacion.Api
{
    public class Habitacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        public int IdHabitacion { get; set; }

        public string? NombreHabitacion { get; set; }
                
        public int EdadHabitacion { get; set; }

       
    }
}
