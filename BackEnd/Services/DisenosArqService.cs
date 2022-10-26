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
    public class DisenosArqService : IDisenoArquiService
    {
        DisenosArq _oDisenosArq = new DisenosArq();
        List<DisenosArq> _oDisenosArqList = new List<DisenosArq>();

        public DisenosArq AddDisenoArq(DisenosArq oDisenoArq)
        {
            _oDisenosArq = new DisenosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oDisenos = conex.Query<DisenosArq>("SP_InsertDiseno", this.setParameters(oDisenoArq),
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oDisenosArq.Error = ex.Message;
            }
            return _oDisenosArq;
        }

        public string DeleteDisenoArq(int DisenoArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Diseno", DisenoArqId);
                        conex.Query("SP_DeleteDiseno", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oDisenosArq.Error = ex.Message;
            }
            return _oDisenosArq.Error;
        }

        public DisenosArq GetDisenoArqId(int DisenoArqId)
        {
            _oDisenosArq = new DisenosArq();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Diseno", DisenoArqId);
                    var oDisenoArq = conex.Query<DisenosArq>("SP_SelectDiseno", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oDisenoArq != null && oDisenoArq.Count() > 0)
                    {
                        _oDisenosArq = oDisenoArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oDisenosArq.Error = ex.Message;
            }
            return _oDisenosArq;
        }

        public List<DisenosArq> GetDisenosArqList()
        {
            _oDisenosArqList = new List<DisenosArq>();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oDisenoArqList = conex.Query<DisenosArq>("SP_SelectDisenoAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oDisenoArqList != null && oDisenoArqList.Count() > 0)
                    {
                        _oDisenosArqList = oDisenoArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oDisenosArq.Error = ex.Message;
            }
            return _oDisenosArqList;
        }

        public DisenosArq UpdateDisenoArq(DisenosArq oDisenoArq)
        {
            _oDisenosArq = new DisenosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oDisenosArq = conex.Query<DisenosArq>("SP_UpdateDiseno", this.setParameters(oDisenoArq), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oDisenosArq.Error = ex.Message;
            }
            return _oDisenosArq;
        }

        private DynamicParameters setParameters(DisenosArq oDisenosArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
            //El valor del ID debe ir vacio.
            /*if(oDisenoArq.Id_Diseno != 0)
            {
                parameters.Add("@Id_Diseno", oDisenoArq.Id_Diseno);
            }*/
            parameters.Add("@Id_Admin", oDisenosArq.Id_Admin);
            parameters.Add("@Descripcion", oDisenosArq.Descripcion);
            parameters.Add("@Pais_Ubic", oDisenosArq.Pais_Ubic);
            parameters.Add("@Ciudad_Ubic", oDisenosArq.Ciudad_Ubic);
            parameters.Add("@Estilo_Art", oDisenosArq.Estilo_Art);
            parameters.Add("@Creado_por", oDisenosArq.Creado_por);

            return parameters;
        }
    }
}
