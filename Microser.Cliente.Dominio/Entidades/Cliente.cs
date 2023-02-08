using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microser.Cliente.Dominio.Entidades
{
    internal class Cliente
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        public int IdCliente { get; set; }

        public string? NombreCliente { get; set; }

        public int EdadCliente { get; set; }



    }
}
