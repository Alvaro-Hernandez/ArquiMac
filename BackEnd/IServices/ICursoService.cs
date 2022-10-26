using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.IServices
{
    public interface ICursoService
    {
        CursosArq AddCursoArq(CursosArq oCursosArq);
        List<CursosArq> GetCursosArqList();
        CursosArq GetCursosArqId(int CursoArqId);
        string DeleteCursoArq(int CursosArqId);
        CursosArq UpdateCursoArq(CursosArq oCursosArq);
    }
}
