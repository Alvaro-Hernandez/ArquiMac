import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionMaterialService } from 'src/app/Services/funcion-material.service';
import { MaterialCu } from '../../../Models/MaterialCu';

@Component({
  selector: 'app-crear-material',
  templateUrl: './crear-material.component.html',
  styleUrls: ['./crear-material.component.css']
})
export class CrearMaterialComponent implements OnInit {

    constructor(private service: FuncionMaterialService, private router: Router, private activatedRouter: ActivatedRoute) { }

    dateMaterial: MaterialCu;

    nuevoFormMaterial = new FormGroup({
        id_Curso: new FormControl(''),
        tipo_Material: new FormControl(''),
        almacenado_en: new FormControl('')
    });

  ngOnInit() {
  }

    postMaterial(form: MaterialCu) {
        this.service.postMaterial(form).subscribe(Data => {
            alert("Datos Registrados");
        });
        this.router.navigate(["ListarMaterial"]);
    }

    Salir() {
        this.router.navigate(["ListarMaterial"]);
    }
}
