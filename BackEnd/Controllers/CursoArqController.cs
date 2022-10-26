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
    public class CursoArqController : ControllerBase
    {
        private ICursoService _oCursoService;

        public CursoArqController (ICursoService oCursoService)
        {
            _oCursoService = oCursoService;
        }

        //GET: api/<CursoArq_Controller>
        [HttpGet]
        public IEnumerable<CursosArq> GetsCursosArq()
        {
            return _oCursoService.GetCursosArqList();
        }

        //GET: api/<CursoArq_Controller>/5
        [HttpGet("{id}", Name = "GetCursosArqId")]
        public CursosArq GetCursosId(int id)
        {
            return _oCursoService.GetCursosArqId(id);
        }

        //POST: api/<CursoArq_Controller>
        [HttpPost(Name = "PostCursoArq")]
        public void PostCursoArq([FromBody] CursosArq cursosArq)
        {
            if (ModelState.IsValid)
            {
                _oCursoService.AddCursoArq(cursosArq);
            }
        }

        //PUT: api/<CursoArq_Controller>/5
        [HttpPut(Name = "PutCursoArq")]
        public void PutCursoArq([FromBody] CursosArq cursosArq)
        {
            if (ModelState.IsValid)
            {
                _oCursoService.UpdateCursoArq(cursosArq);
            }
        }

        //DELETE: api/<CursoArq_Controller>/5
        [HttpDelete("{id}", Name = "DeleteCursoArq")]
        public void DeleteCursoArq(int id)
        {
            if (id != 0)
            {
                _oCursoService.DeleteCursoArq(id);
            }
        }
    }
}
