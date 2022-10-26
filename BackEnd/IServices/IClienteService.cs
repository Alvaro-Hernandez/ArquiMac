using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface IClienteService
    {
        ClienteArq AddClienteArq(ClienteArq oClienteArq);
        List<ClienteArq> GetClienteArqList();
        ClienteArq GetClienteArqId(int ClienteArqId);
        string DeleteClienteArq(int ClienteArqId);
        ClienteArq UpdateClienteArq(ClienteArq oClienteArq);
    }
}
