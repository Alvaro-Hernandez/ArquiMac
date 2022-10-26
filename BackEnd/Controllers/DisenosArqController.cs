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
    public class DisenosArqController : ControllerBase
    {
        private IDisenoArquiService _oDisenosArquitecService;

        public DisenosArqController(IDisenoArquiService oDisenosArquitec)
        {
            _oDisenosArquitecService = oDisenosArquitec;
        }

        //GET: api/<DisenosArq_Controller>
        [HttpGet]
        public IEnumerable<DisenosArq> GetsDisenosArq()
        {
            return _oDisenosArquitecService.GetDisenosArqList();
        }

        //GET: api/<DisenosArq_Controller>/5
        [HttpGet("{id}", Name = "GetDisenosArqId")]
        public DisenosArq GetDisenosArqId(int id)
        {
            return _oDisenosArquitecService.GetDisenoArqId(id);
        }

        //POST: api/<DisenosArq_Controller>
        [HttpPost(Name = "PostDisenosArq")]
        public void PostDisenosArq([FromBody] DisenosArq disenosArq)
        {
            if (ModelState.IsValid)
            {
                _oDisenosArquitecService.AddDisenoArq(disenosArq);
            }
        }

        //PUT: api/<DisenosArq_Controller>/5
        [HttpPut(Name = "PutDisenoArq")]
        public void PutDisenoArq([FromBody] DisenosArq disenosArq)
        {
            if (ModelState.IsValid)
            {
                _oDisenosArquitecService.UpdateDisenoArq(disenosArq);
            }
        }

        //DELETE: api/<DisenosArq_Controller>/5
        [HttpDelete("{id}", Name = "DeleteDisenosArq")]
        public void DeleteDisenosArq(int id)
        {
            if (id != 0)
            {
                _oDisenosArquitecService.DeleteDisenoArq(id);
            }
        }
    }
}
