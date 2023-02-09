using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Microser.Habitacion.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HabitacionController : ControllerBase
    {
        //public static List<Habitacion> listaHabitacion = new List<Habitacion>

        //    {
        //        new Habitacion()
        //        {
        //            IdHabitacion = 1,
        //            NombreHabitacion = "Taipe",
        //            EdadHabitacion = 21,
        //        },
        //        new Habitacion()
        //        {
        //            IdHabitacion = 2,
        //            NombreHabitacion = "cueva",
        //            EdadHabitacion = 22,
        //        } };

        [HttpGet(Name = "ListarHabitacion")]
        public IEnumerable<Habitacion> ListarHabitacion()
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Micro_Habitacion");
            var collection = database.GetCollection<Habitacion>("habitacion");

            var listaHabitacion = collection.Find(x=>true).ToList();

            return listaHabitacion;
        }

        [HttpPost(Name = "CrearHabitacion")]
        public ActionResult<Habitacion> CrearHabitacion(Habitacion habitacion)
        {
            //habitacion.IdHabitacion = listaHabitacion.Count();
            //listaHabitacion.Add(habitacion);
            return CreatedAtAction("CrearHabitacion", habitacion);
        }

        [HttpPut(Name = "ModificararHabitacion")]
        public ActionResult<Habitacion> ModificarHabitacion(Habitacion habitacion)
        {
            //var habitacionModificado = listaHabitacion.Single(x => x.IdHabitacion == habitacion.IdHabitacion);
            //habitacionModificado.NombreHabitacion= habitacion.NombreHabitacion;
            //habitacionModificado.EdadHabitacion = habitacion.EdadHabitacion;
            return CreatedAtAction("ModificarHabitacion", habitacion);
        }

        [HttpDelete(Name = "EliminarHabitacion")]
        public ActionResult<Habitacion> EliminarHabitacion(int idHabitacion)
        {
            //listaHabitacion.RemoveAt (idHabitacion-1);
            return CreatedAtAction("EliminarHabitacion",idHabitacion);
        }
    }
}
