using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Conexion;
using BackEnd.IServices;
using BackEnd.Models;
using Dapper;

namespace BackEnd.Services
{
    public class VentasArqService : IVentaService
    {
        VentasArq _oVentaArq = new VentasArq();
        List<VentasArq> _oVentaArqList = new List<VentasArq>();
        public VentasArq AddVentaArq(VentasArq oVentaArq)
        {
            throw new System.NotImplementedException();
        }

        public string DeleteVentaArq(int VentaArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Venta", VentaArqId);
                        conex.Query("SP_DeleteVenta", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oVentaArq.Error = ex.Message;
            }
            return _oVentaArq.Error;
        }

        public VentasArq GetVentaArqId(int VentaArqId)
        {
            _oVentaArq = new VentasArq();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Venta", VentaArqId);
                    var oVentaArq = conex.Query<VentasArq>("SP_SelectVenta", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oVentaArq != null && oVentaArq.Count() > 0)
                    {
                        _oVentaArq = oVentaArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oVentaArq.Error = ex.Message;
            }
            return _oVentaArq;
        }

        public List<VentasArq> GetVentaArqList()
        {
            _oVentaArqList = new List<VentasArq>();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oVentasArqList = conex.Query<VentasArq>("SP_SelectVentasAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oVentasArqList != null && oVentasArqList.Count() > 0)
                    {
                        _oVentaArqList = oVentasArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oVentaArq.Error = ex.Message;
            }
            return _oVentaArqList;
        }

        public VentasArq UpdateVentaArq(VentasArq oVentaArq)
        {
            _oVentaArq = new VentasArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oVentasArq = conex.Query<VentasArq>("SP_UpdateVenta", this.updateParameters(oVentaArq), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oVentaArq.Error = ex.Message;
            }
            return _oVentaArq;
        }

        private DynamicParameters setParameters(VentasArq oVentaArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
            //El valor del ID debe ir vacio.
            /*if(oVentaArq.Id_Venta != 0)
            {
                parameters.Add("@Id_Venta", oVentaArq.Id_Venta);
            }*/
            parameters.Add("@Id_Curso", oVentaArq.Id_Curso);
            parameters.Add("@Id_Cliente", oVentaArq.Id_Cliente);
            parameters.Add("@Descuento", oVentaArq.Descuento);
            parameters.Add("@Costo_total", oVentaArq.Costo_Total);

            return parameters;
        }

        private DynamicParameters updateParameters(VentasArq oVentaArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@Id_Venta", oVentaArq.Id_Venta);
            parameters.Add("@Id_Curso", oVentaArq.Id_Curso);
            parameters.Add("@Id_Cliente", oVentaArq.Id_Cliente);
            parameters.Add("@Descuento", oVentaArq.Descuento);
            parameters.Add("@Costo_total", oVentaArq.Costo_Total);

            return parameters;

        }
    }
}
