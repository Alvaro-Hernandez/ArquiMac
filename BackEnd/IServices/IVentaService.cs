using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface IVentaService
    {
        VentasArq AddVentaArq(VentasArq oVentaArq);
        List<VentasArq> GetVentaArqList();
        VentasArq GetVentaArqId(int VentaArqId);
        string DeleteVentaArq(int VentaArqId);
        VentasArq UpdateVentaArq(VentasArq oVentaArq);
    }
}
