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
    public class AdministradorArqService : IAdministradorService
    {
        AdministradorArq _oAdminArq = new AdministradorArq();
        List<AdministradorArq> _oAdminArqList = new List<AdministradorArq>();

        public AdministradorArq AddAdminArq(AdministradorArq oAdministradorArq)
        {
            _oAdminArq = new AdministradorArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oCursos = conex.Query<CursosArq>("SP_InsertAdmin", this.setParameters(oAdministradorArq),
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oAdminArq.Error = ex.Message;
            }
            return _oAdminArq;
        }

        public string DeleteAdministradorArq(int AdministradorArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Admin", AdministradorArqId);
                        conex.Query("SP_DeleteAdmin", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oAdminArq.Error = ex.Message;
            }
            return _oAdminArq.Error;
        }

        public AdministradorArq GetAdministradorArqId(int AdministradorArqId)
        {
            _oAdminArq = new AdministradorArq();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Admin", AdministradorArqId);
                    var oAdminArq = conex.Query<AdministradorArq>("SP_SelectAdmin", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oAdminArq != null && oAdminArq.Count() > 0)
                    {
                        _oAdminArq = oAdminArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oAdminArq.Error = ex.Message;
            }
            return _oAdminArq;
        }

        public List<AdministradorArq> GetAdministradorList()
        {
            _oAdminArqList = new List<AdministradorArq>();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oAdminArqList = conex.Query<AdministradorArq>("SP_SelectAdminAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oAdminArqList != null && oAdminArqList.Count() > 0)
                    {
                        _oAdminArqList = oAdminArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oAdminArq.Error = ex.Message;
            }
            return _oAdminArqList;
        }


        public AdministradorArq UpdateAdministradorArq(AdministradorArq oAdministradorArq)
        {
            _oAdminArq = new AdministradorArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oAdminArq = conex.Query<AdministradorArq>("SP_UpdateCurso", this.setParameters(oAdministradorArq), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oAdminArq.Error = ex.Message;
            }
            return _oAdminArq;
        }
        private DynamicParameters setParameters(AdministradorArq oAdminArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
            //El valor del ID debe ir vacio.
            /*if (oAdminArq.Id_Admin != 0)
            {
                parameters.Add("@Id_Admin", oAdminArq.Id_Admin);
            }*/
            parameters.Add("@Nombres", oAdminArq.Nombres);
            parameters.Add("@Apellidos", oAdminArq.Apellidos);
            parameters.Add("@Usuario", oAdminArq.Usuario);
            parameters.Add("@Contrasena", oAdminArq.Contrasena);
            parameters.Add("@Email", oAdminArq.Email);

            return parameters;
        }
    }
}
