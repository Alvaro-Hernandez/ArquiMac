import { Component } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

    constructor(private router: Router) { }

    goAdmin() {
        this.router.navigate(["ListarAdministrador"]);
    }

    goCursos() {
        this.router.navigate(["ListarCurso"]);
    }

    goDisenoArq() {
        this.router.navigate(["ListarDiseno"]);
    }

    goMateriaArq() {
        this.router.navigate(["ListarMaterial"])
    }
}
