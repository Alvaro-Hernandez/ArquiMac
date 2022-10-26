using BackEnd.IServices;
using BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteArqController : ControllerBase
    {
        private IClienteService _oClienteService;

        public ClienteArqController(IClienteService oClienteService)
        {
            _oClienteService = oClienteService;
        }

        //GET: api/<ClienteArq_Controller>
        [HttpGet]
        public IEnumerable<ClienteArq> GetsClienteArq()
        {
            return _oClienteService.GetClienteArqList();
        }

        //GET: api/<ClienteArq_Controller>/5
        [HttpGet("{id}", Name = "GetClienteArqId")]
        public ClienteArq GetClienteArqId(int id)
        {
            return _oClienteService.GetClienteArqId(id);
        }

        //POST: api/<ClienteArq_Controller>
        [HttpPost(Name = "PostClienteArq")]
        public void PostClienteArq([FromBody] ClienteArq clienteArq)
        {
            if (ModelState.IsValid)
            {
                _oClienteService.AddClienteArq(clienteArq);
            }
        }

        //PUT: api/<ClienteArq_Controller>/5
        [HttpPut(Name = "PutClienteArq")]
        public void PutClienteArq([FromBody] ClienteArq clienteArq)
        {
            if (ModelState.IsValid)
            {
                _oClienteService.UpdateClienteArq(clienteArq);
            }
        }

        //DELETE: api/<AdministradorArqController>/5
        [HttpDelete("{id}", Name = "DeleteClienteArq")]
        public void DeleteClienteArq(int id)
        {
            if (id != 0)
            {
                _oClienteService.DeleteClienteArq(id);
            }
        }
    }
}
