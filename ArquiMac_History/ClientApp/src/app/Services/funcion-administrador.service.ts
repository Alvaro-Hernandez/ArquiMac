import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Administrador } from '../Models/Administrador';
import {ResponseI } from '../Models/Response';
import { Lista_Admin } from '../Models/Lista_Administrador';

@Injectable({
  providedIn: 'root'
})
export class FuncionAdministradorService {

    constructor(private http: HttpClient) { }

    api = 'https://localhost:44386/api/AdministradorArq';

    getAdmin() {
        return this.http.get<Lista_Admin[]>(this.api);
    }

    getAdminId(id_Admin) {
        return this.http.get<Administrador>(this.api + "/" + id_Admin);
    }

    postAdmin(form: Administrador) {
        return this.http.post<ResponseI>(this.api, form);
    }

    putAdmin(form: Administrador) {
        return this.http.put<ResponseI>(this.api, form);
    }

    deleteAdmin(id) {
        return this.http.delete<ResponseI>(this.api + "/" + id);
    }
}
