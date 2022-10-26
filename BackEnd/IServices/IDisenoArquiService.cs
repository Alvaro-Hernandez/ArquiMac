using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface IDisenoArquiService
    {
        DisenosArq AddDisenoArq(DisenosArq oDisenoArq);
        List<DisenosArq> GetDisenosArqList();
        DisenosArq GetDisenoArqId(int DisenoArqId);
        string DeleteDisenoArq(int DisenoArqId);
        DisenosArq UpdateDisenoArq(DisenosArq oDisenoArq);
    }
}
