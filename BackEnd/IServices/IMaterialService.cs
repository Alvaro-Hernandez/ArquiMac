using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface IMaterialService
    {
        MaterialArq AddMaterialArq(MaterialArq oMaterialArq);
        List<MaterialArq> GetMaterialArqList();
        MaterialArq GetMaterialArqId(int MaterialArqId);
        string DeleteMaterialArq(int MaterialArqId);
        MaterialArq UpdateMaterialArq(MaterialArq oMaterialArq);
    }
}
