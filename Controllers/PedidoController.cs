using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Teste.Controllers
{
    public class PedidoController : ApiController
    {
		//Get api/Pedido
		public List<Pedido> Get() {
			var repositorio = new Repositorio();
			//Falta campo com data de criação do pedido para comparação junto com status
			return repositorio.ListaPedidos().Where(x => x.StatusPedido.IdStatus == 4).ToList();
		}

	}
}
