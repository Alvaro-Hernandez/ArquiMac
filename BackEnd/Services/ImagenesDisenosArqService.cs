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
    public class ImagenesDisenosArqService : IImagenDisenoService
    {
        ImagenesDisenosArq _oImgDisenoArq = new ImagenesDisenosArq();
        List<ImagenesDisenosArq> _oImgDisenoArqList = new List<ImagenesDisenosArq>();

        public ImagenesDisenosArq AddImgDisenosArq(ImagenesDisenosArq ImgDisenosArqId)
        {
            _oImgDisenoArq = new ImagenesDisenosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oCliente = conex.Query<ImagenesDisenosArq>("SP_InsertImagen", this.setParameters(ImgDisenosArqId),
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oImgDisenoArq.Error = ex.Message;
            }

            return _oImgDisenoArq;
        }

        public string DeleteImgDisenosArq(int ImgDisenosArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Imagen", ImgDisenosArqId);
                        conex.Query("SP_DeleteImagen", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oImgDisenoArq.Error = ex.Message;
            }

            return _oImgDisenoArq.Error;
        }

        public ImagenesDisenosArq GetImgDisenosArqId(int ImgDisenosArqId)
        {
            _oImgDisenoArq = new ImagenesDisenosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Imagen", ImgDisenosArqId);
                    var oImgDiseArq = conex.Query<ImagenesDisenosArq>("SP_SelectImagen", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oImgDiseArq != null && oImgDiseArq.Count() > 0)
                    {
                        _oImgDisenoArq = oImgDiseArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oImgDisenoArq.Error = ex.Message;
            }

            return _oImgDisenoArq;
        }

        public List<ImagenesDisenosArq> GetImgDisenosArqList()
        {
            _oImgDisenoArqList = new List<ImagenesDisenosArq>();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oImgDisenoArqList = conex.Query<ImagenesDisenosArq>("SP_SelectImagenAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oImgDisenoArqList != null && oImgDisenoArqList.Count() > 0)
                    {
                        _oImgDisenoArqList = oImgDisenoArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oImgDisenoArq.Error = ex.Message;
            }

            return _oImgDisenoArqList;
        }

        public ImagenesDisenosArq UpdateImgDisenosArq(ImagenesDisenosArq ImgDisenosArqId)
        {
            _oImgDisenoArq = new ImagenesDisenosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oImgDisenoArq = conex.Query<ImagenesDisenosArq>("SP_UpdateImagen", this.setParameters(ImgDisenosArqId), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oImgDisenoArq.Error = ex.Message;
            }

            return _oImgDisenoArq;
        }

        private DynamicParameters setParameters(ImagenesDisenosArq oImgDisenoArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
            //El valor del ID debe ir vacio.
            /*if(oImgDisenoArq.Id_Imagen != 0)
            {
                parameters.Add("@Id_Imagen", oImgDisenoArq.Id_Imagen);
            }*/
            parameters.Add("@Id_Diseno", oImgDisenoArq.Id_Diseno);
            parameters.Add("@Almacenamiento", oImgDisenoArq.Almacenamiento);

            return parameters;
        }
    }
}
