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
    public class VentaArqController : ControllerBase
    {
        private IVentaService _oVentaService;

        public VentaArqController(IVentaService oVentaService)
        {
            _oVentaService = oVentaService;
        }

        //GET: api/<VentaArqController>
        [HttpGet(Name = "GetVentaArqList")]
        public IEnumerable<VentasArq> GetVentaArqList()
        {
            return _oVentaService.GetVentaArqList();
        }

        //GET: api/<VentaArqController>/5
        [HttpGet("{id}", Name = "GetVentaArqId")]
        public VentasArq GetVentaArqId(int id)
        {
            return _oVentaService.GetVentaArqId(id);
        }

        //POST: api/<VentaArqController>
        [HttpPost(Name = "PostVentaArq")]
        public void PostVentaArq([FromBody] VentasArq ventaArq)
        {
            if (ModelState.IsValid)
            {
                _oVentaService.AddVentaArq(ventaArq);
            }
        }

        //PUT: api/<VentaArqController>/5
        [HttpPut(Name = "PutVentaArq")]
        public void PutVentaArq([FromBody] VentasArq ventaArq)
        {
            if (ModelState.IsValid)
            {
                _oVentaService.UpdateVentaArq(ventaArq);
            }
        }

        //DELETE: api/<VentaArqController>/5
        [HttpDelete("{id}", Name = "DeleteVentaArq")]
        public void DeleteVentaArq(int id)
        {
            if (id != 0)
            {
                _oVentaService.DeleteVentaArq(id);
            }
        }
    }
}
