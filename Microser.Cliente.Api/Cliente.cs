using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Microser.Cliente.Api
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        public int IdCliente { get; set; }

        public string? NombreCliente { get; set; }
                
        public int EdadCliente { get; set; }

       
    }
}
