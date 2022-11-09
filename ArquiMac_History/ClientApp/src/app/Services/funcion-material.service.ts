import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MaterialCu } from '../Models/MaterialCu';
import { ResponseI } from '../Models/Response';

@Injectable({
  providedIn: 'root'
})
export class FuncionMaterialService {

    constructor(private http: HttpClient) { }

    api = 'https://localhost:44386/api/MaterialArq';

    getMaterials() {
        return this.http.get<MaterialCu[]>(this.api);
    }

    getMaterialId(id_Imagen) {
        return this.http.get<MaterialCu>(this.api + "/" + id_Imagen);
    }

    postMaterial(form: MaterialCu) {
        return this.http.post<ResponseI>(this.api, form);
    }

    putMaterial(form: MaterialCu) {
        return this.http.put<ResponseI>(this.api, form);
    }

    deleteMaterial(id_Imagen) {
        return this.http.delete<ResponseI>(this.api + "/" + id_Imagen);
    }
}
