import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Diseno } from '../Models/Diseno';
import { ResponseI } from '../Models/Response';

@Injectable({
  providedIn: 'root'
})
export class FuncionDisenoArqService {

    constructor(private http: HttpClient) { }

    api = 'https://localhost:44386/api/DisenosArq';

    getDiseno() {
        return this.http.get<Diseno[]>(this.api);
    }

    getDisenoId(id_Diseno) {
        return this.http.get<Diseno>(this.api + "/" + id_Diseno);
    }

    postDiseno(form: Diseno) {
        return this.http.post<ResponseI>(this.api, form);
    }

    putDiseno(form: Diseno) {
        return this.http.put<ResponseI>(this.api, form);
    }

    deleteDiseno(id_Diseno) {
        return this.http.delete<ResponseI>(this.api + "/" + id_Diseno);
    }
}
