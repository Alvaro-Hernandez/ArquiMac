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
    public class MaterialArqController : ControllerBase
    {
        private IMaterialService _oMaterialService;

        public MaterialArqController(IMaterialService oMaterialService)
        {
            _oMaterialService = oMaterialService;
        }

        //GET: api/<MaterialArqController>
        [HttpGet(Name = "GetMaterialArqList")]
        public IEnumerable<MaterialArq> GetMaterialArqList()
        {
            return _oMaterialService.GetMaterialArqList();
        }

        //GET: api/<MaterialArqController>/5
        [HttpGet("{id}", Name = "GetMaterialArqId")]

        public MaterialArq GetMaterialArqId(int id)
        {
            return _oMaterialService.GetMaterialArqId(id);
        }

        //POST: api/<MaterialArqController>
        [HttpPost(Name = "PostMaterialArq")]
        public void PostMaterialArq([FromBody] MaterialArq materialArq)
        {
            if (ModelState.IsValid)
            {
                _oMaterialService.AddMaterialArq(materialArq);
            }
        }

        //PUT: api/<MaterialArqController>/5
        [HttpPut(Name = "PutMaterialArq")]
        public void PutMaterialArq([FromBody] MaterialArq materialArq)
        {
            if (ModelState.IsValid)
            {
                _oMaterialService.UpdateMaterialArq(materialArq);
            }
        }

        //DELETE: api/<MaterialArqController>/5
        [HttpDelete("{id}", Name = "DeleteMaterialArq")]
        public void DeleteMaterialArq(int id)
        {
            if (id != 0)
            {
                _oMaterialService.DeleteMaterialArq(id);
            }
        }
    }
}
