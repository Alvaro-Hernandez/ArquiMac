using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface IAdministradorService
    {
        AdministradorArq AddAdminArq(AdministradorArq oAdministradorArq);
        List<AdministradorArq> GetAdministradorList();
        AdministradorArq GetAdministradorArqId(int AdministradorArqId);
        string DeleteAdministradorArq(int AdministradorArqId);
        AdministradorArq UpdateAdministradorArq(AdministradorArq oAdministradorArq);
    }
}
