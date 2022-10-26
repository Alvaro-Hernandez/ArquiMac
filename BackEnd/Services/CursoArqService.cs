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
    public class CursoArqService : ICursoService
    {
        CursosArq _oCursosArq = new CursosArq();
        List<CursosArq> _oCursosArqList = new List<CursosArq>();

        public CursosArq AddCursoArq(CursosArq oCursosArq)
        {
            _oCursosArq = new CursosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oCursos = conex.Query<CursosArq>("SP_InsertCurso", this.setParameters(oCursosArq),
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oCursosArq.Error = ex.Message;
            }
            return _oCursosArq;
        }

        public string DeleteCursoArq(int CursosArqId)
        {
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var param = new DynamicParameters();
                        param.Add("@Id_Curso", CursosArqId);
                        conex.Query("SP_DeleteCurso", param, commandType: CommandType.StoredProcedure).SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oCursosArq.Error = ex.Message;
            }
            return _oCursosArq.Error;
        }

        public CursosArq GetCursosArqId(int CursoArqId)
        {
            _oCursosArq = new CursosArq();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var param = new DynamicParameters();
                    param.Add("@Id_Curso", CursoArqId);
                    var oCursoArq = conex.Query<CursosArq>("SP_SelectCurso", param, commandType: CommandType.StoredProcedure).ToList();

                    if (oCursoArq != null && oCursoArq.Count() > 0)
                    {
                        _oCursosArq = oCursoArq.SingleOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                _oCursosArq.Error = ex.Message;
            }
            return _oCursosArq;
        }

        public List<CursosArq> GetCursosArqList()
        {
            _oCursosArqList = new List<CursosArq>();
            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                    }
                    var oCursoArqList = conex.Query<CursosArq>("SP_SelectCursoAll", commandType: CommandType.StoredProcedure).ToList();

                    if (oCursoArqList != null && oCursoArqList.Count() > 0)
                    {
                        _oCursosArqList = oCursoArqList;
                    }
                }
            }
            catch (Exception ex)
            {
                _oCursosArq.Error = ex.Message;
            }
            return _oCursosArqList;
        }

        public CursosArq UpdateCursoArq(CursosArq oCursosArq)
        {
            _oCursosArq = new CursosArq();

            try
            {
                using (IDbConnection conex = new SqlConnection(Global.ConnectionString))
                {
                    if (conex.State == ConnectionState.Closed)
                    {
                        conex.Open();
                        var oCursoArq = conex.Query<CursosArq>("SP_UpdateCurso", this.setParameters(oCursosArq), commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch (Exception ex)
            {
                _oCursosArq.Error = ex.Message;
            }
            return _oCursosArq;
        }

        private DynamicParameters setParameters(CursosArq oCursoArq)
        {
            DynamicParameters parameters = new DynamicParameters();

            //Esto es solo necesario cuando nuestros datos no son autoincrementables al serlos
             //El valor del ID debe ir vacio.
            /*if(oCursoArq.Id_Curso != 0)
            {
                parameters.Add("@Id_Curso", oCursoArq.Id_Curso);
            }*/
            parameters.Add("@Id_Admin", oCursoArq.Id_Admin);
            parameters.Add("@Imagen_Pres", oCursoArq.Imagen_Pres);
            parameters.Add("@Nombre_Curso", oCursoArq.Nombre_Curso);
            parameters.Add("@Descripcion", oCursoArq.Descripcion);
            parameters.Add("@Costo", oCursoArq.Costo);
            parameters.Add("@Num_Materiales", oCursoArq.Num_Materiales);
            parameters.Add("@Docente", oCursoArq.Docente);

            return parameters;
        }
    }
}
