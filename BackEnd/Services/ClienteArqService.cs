using Dapper;
using System.Data.Common;
using BackEnd.IServices;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Conexion;

namespace BackEnd.Services
{
    public class ClienteArqService : IClienteService
    {
        ClienteArq _oClienteArq = new ClienteArq();
        List<ClienteArq> _oClienteArqList = new List<ClienteArq>();

        public ClienteArq AddClienteArq(ClienteArq oClienteArq)
        {
            _oClienteArq = new ClienteArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oCliente = conex.Query<ClienteArq>("SP_InsertCliente", this.setParameters(oClienteArq),
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oClienteArq.Error = ex.Message;
            }
            return _oClienteArq;
        }

        public string DeleteClienteArq(int ClienteArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Cliente", ClienteArqId);
                        conex.Query("SP_DeleteCliente", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oClienteArq.Error = ex.Message;
            }
            return _oClienteArq.Error;
        }

        public ClienteArq GetClienteArqId(int ClienteArqId)
        {
            _oClienteArq = new ClienteArq();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Cliente", ClienteArqId);
                    var oClienteArq = conex.Query<ClienteArq>("SP_SelectCliente", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oClienteArq != null && oClienteArq.Count() > 0)
                    {
                        _oClienteArq = oClienteArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oClienteArq.Error = ex.Message;
            }
            return _oClienteArq;
        }

        public List<ClienteArq> GetClienteArqList()
        {
            _oClienteArqList = new List<ClienteArq>();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oClienteArqList = conex.Query<ClienteArq>("SP_SelectClienteAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oClienteArqList != null && oClienteArqList.Count() > 0)
                    {
                        _oClienteArqList = oClienteArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oClienteArq.Error = ex.Message;
            }
            return _oClienteArqList;
        }

        public ClienteArq UpdateClienteArq(ClienteArq oClienteArq)
        {
            _oClienteArq = new ClienteArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oClientesArq = conex.Query<ClienteArq>("SP_UpdateCliente", this.updateParameters(oClienteArq), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oClienteArq.Error = ex.Message;
            }
            return _oClienteArq;
        }
        private DynamicParameters setParameters(ClienteArq oClienteArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
            //El valor del ID debe ir vacio.
            /*if(oClienteArq.Id_Cliente != 0)
            {
                parameters.Add("@Id_Cliente", oClienteArq.Id_Cliente);
            }*/
            parameters.Add("@Nombres", oClienteArq.Nombres);
            parameters.Add("@Apellidos", oClienteArq.Apellidos);
            parameters.Add("@Usuario", oClienteArq.Usuario);
            parameters.Add("@Contrasena", oClienteArq.Contraseña);
            parameters.Add("@Email", oClienteArq.Email);

            return parameters;
        }

        private DynamicParameters updateParameters(ClienteArq oClienteArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@Id_Cliente", oClienteArq.Id_Cliente);
            parameters.Add("@Nombres", oClienteArq.Nombres);
            parameters.Add("@Apellidos", oClienteArq.Apellidos);
            parameters.Add("@Usuario", oClienteArq.Usuario);
            parameters.Add("@Contrasena", oClienteArq.Contraseña);
            parameters.Add("@Email", oClienteArq.Email);

            return parameters;
        }
    }
}
