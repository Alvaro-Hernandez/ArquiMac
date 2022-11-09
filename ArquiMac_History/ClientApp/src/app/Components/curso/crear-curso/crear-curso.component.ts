import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionCursosService } from 'src/app/Services/funcion-cursos.service';
import { Cursos } from '../../../Models/Cursos';

@Component({
  selector: 'app-crear-curso',
  templateUrl: './crear-curso.component.html',
  styleUrls: ['./crear-curso.component.css']
})
export class CrearCursoComponent implements OnInit {

    constructor(private service: FuncionCursosService, private router: Router, private activatedRouter: ActivatedRoute) { }

    dataCursos: Cursos;

    nuevoFormCurso = new FormGroup({
        id_Admin: new FormControl(''),
        imagen_Pres: new FormControl(''),
        nombre_Curso: new FormControl(''),
        descripcion: new FormControl(''),
        costo: new FormControl(''),
        num_Materiales: new FormControl(''),
        docente: new FormControl('')
    });

  ngOnInit() {
  }

    postCurso(form: Cursos) {
        this.service.postCurso(form).subscribe(Data => {
            alert("Datos Registrados");
        });
        this.router.navigate(["ListarCurso"]);
        window.location.reload();
    }

    Salir() {
        this.router.navigate(["ListarCurso"]);
    }
}
