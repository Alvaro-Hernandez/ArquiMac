import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionMaterialService } from 'src/app/Services/funcion-material.service';
import { MaterialCu } from '../../../Models/MaterialCu';

@Component({
  selector: 'app-editar-material',
  templateUrl: './editar-material.component.html',
  styleUrls: ['./editar-material.component.css']
})
export class EditarMaterialComponent implements OnInit {

    constructor(private service: FuncionMaterialService, private router: Router, private activatedRoute: ActivatedRoute) { }

    dateMaterial: MaterialCu;

    editarFormMaterial = new FormGroup({
        id_Material: new FormControl(''),
        id_Curso: new FormControl(''),
        tipo_Material: new FormControl(''),
        almacenado_en: new FormControl(''),
        error: new FormControl('')
    });

    ngOnInit() {
        let materialId = this.activatedRoute.snapshot.paramMap.get('id_Material');
        this.service.getMaterialId(materialId).subscribe(Data => {
            this.dateMaterial = Data;
            this.editarFormMaterial.patchValue({
                'id_Material': this.dateMaterial.id_Material,
                'id_Curso': this.dateMaterial.id_Curso,
                'tipo_Material': this.dateMaterial.tipo_Material,
                'almacenado_en': this.dateMaterial.almacenado_en
            });
        });
    }


    putMaterial(form: MaterialCu) {
        this.service.putMaterial(form).subscribe(Data => {
            console.log(Data);
            alert("Datos Editados");
        });
        window.location.reload;
        this.router.navigate(["ListarMaterial"]);
    }

    Salir() {
        this.router.navigate(["ListarMaterial"]);
    }

}
