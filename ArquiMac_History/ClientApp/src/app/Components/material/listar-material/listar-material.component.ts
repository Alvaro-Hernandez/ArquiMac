import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FuncionMaterialService } from 'src/app/Services/funcion-material.service';
import { MaterialCu } from '../../../Models/MaterialCu';

@Component({
  selector: 'app-listar-material',
  templateUrl: './listar-material.component.html',
  styleUrls: ['./listar-material.component.css']
})
export class ListarMaterialComponent implements OnInit {

    constructor(private service: FuncionMaterialService, private router: Router) { }

    dateMaterial: MaterialCu[];

    ngOnInit() {
        this.service.getMaterials()
            .subscribe(Data => this.dateMaterial = Data);
    }

    goCrearMateriales() {
        this.router.navigate(["CrearMaterial"]);
    }

    goEditar(id) {
        this.router.navigate(["EditarMaterial", id]);
    }

    Eliminar(id) {
        this.service.deleteMaterial(id).subscribe(Data => {
            console.log(Data);
            alert("Datos Eliminados");
        });
        window.location.reload();
    }

}
