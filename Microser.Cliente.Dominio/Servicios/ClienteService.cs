using Microser.Cliente.Infraestructura.DBSettings;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio = Microser.Cliente.Dominio.Entidades;

namespace Microser.Cliente.Dominio.Servicios
{
    public class ClienteService : ControllerBase
    {

        private IMongoCollection<dominio.Cliente> _cliente;

        public ClienteService(IDBSettings dBSettings)
        {
            //var cliente = new MongoClient(dBSettings.Server);
            //var database =cliente.GetDatabase(dBSettings.Database);
            //_cliente = database.GetCollection<dominio.Cliente> (dBSettings.Collection);
            ClienteQuery

        }

        public List<dominio.Cliente> ListarCliente()
        { 
        return _cliente.Find(x => true).ToList();
        }

        }
}
