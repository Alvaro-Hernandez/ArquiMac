import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Cursos } from '../Models/Cursos';
import { ResponseI } from '../Models/Response';

@Injectable({
  providedIn: 'root'
})
export class FuncionCursosService {

    constructor(private http: HttpClient) { }

    api = 'https://localhost:44386/api/CursoArq'

    getCursos() {
        return this.http.get<Cursos[]>(this.api);
    }

    getCursoId(id_Curso) {
        return this.http.get<Cursos>(this.api + "/" + id_Curso);
    }

    postCurso(form: Cursos) {
        return this.http.post<ResponseI>(this.api, form);
    }

    putCurso(form: Cursos) {
        return this.http.put<ResponseI>(this.api, form);
    }

    deleteCurso(id_Curso) {
        return this.http.delete<ResponseI>(this.api + "/" + id_Curso);
    }
}
