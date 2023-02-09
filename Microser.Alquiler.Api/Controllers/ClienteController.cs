using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Microser.Alquiler.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlquilerController : ControllerBase
    {
        //public static List<Alquiler> listaAlquiler = new List<Alquiler>

        //    {
        //        new Alquiler()
        //        {
        //            IdAlquiler = 1,
        //            NombreAlquiler = "Taipe",
        //            EdadAlquiler = 21,
        //        },
        //        new Alquiler()
        //        {
        //            IdAlquiler = 2,
        //            NombreAlquiler = "cueva",
        //            EdadAlquiler = 22,
        //        } };

        [HttpGet(Name = "ListarAlquiler")]
        public IEnumerable<Alquiler> ListarAlquiler()
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Micro_Alquiler");
            var collection = database.GetCollection<Alquiler>("Alquiler");

            var listaAlquiler = collection.Find(x=>true).ToList();

            return listaAlquiler;
        }

        [HttpPost(Name = "CrearAlquiler")]
        public ActionResult<Alquiler> CrearAlquiler(Alquiler Alquiler)
        {
            //Alquiler.IdAlquiler = listaAlquiler.Count();
            //listaAlquiler.Add(Alquiler);
            return CreatedAtAction("CrearAlquiler", Alquiler);
        }

        [HttpPut(Name = "ModificararAlquiler")]
        public ActionResult<Alquiler> ModificarAlquiler(Alquiler Alquiler)
        {
            //var AlquilerModificado = listaAlquiler.Single(x => x.IdAlquiler == Alquiler.IdAlquiler);
            //AlquilerModificado.NombreAlquiler= Alquiler.NombreAlquiler;
            //AlquilerModificado.EdadAlquiler = Alquiler.EdadAlquiler;
            return CreatedAtAction("ModificarAlquiler", Alquiler);
        }

        [HttpDelete(Name = "EliminarAlquiler")]
        public ActionResult<Alquiler> EliminarAlquiler(int idAlquiler)
        {
            //listaAlquiler.RemoveAt (idAlquiler-1);
            return CreatedAtAction("EliminarAlquiler",idAlquiler);
        }
    }
}
