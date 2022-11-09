import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { FuncionCursosService } from 'src/app/Services/funcion-cursos.service';
import { Cursos } from '../../../Models/Cursos';

@Component({
  selector: 'app-editar-curso',
  templateUrl: './editar-curso.component.html',
  styleUrls: ['./editar-curso.component.css']
})
export class EditarCursoComponent implements OnInit {

    constructor(private service: FuncionCursosService, private router: Router, private activatedRouter: ActivatedRoute) { }

    dataCurso: Cursos;

    editarFormCurso = new FormGroup({
        id_Curso: new FormControl(''),
        id_Admin: new FormControl(''),
        imagen_Pres: new FormControl(''),
        nombre_Curso: new FormControl(''),
        descripcion: new FormControl(''),
        costo: new FormControl(''),
        num_Materiales: new FormControl(''),
        docente: new FormControl(''),
        error: new FormControl('')
    });

    ngOnInit() {
        let cursoId = this.activatedRouter.snapshot.paramMap.get('id_Curso');
        this.service.getCursoId(cursoId).subscribe(Data => {
            this.dataCurso = Data;
            this.editarFormCurso.patchValue({
                'id_Curso': this.dataCurso.id_Curso,
                'id_Admin': this.dataCurso.id_Admin,
                'imagen_Pres': this.dataCurso.imagen_Pres,
                'nombre_Curso': this.dataCurso.nombre_Curso,
                'descripcion': this.dataCurso.descripcion,
                'costo': this.dataCurso.costo,
                'num_Materiales': this.dataCurso.num_Materiales,
                'docente': this.dataCurso.docente
            });
        });
    }

    putCurso(form: Cursos) {
       this.service.putCurso(form).subscribe(Data => {
             console.log(Data);
           alert("Datos Editados");
       });
       window.location.reload;
       this.router.navigate(["ListarCurso"]);
    }

    Salir() {
        this.router.navigate(["ListarCurso"]);
    }

}
