import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ImagenDiseno } from '../Models/ImagenDiseno';
import { ResponseI } from '../Models/Response';

@Injectable({
  providedIn: 'root'
})
export class FuncionImagenArqService {

    constructor(private http: HttpClient) { }

    api = 'https://localhost:44386/api/ImagenDisenoArq';

    getImgDiseno() {
        return this.http.get<ImagenDiseno[]>(this.api);
    }

    getImgDisenoId(id_Imagen) {
        return this.http.get<ImagenDiseno>(this.api + "/" + id_Imagen);
    }

    postImgDiseno(form: ImagenDiseno) {
        return this.http.post<ResponseI>(this.api, form);
    }

    putImgDiseno(form: ImagenDiseno) {
        return this.http.put<ResponseI>(this.api, form);
    }

    deleteImgDiseno(id_Imagen) {
        return this.http.delete<ResponseI>(this.api + "/" + id_Imagen);
    }
}
