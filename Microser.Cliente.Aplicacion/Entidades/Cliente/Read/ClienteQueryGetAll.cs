using Microser.Cliente.Infraestructura.DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Microser.Cliente.Aplicacion.Entidades.Cliente.Read
{
    public class ClienteQueryGetAll
    {
        internal DBRepository _repository = new DBRepository();
        private IMongoCollection<dominio.Producto> _cliente;

        public ClienteQueryGetAll()
        {
            _cliente = _repository.db.GetCollection<dominio, Cliente>("cliente");
        }
        public IEnumerable<dominio.Producto> ListarCliente()
        {
            return _cliente.Find(x =>true).ToList;
        }
    }
}
