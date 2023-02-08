using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Microser.Cliente.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        //public static List<Cliente> listaCliente = new List<Cliente>

        //    {
        //        new Cliente()
        //        {
        //            IdCliente = 1,
        //            NombreCliente = "Taipe",
        //            EdadCliente = 21,
        //        },
        //        new Cliente()
        //        {
        //            IdCliente = 2,
        //            NombreCliente = "cueva",
        //            EdadCliente = 22,
        //        } };

        [HttpGet(Name = "ListarCliente")]
        public IEnumerable<Cliente> ListarCliente()
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Micro_Cliente");
            var collection = database.GetCollection<Cliente>("cliente");

            var listaCliente = collection.Find(x=>true).ToList();

            return listaCliente;
        }

        [HttpPost(Name = "CrearCliente")]
        public ActionResult<Cliente> CrearCliente(Cliente cliente)
        {
            //cliente.IdCliente = listaCliente.Count();
            //listaCliente.Add(cliente);
            return CreatedAtAction("CrearCliente", cliente);
        }

        [HttpPut(Name = "ModificararCliente")]
        public ActionResult<Cliente> ModificarCliente(Cliente cliente)
        {
            //var clienteModificado = listaCliente.Single(x => x.IdCliente == cliente.IdCliente);
            //clienteModificado.NombreCliente= cliente.NombreCliente;
            //clienteModificado.EdadCliente = cliente.EdadCliente;
            return CreatedAtAction("ModificarCliente", cliente);
        }

        [HttpDelete(Name = "EliminarCliente")]
        public ActionResult<Cliente> EliminarCliente(int idCliente)
        {
            //listaCliente.RemoveAt (idCliente-1);
            return CreatedAtAction("EliminarCliente",idCliente);
        }
    }
}
