using Microser.Alquiler.Infraestructura.DBRepository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio = Microser.Alquiler.Dominio.Entidades;


namespace Microser.Alquiler.Aplicacion.Entidades.Alquiler.Read
{
    public class AlquilerQueryGetAll
    {
        internal DBRepository _repository = new DBRepository();

        private IMongoCollection<dominio.Alquiler> _Alquiler;

        public AlquilerQueryGetAll()
        {
            _Alquiler = _repository.db.GetCollection<dominio.Alquiler>("Alquiler");
        }
        public IEnumerable<dominio.Alquiler> ListarAlquiler()
        {
            return _Alquiler.Find(x =>true).ToList();
        }
    }
}
