import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { FuncionDisenoArqService } from 'src/app/Services/funcion-diseno-arq.service';
import { Diseno } from '../../../../Models/Diseno';

@Component({
  selector: 'app-editar-disenoarq',
  templateUrl: './editar-disenoarq.component.html',
  styleUrls: ['./editar-disenoarq.component.css']
})
export class EditarDisenoarqComponent implements OnInit {

    constructor(private service: FuncionDisenoArqService, private router: Router, private activatedRouter: ActivatedRoute) { }

    dateDiseno: Diseno;

    editarFormDiseno = new FormGroup({
        id_Diseno: new FormControl(''),
        id_Admin: new FormControl(''),
        descripcion: new FormControl(''),
        pais_Ubic: new FormControl(''),
        ciudad_Ubic: new FormControl(''),
        estilo_Art: new FormControl(''),
        creado_por: new FormControl(''),
        error: new FormControl('')
    });

    ngOnInit() {
        let disenoId = this.activatedRouter.snapshot.paramMap.get('id_Diseno');
        this.service.getDisenoId(disenoId).subscribe(Data => {
            this.dateDiseno = Data;
            this.editarFormDiseno.patchValue({
                'id_Diseno': this.dateDiseno.id_Diseno,
                'id_Admin': this.dateDiseno.id_Admin,
                'descripcion': this.dateDiseno.descripcion,
                'pais_Ubic': this.dateDiseno.pais_Ubic,
                'ciudad_Ubic': this.dateDiseno.ciudad_Ubic,
                'estilo_Art': this.dateDiseno.estilo_Art,
                'creado_por': this.dateDiseno.creado_por
            });
        });
    }

    putDiseno(form: Diseno) {
        this.service.putDiseno(form).subscribe(Data => {
            console.log(Data);
            alert("Datos Actualizados");
        })
    }

    Salir() {
        this.router.navigate(["ListarDisenosarq"]);
    }
}
