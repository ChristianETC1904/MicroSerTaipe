using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Microser.Alquiler.Dominio.Entidades
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
