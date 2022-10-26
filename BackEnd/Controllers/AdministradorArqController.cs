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
    public class AdministradorArqController : ControllerBase
    {
        private IAdministradorService _oAdministradorService;
        
        public AdministradorArqController(IAdministradorService oAdministradorService)
        {
            _oAdministradorService = oAdministradorService;
        }

        //GET: api/<AdministradorArqController>
        [HttpGet(Name = "GetAdminArqList")]
        public IEnumerable<AdministradorArq> GetAdminArqList()
        {
            return _oAdministradorService.GetAdministradorList();
        }

        //GET: api/<AdministradorArqController>/5
        [HttpGet("{id}", Name = "GetAdminArqId")]
        public AdministradorArq GetAdminArqId(int id)
        {
            return _oAdministradorService.GetAdministradorArqId(id);
        }

        //POST: api/<AdministradorArqController>
        [HttpPost(Name = "PostAdminArq")]
        public void PostAdminArq([FromBody] AdministradorArq administradorArq)
        {
            if (ModelState.IsValid)
            {
                _oAdministradorService.AddAdminArq(administradorArq);
            }
        }

        //PUT: api/<AdministradorArqController>/5
        [HttpPut(Name = "PutAdminArq")]
        public void PutAdminArq([FromBody] AdministradorArq administradorArq)
        {
            if (ModelState.IsValid)
            {
                _oAdministradorService.UpdateAdministradorArq(administradorArq);
            }
        }

        //DELETE: api/<AdministradorArqController>/5
        [HttpDelete("{id}", Name = "DeleteAdminArq")]
        public void DeleteAdminArq(int id)
        {
            if (id != 0)
            {
                _oAdministradorService.DeleteAdministradorArq(id);
            }
        }
    }
}
