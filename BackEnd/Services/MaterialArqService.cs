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
    public class MaterialArqService : IMaterialService
    {
        MaterialArq _oMaterialArq = new MaterialArq();
        List<MaterialArq> _oMaterialArqList = new List<MaterialArq>();

        public MaterialArq AddMaterialArq(MaterialArq oMaterialArq)
        {
            _oMaterialArq = new MaterialArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oMaterial = conex.Query<MaterialArq>("SP_InsertMaterial", this.setParameters(oMaterialArq),
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oMaterialArq.Error = ex.Message;
            }
            return _oMaterialArq;
        }

        public string DeleteMaterialArq(int MaterialArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Material", MaterialArqId);
                        conex.Query("SP_DeleteMaterial", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oMaterialArq.Error = ex.Message;
            }
            return _oMaterialArq.Error;
        }

        public MaterialArq GetMaterialArqId(int MaterialArqId)
        {
            _oMaterialArq = new MaterialArq();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Material", MaterialArqId);
                    var oMaterialArq = conex.Query<MaterialArq>("SP_SelectMaterial", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oMaterialArq != null && oMaterialArq.Count() > 0)
                    {
                        _oMaterialArq = oMaterialArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oMaterialArq.Error = ex.Message;
            }
            return _oMaterialArq;
        }

        public List<MaterialArq> GetMaterialArqList()
        {
            _oMaterialArqList = new List<MaterialArq>();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oMaterialArqList = conex.Query<MaterialArq>("SP_SelectMaterialAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oMaterialArqList != null && oMaterialArqList.Count() > 0)
                    {
                        _oMaterialArqList = oMaterialArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oMaterialArq.Error = ex.Message;
            }
            return _oMaterialArqList;
        }

        public MaterialArq UpdateMaterialArq(MaterialArq oMaterialArq)
        {
            _oMaterialArq = new MaterialArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oMaterialesArq = conex.Query<MaterialArq>("SP_UpdateMaterial", this.updateParameters(oMaterialArq), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oMaterialArq.Error = ex.Message;
            }
            return _oMaterialArq;
        }

        private DynamicParameters setParameters(MaterialArq oMaterialArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
            //El valor del ID debe ir vacio.
            /*if(oMaterialArq.Id_Material != 0)
            {
                parameters.Add("@Id_Material", oCMaterialArq.Id_Material);
            }*/
            parameters.Add("@Id_Curso", oMaterialArq.Id_Curso);
            parameters.Add("@Tipo_Material", oMaterialArq.Tipo_Material);
            parameters.Add("@Almacenado_en", oMaterialArq.Almacenado_en);

            return parameters;
        }

        private DynamicParameters updateParameters(MaterialArq oMaterialArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@Id_Material", oMaterialArq.Id_Material);
            parameters.Add("@Id_Curso", oMaterialArq.Id_Curso);
            parameters.Add("@Tipo_Material", oMaterialArq.Tipo_Material);
            parameters.Add("@Almacenado_en", oMaterialArq.Almacenado_en);

            return parameters;
        }
    }
}
