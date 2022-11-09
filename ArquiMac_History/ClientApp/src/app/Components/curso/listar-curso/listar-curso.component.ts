import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FuncionCursosService } from 'src/app/Services/funcion-cursos.service';
import { Cursos } from '../../../Models/Cursos';

@Component({
  selector: 'app-listar-curso',
  templateUrl: './listar-curso.component.html',
  styleUrls: ['./listar-curso.component.css']
})
export class ListarCursoComponent implements OnInit {

    constructor(private service: FuncionCursosService, private router: Router) { }

    cursos: Cursos[];

    ngOnInit() {
        this.service.getCursos()
            .subscribe(Data => this.cursos = Data);
    }

    CrearCurso() {
        this.router.navigate(["CrearCurso"]);
    }

    EditarCurso(id) {
        this.router.navigate(["EditarCurso", id]);
    }

    EliminarCurso(id) {
        this.service.deleteCurso(id).subscribe(Data => {
            console.log(Data);
            alert("Datos Eliminados");
        });
        window.location.reload();
    }
}
