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
    public class ImagenDisenoArqController : ControllerBase
    {
        private IImagenDisenoService _oImagenDisenoService;

        public ImagenDisenoArqController(IImagenDisenoService oImagenDisenoService)
        {
            _oImagenDisenoService = oImagenDisenoService;
        }

        //GET: api/<ImgDisenosArq_Controller>
        [HttpGet]
        public IEnumerable<ImagenesDisenosArq> GetsImgDisenosArq()
        {
            return _oImagenDisenoService.GetImgDisenosArqList();
        }

        //GET: api/<ImgDisenosArq_Controller>/5
        [HttpGet("{id}", Name = "GetImgDisenosArqId")]
        public ImagenesDisenosArq GetImgDisenosArqId(int id)
        {
            return _oImagenDisenoService.GetImgDisenosArqId(id);
        }

        //POST: api/<ImgDisenosArq_Controller>
        [HttpPost(Name = "PostImgDisenosArq")]
        public void PostImgDisenosArq([FromBody] ImagenesDisenosArq imgDisenosArq)
        {
            if (ModelState.IsValid)
            {
                _oImagenDisenoService.AddImgDisenosArq(imgDisenosArq);
            }
        }

        //PUT: api/<ClienteArq_Controller>/5
        [HttpPut(Name = "PutImgDisenoArq")]
        public void PutImgDisenoArq([FromBody] ImagenesDisenosArq imgDisenosArq)
        {
            if (ModelState.IsValid)
            {
                _oImagenDisenoService.UpdateImgDisenosArq(imgDisenosArq);
            }
        }

        //DELETE: api/<ClienteArq_Controller>/5
        [HttpDelete("{id}", Name = "DeleteImgDisenosArq")]
        public void DeleteImgDisenosArq(int id)
        {
            if (id != 0)
            {
                _oImagenDisenoService.DeleteImgDisenosArq(id);
            }
        }
    }
}
