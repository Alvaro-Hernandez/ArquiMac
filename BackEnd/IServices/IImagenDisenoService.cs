using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface IImagenDisenoService
    {
        ImagenesDisenosArq AddImgDisenosArq(ImagenesDisenosArq ImgDisenosArqId);
        List<ImagenesDisenosArq> GetImgDisenosArqList();
        ImagenesDisenosArq GetImgDisenosArqId(int ImgDisenosArqId);
        string DeleteImgDisenosArq(int ImgDisenosArqId);
        ImagenesDisenosArq UpdateImgDisenosArq(ImagenesDisenosArq ImgDisenosArqId);
    }
}
